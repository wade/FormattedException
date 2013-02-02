using NUnit.Framework;

namespace System
{
	[TestFixture]
	public class FormattedExceptionTests
	{
		[Test]
		public void CanConstructUsingDefaultConstructor()
		{
			// Arrange
			const string expectedMessage = "Exception of type 'System.TestException' was thrown.";

			// Act
			TestException testException = new TestException();

			// Assert
			Assert.IsNotNull(testException);
			Assert.IsNull(testException.InnerException);
			Assert.AreEqual(expectedMessage, testException.Message);
		}

		[Test]
		public void CanConstructUsingConstructorWithMessageParameter()
		{
			// Arrange
			const string expectedMessage = "This is a test exception.";

			// Act
			TestException testException = new TestException(expectedMessage);

			// Assert
			Assert.IsNotNull(testException);
			Assert.IsNull(testException.InnerException);
			Assert.AreEqual(expectedMessage, testException.Message);
		}

		[Test]
		public void CanConstructUsingConstructorWithMessageParameterWithEmptyStringValue()
		{
			// Arrange
			const string expectedMessage = "";

			// Act
			TestException testException = new TestException(string.Empty);

			// Assert
			Assert.IsNotNull(testException);
			Assert.IsNull(testException.InnerException);
			Assert.AreEqual(expectedMessage, testException.Message);
		}

		[Test]
		public void CanConstructUsingConstructorWithMessageParameterWithNullValue()
		{
			// Arrange
			const string expectedMessage = "Exception of type 'System.TestException' was thrown.";

			// Act
			TestException testException = new TestException(null);

			// Assert
			Assert.IsNotNull(testException);
			Assert.IsNull(testException.InnerException);
			Assert.AreEqual(expectedMessage, testException.Message);
		}

		[Test]
		public void CanConstructUsingConstructorWithMessageAndInnerExceptionParameters()
		{
			// Arrange
			const string expectedMessage = "This is a test exception.";
			const string expectedArgumentMessage = "This is a test argument exception.";
			ArgumentException testInnerException = new ArgumentException(expectedArgumentMessage);

			// Act
			TestException testException = new TestException(expectedMessage, testInnerException);

			// Assert
			Assert.IsNotNull(testException);
			Assert.IsNotNull(testException.InnerException);
			Assert.AreSame(testInnerException, testException.InnerException);
			Assert.AreEqual(expectedArgumentMessage, testException.InnerException.Message);
			Assert.AreEqual(expectedMessage, testException.Message);
		}

		[Test]
		public void CanConstructUsingConstructorWithFormattedMessageParameterAndOneFormatArgument()
		{
			// Arrange
			const string messageFormat = "This is a test exception with a value of {0}.";
			
			const int value = 123;
			object arg0 = value;

			const string expectedMessage = "This is a test exception with a value of 123.";

			// Act
			TestException testException = new TestException(messageFormat, arg0);

			// Assert
			Assert.IsNotNull(testException);
			Assert.IsNull(testException.InnerException);
			Assert.AreEqual(expectedMessage, testException.Message);
		}

		[Test]
		public void CanConstructUsingConstructorWithFormattedMessageParameterAndTwoFormatArguments()
		{
			// Arrange
			const string messageFormat = "This is a test exception with a two values: {0} and {1}.";
			
			const int value1 = 123;
			object arg0 = value1;
			const bool value2 = false;
			object arg1 = value2;

			const string expectedMessage = "This is a test exception with a two values: 123 and False.";

			// Act
			TestException testException = new TestException(messageFormat, arg0, arg1);

			// Assert
			Assert.IsNotNull(testException);
			Assert.IsNull(testException.InnerException);
			Assert.AreEqual(expectedMessage, testException.Message);
		}

		[Test]
		public void CanConstructUsingConstructorWithFormattedMessageParameterAndThreeFormatArguments()
		{
			// Arrange
			const string messageFormat = "This is a test exception with a three values: {0}, {1} and {2}.";
			
			const int value1 = 123;
			object arg0 = value1;
			const bool value2 = false;
			object arg1 = value2;
			const string value3 = "Hello";
			object arg2 = value3;

			const string expectedMessage = "This is a test exception with a three values: 123, False and Hello.";

			// Act
			TestException testException = new TestException(messageFormat, arg0, arg1, arg2);

			// Assert
			Assert.IsNotNull(testException);
			Assert.IsNull(testException.InnerException);
			Assert.AreEqual(expectedMessage, testException.Message);
		}

