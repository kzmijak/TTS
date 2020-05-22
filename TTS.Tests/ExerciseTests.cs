using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTS;
using Xunit;

namespace TTS.Tests
{
    public class ExerciseTests
    {
        [Theory]
        [InlineData(3,0.66, 1.5, 3)]
        [InlineData(3,1, 1.5, -1)]
        public void StartExercise_ShouldValidateData(double h, double b, double w, double expected)
        {
            // Arrange
            // Handled by XUnit

            // Act
            double actual = TTS.Exercise.StartExercise(h, b, w);

            // Assert
            Assert.Equal(expected, actual);

        }
    }
}
