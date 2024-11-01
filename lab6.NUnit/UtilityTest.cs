using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6.NUnit
{
    // атрибут, указывающий на то, что это класс содержит тесты
    [TestFixture]
    internal class UtilityTest
    {
        Utility u = new Utility();
        // атрибут, указывающий на то, что это тестовый метод
        [TestCase]
        public void TestConvert()
        {
            //Тест функции конвертации
            // получение исключения
            var exception = Assert.Throws<ArgumentException>(() => u.Convert(10, "qwerty"));
            // сравнение полученного сообщения с ожидаемым
            Assert.That(exception.Message, Is.EqualTo("unit должен быть inch || cm"));
            // получение исключения отрицательного числа
            var exception2 = Assert.Throws<ArgumentException>(() => u.Convert(-2, "cm"));
            // сравнение полученного сообщения с ожидаемым
            Assert.That(exception2.Message, Is.EqualTo("Число должно быть > 0 < MaxValue"));

            Assert.AreEqual(25, u.Convert(10, "inch"));
            Assert.AreEqual(4, u.Convert(10, "cm"));
        }
        [TestCase]
        public void TestDefineOrOddNum()
        {
            //Тест функции Чет/Нечет
            Assert.IsTrue(u.DefineOrOddNum(4));
            Assert.IsFalse(u.DefineOrOddNum(5));
            Assert.IsFalse(u.DefineOrOddNum(-1));
        }
        [TestCase]
        public void TestBiggestNum()
        {
            //Тест функции нахождения наибольшего числа
            // получение исключения
            int[] arr = null;
            var exception = Assert.Throws<ArgumentException>(() => u.BiggestNum(arr));
            // сравнение полученного сообщения с ожидаемым
            Assert.That(exception.Message, Is.EqualTo("Массив не должен быть null"));
            // проверка выполняется успешно, если исключение не было сгенерировано
            Assert.DoesNotThrow(() => u.BiggestNum(new int[] { -1, 4, 15, 45, 5, 0, -4 }));
        }
        [TestCase]
        public void TestRemainder()
        {
            //Тест функции нахождения остатка от деления
            // получение исключения
            var exception = Assert.Throws<ArgumentException>(() => u.Remainder(14, 0));
            // сравнение полученного сообщения с ожидаемым
            Assert.That(exception.Message, Is.EqualTo("Делитель должен быть > 0"));
            // проверка выполняется успешно, если исключение не было сгенерировано
            Assert.DoesNotThrow(() => u.Remainder(2, 1));
        }
    }
}