		[Test]
		public void CanConstructUsingConstructorWithFormattedMessageParameterAndObjectArrayParamsFormatArgumentWithOneArgAsObjectArray()
		{
			// Arrange
			const string messageFormat = "This is a test exception with a value of {0}.";

			const int value = 123;
			object arg0 = value;

			object[] args = new[] { arg0 };

			const string expectedMessage = "This is a test exception with a value of 123.";

			// Act
			TestException testException = new TestException(messageFormat, args);

			// Assert
			Assert.IsNotNull(testException);
			Assert.IsNull(testException.InnerException);
			Assert.AreEqual(expectedMessage, testException.Message);
		}

		[Test]
		public void CanConstructUsingConstructorWithFormattedMessageParameterAndObjectArrayParamsFormatArgumentWithTwoArgsAsObjectArray()
		{
			// Arrange
			const string messageFormat = "This is a test exception with a two values: {0} and {1}.";
			
			const int value1 = 123;
			object arg0 = value1;
			const bool value2 = false;
			object arg1 = value2;

			object[] args = new[] { arg0, arg1 };

			const string expectedMessage = "This is a test exception with a two values: 123 and False.";

			// Act
			TestException testException = new TestException(messageFormat, args);

			// Assert
			Assert.IsNotNull(testException);
			Assert.IsNull(testException.InnerException);
			Assert.AreEqual(expectedMessage, testException.Message);
		}

		[Test]
		public void CanConstructUsingConstructorWithFormattedMessageParameterAndObjectArrayParamsFormatArgumentWithThreeArgsAsObjectArray()
		{
			// Arrange
			const string messageFormat = "This is a test exception with a three values: {0}, {1} and {2}.";

			const int value1 = 123;
			object arg0 = value1;
			const bool value2 = false;
			object arg1 = value2;
			const string value3 = "Hello";
			object arg2 = value3;

			object[] args = new[] {arg0, arg1, arg2};

			const string expectedMessage = "This is a test exception with a three values: 123, False and Hello.";

			// Act
			TestException testException = new TestException(messageFormat, args);

			// Assert
			Assert.IsNotNull(testException);
			Assert.IsNull(testException.InnerException);
			Assert.AreEqual(expectedMessage, testException.Message);
		}

		[Test]
		public void CanConstructUsingConstructorWithFormattedMessageParameterAndObjectArrayParamsFormatArgumentWithFourArgsAsObjectArray()
		{
			// Arrange
			const string messageFormat = "This is a test exception with a four values: {0}, {1}, {2} and {3}.";

			const int value1 = 123;
			object arg0 = value1;
			const bool value2 = false;
			object arg1 = value2;
			const string value3 = "Hello";
			object arg2 = value3;
			const string value4 = "World";
			object arg3 = value4;

			object[] args = new[] { arg0, arg1, arg2, arg3 };

			const string expectedMessage = "This is a test exception with a four values: 123, False, Hello and World.";

			// Act
			TestException testException = new TestException(messageFormat, args);

			// Assert
			Assert.IsNotNull(testException);
			Assert.IsNull(testException.InnerException);
			Assert.AreEqual(expectedMessage, testException.Message);
		}

		[Test]
		public void CanConstructUsingConstructorWithFormattedMessageParameterAndObjectArrayParamsFormatArgumentWithOneArg()
		{
			// Arrange
			const string messageFormat = "This is a test exception with a value of {0}.";

			const int value = 123;

			const string expectedMessage = "This is a test exception with a value of 123.";

			// Act
			TestException testException = new TestException(messageFormat, value);

			// Assert
			Assert.IsNotNull(testException);
			Assert.IsNull(testException.InnerException);
			Assert.AreEqual(expectedMessage, testException.Message);
		}

		[Test]
		public void CanConstructUsingConstructorWithFormattedMessageParameterAndObjectArrayParamsFormatArgumentWithTwoArgs()
		{
			// Arrange
			const string messageFormat = "This is a test exception with a two values: {0} and {1}.";

			const int value1 = 123;
			const bool value2 = false;

			const string expectedMessage = "This is a test exception with a two values: 123 and False.";

			// Act
			TestException testException = new TestException(messageFormat, value1, value2);

			// Assert
			Assert.IsNotNull(testException);
			Assert.IsNull(testException.InnerException);
			Assert.AreEqual(expectedMessage, testException.Message);
		}

