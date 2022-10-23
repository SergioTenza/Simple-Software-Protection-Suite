using SimpleSoftwareProtection.Core.Decryption;

namespace SimpleSoftwareProtection.Standard.Tests.Unit.DecryptionTests
{
    public class ValidateKeyUnitTest
    {
        [Fact]
        public void ShouldThrowArgumentNullExceptionOnEnvironmentVariableNotSet()
        {
            //given
            var expectedExceptionMessage = "Value cannot be null. (Parameter 'The environemt variable SSP_SECRET Must be set on system.')";         
            //when
            var response = Assert.Throws<ArgumentNullException>(
                () => new ValidateKey());
            //then

            Assert.Equal(typeof(ArgumentNullException),response.GetType());
            Assert.True(response.Message == expectedExceptionMessage);
        }

        [Fact]
        public void ShouldBeFalseOnEnvironmentVariableSetAndBadInputData()
        {
            //given
            var storedKey = "ZtugF3idIiqMGd2ey8G479K4dyRD89HWf+h+LdsMlYg=";
            var storedCpu = "BFEBFBFF000206D7";
            var storedHdd = "058F312D810";
            var storedBios = "ALASKA - 1072009";
            Environment.SetEnvironmentVariable("SSP_SECRET","MYSECRET_TEST_KEY_ALTER");
            //when
            var keyValidator = new ValidateKey();
            var response = keyValidator.CheckEncryptedKey(storedKey,storedCpu,storedHdd,storedBios);
            Environment.SetEnvironmentVariable("SSP_SECRET", null);

            //then
            Assert.False(response);
            Assert.Null(Environment.GetEnvironmentVariable("SSP_SECRET"));

           
        }
        [Fact]
        public void ShouldBeTrueOnEnvironmentVariableSetAndCorrectInputData()
        {
            //given
            var storedKey = "ZtugF3idIiqMGd2ey8G479K4dyRD89HWf+h+LdsMlYg=";
            var storedCpu = "BFEBFBFF000206D7";
            var storedHdd = "058F312D810";
            var storedBios = "ALASKA - 1072009";
            Environment.SetEnvironmentVariable("SSP_SECRET", "MYSECRET_TEST_KEY");
            //when
            var keyValidator = new ValidateKey();
            var response = keyValidator.CheckEncryptedKey(storedKey, storedCpu, storedHdd, storedBios);
            Environment.SetEnvironmentVariable("SSP_SECRET", null);

            //then
            Assert.True(response);
            Assert.Null(Environment.GetEnvironmentVariable("SSP_SECRET"));


        }
    }
}
