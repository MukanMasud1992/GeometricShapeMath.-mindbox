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
            //������� ������ �� ��� ������ ����� ������������
            //arrange - ���������� �����
            var circle = new Circle();
            circle.Radius = radius;
            //act - ���������� ������
            circle.Square = circle.SquareOfShape();
            //assert - �������� ������
            Assert.IsNotNull(circle.Square);
            Assert.Negative(circle.Square);
        }
        [TestCase(5,8,9)]
        public void Triangle_ShouldReturnNotNullOrNegative(int firstSide,int secondSide, int thirdSide)
        {
            //������� ������ �� ��� ������ ����� ������������
            //arrange - ���������� �����
            var triagle = new Triangle();
            triagle.FirstTriangleSide = firstSide;
            triagle.SecondTriangleSide = secondSide;
            triagle.ThirdTriangleSide = thirdSide;
            //act - ���������� ������
            triagle.Square = triagle.SquareOfShape();
            //assert - �������� ������
            Assert.IsNotNull(triagle.Square);
            Assert.Negative(triagle.Square);
        }
    }
}