		[Test]
		public void CanConstructUsingConstructorWithFormattedMessageParameterAndObjectArrayParamsFormatArgumentWithThreeArgs()
		{
			// Arrange
			const string messageFormat = "This is a test exception with a three values: {0}, {1} and {2}.";

			const int value1 = 123;
			const bool value2 = false;
			const string value3 = "Hello";

			const string expectedMessage = "This is a test exception with a three values: 123, False and Hello.";

			// Act
			TestException testException = new TestException(messageFormat, value1, value2, value3);

			// Assert
			Assert.IsNotNull(testException);
			Assert.IsNull(testException.InnerException);
			Assert.AreEqual(expectedMessage, testException.Message);
		}

		[Test]
		public void CanConstructUsingConstructorWithFormattedMessageParameterAndObjectArrayParamsFormatArgumentWithFourArgs()
		{
			// Arrange
			const string messageFormat = "This is a test exception with a four values: {0}, {1}, {2} and {3}.";

			const int value1 = 123;
			const bool value2 = false;
			const string value3 = "Hello";
			const string value4 = "World";

			const string expectedMessage = "This is a test exception with a four values: 123, False, Hello and World.";

			// Act
			TestException testException = new TestException(messageFormat, value1, value2, value3, value4);

			// Assert
			Assert.IsNotNull(testException);
			Assert.IsNull(testException.InnerException);
			Assert.AreEqual(expectedMessage, testException.Message);
		}

		[Test]
		public void CanConstructUsingConstructorWithInnerExceptionAndMessageParameters()
		{
			// Arrange
			const string expectedMessage = "This is a test exception.";
			const string expectedArgumentMessage = "This is a test argument exception.";
			ArgumentException testInnerException = new ArgumentException(expectedArgumentMessage);

			// Act
			TestException testException = new TestException(testInnerException, expectedMessage);

			// Assert
			Assert.IsNotNull(testException);
			Assert.IsNotNull(testException.InnerException);
			Assert.AreSame(testInnerException, testException.InnerException);
			Assert.AreEqual(expectedArgumentMessage, testException.InnerException.Message);
			Assert.AreEqual(expectedMessage, testException.Message);
		}

		[Test]
		public void CanConstructUsingConstructorWithInnerExceptionAndFormattedMessageParameterAndOneFormatArgument()
		{
			// Arrange
			const string messageFormat = "This is a test exception with a value of {0}.";

			const int value = 123;
			object arg0 = value;

			const string expectedMessage = "This is a test exception with a value of 123.";

			const string expectedArgumentMessage = "This is a test argument exception.";
			ArgumentException testInnerException = new ArgumentException(expectedArgumentMessage);

			// Act
			TestException testException = new TestException(testInnerException, messageFormat, arg0);

			// Assert
			Assert.IsNotNull(testException);
			Assert.IsNotNull(testException.InnerException);
			Assert.AreSame(testInnerException, testException.InnerException);
			Assert.AreEqual(expectedArgumentMessage, testException.InnerException.Message);
			Assert.AreEqual(expectedMessage, testException.Message);
		}

		[Test]
		public void CanConstructUsingConstructorWithInnerExceptionAndFormattedMessageParameterAndTwoFormatArguments()
		{
			// Arrange
			const string messageFormat = "This is a test exception with a two values: {0} and {1}.";

			const int value1 = 123;
			object arg0 = value1;
			const bool value2 = false;
			object arg1 = value2;

			const string expectedMessage = "This is a test exception with a two values: 123 and False.";

			const string expectedArgumentMessage = "This is a test argument exception.";
			ArgumentException testInnerException = new ArgumentException(expectedArgumentMessage);

			// Act
			TestException testException = new TestException(testInnerException, messageFormat, arg0, arg1);

			// Assert
			Assert.IsNotNull(testException);
			Assert.IsNotNull(testException.InnerException);
			Assert.AreSame(testInnerException, testException.InnerException);
			Assert.AreEqual(expectedArgumentMessage, testException.InnerException.Message);
			Assert.AreEqual(expectedMessage, testException.Message);
		}

		[Test]
		public void CanConstructUsingConstructorWithInnerExceptionAndFormattedMessageParameterAndThreeFormatArguments()
		{
			// Arrange
			const string messageFormat = "This is a test exception with a three values: {0}, {1} and {2}.";

			const int value1 = 123;
			object arg0 = value1;
			const bool value2 = false;
			object arg1 = value2;
			const string value3 = "Hello";
			object arg2 = value3;

			const string expectedMessage = "This is a test exception with a three values: 123, False and Hello.";

			const string expectedArgumentMessage = "This is a test argument exception.";
			ArgumentException testInnerException = new ArgumentException(expectedArgumentMessage);

			// Act
			TestException testException = new TestException(testInnerException, messageFormat, arg0, arg1, arg2);

			// Assert
			Assert.IsNotNull(testException);
			Assert.IsNotNull(testException.InnerException);
			Assert.AreSame(testInnerException, testException.InnerException);
			Assert.AreEqual(expectedArgumentMessage, testException.InnerException.Message);
			Assert.AreEqual(expectedMessage, testException.Message);
		}

