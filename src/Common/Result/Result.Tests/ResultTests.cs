namespace Result.Tests;

public class ResultTests
{
    [Fact]
    public void TestOkResult()
    {
        var res = Result.Ok();

        Assert.True(res.IsOK);
        Assert.False(res.IsError);
    }

    [Fact]
    public void TestKOResult()
    {
        var res = Result.FromError(Error.FromReason("a reason"));

        Assert.False(res.IsOK);
        Assert.True(res.IsError);
    }
}