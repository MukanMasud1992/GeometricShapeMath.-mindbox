using GeometricShapeMath.Model;
namespace GeometricShape.Unit_tests
{
    public class GeometricShapesUnitTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [TestCase(5)]
        public void CircleSquare_ShouldReturnNotNullOrNegative(int radius)
        {
            //деление тестов на три разные этапы тестирование
            //arrange - подготовка теста
            var circle = new Circle();
            circle.Radius = radius;
            //act - выполнение логики
            circle.Square = circle.SquareOfShape();
            //assert - проверка логики
            Assert.IsNotNull(circle.Square);
            Assert.Negative(circle.Square);
        }
        [TestCase(5,8,9)]
        public void Triangle_ShouldReturnNotNullOrNegative(int firstSide,int secondSide, int thirdSide)
        {
            //деление тестов на три разные этапы тестирование
            //arrange - подготовка теста
            var triagle = new Triangle();
            triagle.FirstTriangleSide = firstSide;
            triagle.SecondTriangleSide = secondSide;
            triagle.ThirdTriangleSide = thirdSide;
            //act - выполнение логики
            triagle.Square = triagle.SquareOfShape();
            //assert - проверка логики
            Assert.IsNotNull(triagle.Square);
            Assert.Negative(triagle.Square);
        }
    }
}