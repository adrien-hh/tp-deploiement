namespace TestProject
{
	public class UnitTest1
	{
		[Fact]
		public void Result_Should_BeTrue()
		{
			// un test qui retourne true 

			// Arrange
			int input = 2;
			int inputSecond = 2;

			int result = input + inputSecond;

			Assert.Equal(4, result);

		}
	}
}