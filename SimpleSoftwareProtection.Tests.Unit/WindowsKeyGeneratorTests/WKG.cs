using SimpleSoftwareProtection.Core.Windows;

namespace SimpleSoftwareProtection.Windows.Tests.Unit.WindowsKeyGeneratorTests;

public class WKG
{
    [Fact]
    public void ShouldGetPublicKey()
    {
        //given
        var secretKey = "MYSECRET_TEST_KEY";
        var expectedGeneratedKey = "ZtugF3idIiqMGd2ey8G479K4dyRD89HWf+h+LdsMlYg=";
        var windowsKeyGenerator = new WindowsKeyGenerator(secretKey, "BFEBFBFF000206D7", "058F312D810", "ALASKA - 1072009");

        //when 
        var generatedKey = windowsKeyGenerator.ReturnKey();

        //then
        Assert.False(String.IsNullOrWhiteSpace(generatedKey));
        Assert.True(generatedKey.Equals(expectedGeneratedKey));
    }

    [Fact]
    public void ShouldGetDifferentPublicKey()
    {
        //given
        var secretKey = "MYSECRET_TEST_KEY_ALTER";
        var expectedGeneratedKey = "ZtugF3idIiqMGd2ey8G479K4dyRD89HWf+h+LdsMlYg=";
        var windowsKeyGenerator = new WindowsKeyGenerator(secretKey, "BFEBFBFF000206D7", "50026B738071F2B7", "ALASKA - 1072009");

        //when 
        var generatedKey = windowsKeyGenerator.ReturnKey();

        //then
        Assert.False(String.IsNullOrWhiteSpace(generatedKey));
        Assert.False(generatedKey.Equals(expectedGeneratedKey));
    }
}
