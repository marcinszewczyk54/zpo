using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace _2
{
    [TestFixture]
    class KontoBankoweTest
    {
        [Test]

        public void WyplacTest()
        {
            KontoBankowe pierwsze = new KontoBankowe(10.0);
            KontoBankowe drugie = new KontoBankowe(100.0);
            Assert.Multiple(() =>
            {
                Assert.Throws(Is.TypeOf<Exception>().And.Message.EqualTo("Kwota wyplacana musi byc wieksza od 0"), () => pierwsze.Wyplac(0.0));
                Assert.Throws(Is.TypeOf<Exception>().And.Message.EqualTo("Kwota wyplacana musi byc wieksza od 0"), () => pierwsze.Wyplac(-1.0));
                Assert.Throws(Is.TypeOf<Exception>().And.Message.EqualTo("Kwota wieksza od stanu konta"), () => pierwsze.Wyplac(100.0));

                Assert.Throws(Is.TypeOf<Exception>().And.Message.EqualTo("Kwota wyplacana musi byc wieksza od 0"), () => drugie.Wyplac(0.0));
                Assert.Throws(Is.TypeOf<Exception>().And.Message.EqualTo("Kwota wyplacana musi byc wieksza od 0"), () => drugie.Wyplac(-1.0));
                Assert.Throws(Is.TypeOf<Exception>().And.Message.EqualTo("Kwota wieksza od stanu konta"), () => drugie.Wyplac(1000.0));

                Assert.AreEqual(100.0, drugie.Wyplac(50.0));
                Assert.AreEqual(100.0, drugie.Stankonta());

            });
        }
        [Test]
        public void WplacTest()
        {
            KontoBankowe pierwsze = new KontoBankowe(100);

            Assert.Multiple(() =>
            {
                Assert.Throws(Is.TypeOf<Exception>().And.Message.EqualTo("Kwota wyplacana musi byc wieksza od 0"), () => pierwsze.Wplac(0.0));
                Assert.Throws(Is.TypeOf<Exception>().And.Message.EqualTo("Kwota wyplacana musi byc wieksza od 0"), () => pierwsze.Wplac(-1.0));
                Assert.AreEqual(150, pierwsze.Wplac(50));
            });
        }

        [Test]
        public void StanKontaTestMethod()
        {
            KontoBankowe pierwsze = new KontoBankowe(100);

            Assert.Multiple(() =>
            {
                Assert.AreEqual(100.0, pierwsze.Stankonta());
                Assert.AreNotEqual(101.0, pierwsze.Stankonta());
            });
        }

        [Test]
        public void PrzelewTestMethod()
        {
            KontoBankowe pierwsze = new KontoBankowe(100);
            KontoBankowe drugie = new KontoBankowe(100);

            Assert.Multiple(() =>
            {
                Assert.Throws(Is.TypeOf<Exception>().And.Message.EqualTo("Kwota wyplacana musi byc wieksza od 0"), () => pierwsze.Przelew(drugie, 0.0));
                Assert.Throws(Is.TypeOf<Exception>().And.Message.EqualTo("Kwota wyplacana musi byc wieksza od 0"), () => pierwsze.Przelew(drugie, -1.0));
                Assert.Throws(Is.TypeOf<Exception>().And.Message.EqualTo("Kwota wieksza od stanu konta"), () => pierwsze.Przelew(drugie, 1000.0));

                pierwsze.Przelew(drugie, 50.0);

                Assert.AreEqual(50.0, pierwsze.Stankonta());
                Assert.AreEqual(150.0, drugie.Stankonta());
            });
        }
    }
}
