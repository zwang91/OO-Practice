namespace OOPracticeTest
{
    using OOPractice;
    using Xunit;

    public class CarTest
    {
        [Fact]
        public void Should_return_message_when_speed_up_given_car_name_and_engine_gasoline()
        {
            // given
            Engine engine = new Engine("Gasoline");
            Vehicle car = new Car("Cool Car", engine.Speed);
            // when
            string message = car.SpeedUp();
            // then
            Assert.Equal("Cool Car: speed up 30 km/h", message);
        }
    }
}
