namespace Parse_Tests
{
    public class Tests
    {
        Parser.Parser _parser = new Parser.Parser();
        [SetUp]
        public void Setup()
        {
        }
        [TestCase(new byte[]{6,4,8,'И','в','а','н','о','в','И','в','а','н', 'И', 'в', 'а', 'н', 'о', 'в','и','ч' },"Иванов","Иван","Иванович")]
        public void Test(byte[] buf, string expectedFam, string expectedName, string expectedSurName) 
        {
            string actualFam;
            string actualName;
            string actualSurname;

            try
            {
                _parser.parser(buf, out actualFam, out actualName, out actualSurname);
                if (
                        (actualFam == expectedFam)
                        && (actualName == expectedName)
                        && (actualSurname == expectedSurName)
                    )
                    Assert.Pass();
                else
                    Assert.Fail();
            }
            catch (Exception exc) 
            {
                Assert.Fail(exc.Message);
            }
        }
    }
}