		[Test]
		public void CanConstructUsingConstructorWithInnerExceptionAndFormattedMessageParameterAndObjectArrayParamsFormatArgumentWithOneArgAsObjectArray()
		{
			// Arrange
			const string messageFormat = "This is a test exception with a value of {0}.";

			const int value = 123;
			object arg0 = value;

			object[] args = new[] { arg0 };

			const string expectedMessage = "This is a test exception with a value of 123.";

			const string expectedArgumentMessage = "This is a test argument exception.";
			ArgumentException testInnerException = new ArgumentException(expectedArgumentMessage);

			// Act
			TestException testException = new TestException(testInnerException, messageFormat, args);

			// Assert
			Assert.IsNotNull(testException);
			Assert.IsNotNull(testException.InnerException);
			Assert.AreSame(testInnerException, testException.InnerException);
			Assert.AreEqual(expectedArgumentMessage, testException.InnerException.Message);
			Assert.AreEqual(expectedMessage, testException.Message);
		}

		[Test]
		public void CanConstructUsingConstructorWithInnerExceptionAndFormattedMessageParameterAndObjectArrayParamsFormatArgumentWithTwoArgsAsObjectArray()
		{
			// Arrange
			const string messageFormat = "This is a test exception with a two values: {0} and {1}.";

			const int value1 = 123;
			object arg0 = value1;
			const bool value2 = false;
			object arg1 = value2;

			object[] args = new[] { arg0, arg1 };

			const string expectedMessage = "This is a test exception with a two values: 123 and False.";

			const string expectedArgumentMessage = "This is a test argument exception.";
			ArgumentException testInnerException = new ArgumentException(expectedArgumentMessage);

			// Act
			TestException testException = new TestException(testInnerException, messageFormat, args);

			// Assert
			Assert.IsNotNull(testException);
			Assert.IsNotNull(testException.InnerException);
			Assert.AreSame(testInnerException, testException.InnerException);
			Assert.AreEqual(expectedArgumentMessage, testException.InnerException.Message);
			Assert.AreEqual(expectedMessage, testException.Message);
		}

		[Test]
		public void CanConstructUsingConstructorWithInnerExceptionAndFormattedMessageParameterAndObjectArrayParamsFormatArgumentWithThreeArgsAsObjectArray()
		{
			// Arrange
			const string messageFormat = "This is a test exception with a three values: {0}, {1} and {2}.";

			const int value1 = 123;
			object arg0 = value1;
			const bool value2 = false;
			object arg1 = value2;
			const string value3 = "Hello";
			object arg2 = value3;

			object[] args = new[] { arg0, arg1, arg2 };

			const string expectedMessage = "This is a test exception with a three values: 123, False and Hello.";

			const string expectedArgumentMessage = "This is a test argument exception.";
			ArgumentException testInnerException = new ArgumentException(expectedArgumentMessage);

			// Act
			TestException testException = new TestException(testInnerException, messageFormat, args);

			// Assert
			Assert.IsNotNull(testException);
			Assert.IsNotNull(testException.InnerException);
			Assert.AreSame(testInnerException, testException.InnerException);
			Assert.AreEqual(expectedArgumentMessage, testException.InnerException.Message);
			Assert.AreEqual(expectedMessage, testException.Message);
		}

		[Test]
		public void CanConstructUsingConstructorWithInnerExceptionAndFormattedMessageParameterAndObjectArrayParamsFormatArgumentWithFourArgsAsObjectArray()
		{
			// Arrange
			const string messageFormat = "This is a test exception with a four values: {0}, {1}, {2} and {3}.";

			const int value1 = 123;
			object arg0 = value1;
			const bool value2 = false;
			object arg1 = value2;
			const string value3 = "Hello";
			object arg2 = value3;
			const string value4 = "World";
			object arg3 = value4;

			object[] args = new[] { arg0, arg1, arg2, arg3 };

			const string expectedMessage = "This is a test exception with a four values: 123, False, Hello and World.";

			const string expectedArgumentMessage = "This is a test argument exception.";
			ArgumentException testInnerException = new ArgumentException(expectedArgumentMessage);

			// Act
			TestException testException = new TestException(testInnerException, messageFormat, args);

			// Assert
			Assert.IsNotNull(testException);
			Assert.IsNotNull(testException.InnerException);
			Assert.AreSame(testInnerException, testException.InnerException);
			Assert.AreEqual(expectedArgumentMessage, testException.InnerException.Message);
			Assert.AreEqual(expectedMessage, testException.Message);
		}

