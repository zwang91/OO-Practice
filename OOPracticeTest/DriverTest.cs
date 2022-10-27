namespace OOPracticeTest
{
    using OOPractice;
    using Xunit;

    public class DriverTest
    {
        [Fact]
        public void Should_return_car_message_when_drive_a_car()
        {
            // given
            Vehicle car = new Car("Cool Car", 30);
            Driver driver = new Driver();
            // when
            string message = driver.Drive(car);
            // then
            Assert.Equal("Cool Car: speed up 30 km/h", message);
        }

        [Fact]
        public void Should_return_truck_message_when_drive_a_truck()
        {
            // given
            Vehicle truck = new Truck("Big Truck", 10);
            Driver driver = new Driver();
            // when
            string message = driver.Drive(truck);
            // then
            Assert.Equal("Big Truck: speed up 10 km/h", message);
        }
    }
}
