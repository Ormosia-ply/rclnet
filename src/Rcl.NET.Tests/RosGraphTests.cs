﻿namespace Rcl.NET.Tests;

public class RosGraphTests
{
    [Fact]
    public async Task TestWaitForNode()
    {
        using var ctx = new RclContext(TestConfig.DefaultContextArguments);
        using var node = ctx.CreateNode(NameGenerator.GenerateNodeName());

        var nodeNameToBeWaited = NameGenerator.GenerateNodeName();
        var fullyQualifiedName = "/" + nodeNameToBeWaited;

        var isOnline = await node.Graph.TryWaitForNodeAsync(fullyQualifiedName, 0);
        Assert.False(isOnline);

        using var cts = new CancellationTokenSource();
        var t = RunAnotherNodeAsync(nodeNameToBeWaited, cts.Token);

        // Looks like node discovery is much slower on foxy, need to set to larger timeout here.
        isOnline = await node.Graph.TryWaitForNodeAsync(fullyQualifiedName, 500);
        Assert.True(isOnline);

        isOnline = await node.Graph.TryWaitForNodeAsync(fullyQualifiedName, 0);
        Assert.True(isOnline);

        cts.Cancel();
        await Task.WhenAny(t);

        isOnline = await node.Graph.TryWaitForNodeAsync(fullyQualifiedName, 0);
        Assert.False(isOnline);

        static async Task RunAnotherNodeAsync(string nodeName, CancellationToken cancellationToken)
        {
            await Task.Delay(10, cancellationToken);

            using var ctx = new RclContext(TestConfig.DefaultContextArguments);
            using var node = ctx.CreateNode(nodeName);

            await Task.Delay(-1, cancellationToken);
        }
    }

    [Fact]
    public Task ContinuationExecutionOfWaitForNode()
    {
        return Task.Run(async () =>
        {
            using var ctx = new RclContext(TestConfig.DefaultContextArguments);
            using var node = ctx.CreateNode(NameGenerator.GenerateNodeName());
            var nodeName = "non_existent_node";

            await node.Graph.TryWaitForNodeAsync(nodeName, 0);
            Assert.True(ctx.IsCurrent);

            await node.Graph.TryWaitForNodeAsync(nodeName, 0).ConfigureAwait(false);
            Assert.True(ctx.IsCurrent);

            using var context1 = new RclContext(TestConfig.DefaultContextArguments, useSynchronizationContext: true);
            await context1.Yield();

            await node.Graph.TryWaitForNodeAsync(nodeName, 0);
            Assert.True(context1.IsCurrent);

            await node.Graph.TryWaitForNodeAsync(nodeName, 0).ConfigureAwait(false);
            Assert.True(ctx.IsCurrent);
        });
    }
}