		[Test]
		public void CanConstructUsingConstructorWithInnerExceptionAndFormattedMessageParameterAndObjectArrayParamsFormatArgumentWithOneArg()
		{
			// Arrange
			const string messageFormat = "This is a test exception with a value of {0}.";

			const int value = 123;

			const string expectedMessage = "This is a test exception with a value of 123.";

			const string expectedArgumentMessage = "This is a test argument exception.";
			ArgumentException testInnerException = new ArgumentException(expectedArgumentMessage);

			// Act
			TestException testException = new TestException(testInnerException, messageFormat, value);

			// Assert
			Assert.IsNotNull(testException);
			Assert.IsNotNull(testException.InnerException);
			Assert.AreSame(testInnerException, testException.InnerException);
			Assert.AreEqual(expectedArgumentMessage, testException.InnerException.Message);
			Assert.AreEqual(expectedMessage, testException.Message);
		}

		[Test]
		public void CanConstructUsingConstructorWithInnerExceptionAndFormattedMessageParameterAndObjectArrayParamsFormatArgumentWithTwoArgs()
		{
			// Arrange
			const string messageFormat = "This is a test exception with a two values: {0} and {1}.";

			const int value1 = 123;
			const bool value2 = false;

			const string expectedMessage = "This is a test exception with a two values: 123 and False.";

			const string expectedArgumentMessage = "This is a test argument exception.";
			ArgumentException testInnerException = new ArgumentException(expectedArgumentMessage);

			// Act
			TestException testException = new TestException(testInnerException, messageFormat, value1, value2);

			// Assert
			Assert.IsNotNull(testException);
			Assert.IsNotNull(testException.InnerException);
			Assert.AreSame(testInnerException, testException.InnerException);
			Assert.AreEqual(expectedArgumentMessage, testException.InnerException.Message);
			Assert.AreEqual(expectedMessage, testException.Message);
		}

		[Test]
		public void CanConstructUsingConstructorWithInnerExceptionAndFormattedMessageParameterAndObjectArrayParamsFormatArgumentWithThreeArgs()
		{
			// Arrange
			const string messageFormat = "This is a test exception with a three values: {0}, {1} and {2}.";

			const int value1 = 123;
			const bool value2 = false;
			const string value3 = "Hello";

			const string expectedMessage = "This is a test exception with a three values: 123, False and Hello.";

			const string expectedArgumentMessage = "This is a test argument exception.";
			ArgumentException testInnerException = new ArgumentException(expectedArgumentMessage);

			// Act
			TestException testException = new TestException(testInnerException, messageFormat, value1, value2, value3);

			// Assert
			Assert.IsNotNull(testException);
			Assert.IsNotNull(testException.InnerException);
			Assert.AreSame(testInnerException, testException.InnerException);
			Assert.AreEqual(expectedArgumentMessage, testException.InnerException.Message);
			Assert.AreEqual(expectedMessage, testException.Message);
		}

		[Test]
		public void CanConstructUsingConstructorWithInnerExceptionAndFormattedMessageParameterAndObjectArrayParamsFormatArgumentWithFourArgs()
		{
			// Arrange
			const string messageFormat = "This is a test exception with a four values: {0}, {1}, {2} and {3}.";

			const int value1 = 123;
			const bool value2 = false;
			const string value3 = "Hello";
			const string value4 = "World";

			const string expectedMessage = "This is a test exception with a four values: 123, False, Hello and World.";

			const string expectedArgumentMessage = "This is a test argument exception.";
			ArgumentException testInnerException = new ArgumentException(expectedArgumentMessage);

			// Act
			TestException testException = new TestException(testInnerException, messageFormat, value1, value2, value3, value4);

			// Assert
			Assert.IsNotNull(testException);
			Assert.IsNotNull(testException.InnerException);
			Assert.AreSame(testInnerException, testException.InnerException);
			Assert.AreEqual(expectedArgumentMessage, testException.InnerException.Message);
			Assert.AreEqual(expectedMessage, testException.Message);
		}
	}
}
