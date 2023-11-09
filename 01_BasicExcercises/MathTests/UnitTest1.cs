using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MiinusLasku_kahdellaKokonaisluvulla_PlauttaaKokonaisluku()
        {
            // arrange
            int vähennettäväLuku = -1;
            int vähentäväLuku = -1;

            // act
            int tulos = MathOperations.MiinusLasku(vähennettäväLuku, vähentäväLuku);

            // assert
            Assert.AreEqual(0, tulos);
        }

        [TestMethod]
        public void ToisenPotensiin_YhdelläKokonaisluvulla_Palauttaakokonaisluvun()
        {
            // arrange
            int lukuPotenssinKahdella = 2;

            // act
            int tulos = MathOperations.ToisenPotensiin(lukuPotenssinKahdella);

            // assert
            Assert.AreEqual(4, tulos);
        }

        [TestMethod]
        public void LuvunNeliöJuuri_YhdelläKokonaisluvulla_PalauttaaDesimaaliLuvun()
        {
            // arrange
            int lukuneliöjuureen = 2;

            // act
            double tulos = MathOperations.LuvunNeliöJuuri(lukuneliöjuureen);

            // assert
            Assert.AreEqual(1.4142135623730951, tulos);
        }

        [TestMethod]
        public void ListanPieninArvo_DesimaaliLuku_PalautaaPienimmänLuvunListasta()
        {
            // arrange
            List<double> listanArvot = new List<double> { 2.3, 1.5, 3.7, 2.0, 4.2 };


            // act
            double pieninarvo = MathOperations.ListanPieninArvo(listanArvot);

            // assert
            Assert.AreEqual(1.5, pieninarvo);
        }

        [TestMethod]
        public void ListanSuurinarvo_Kokonaisluku_PalauttaaListanSuurinmanArvon()
        {
            // arrange
            List<int> listanArvot = new List<int> { 2, 1, 3, 2, 4 };

            // act
            int suurinArvo = MathOperations.ListanSuurinArvo(listanArvot);

            // assert
            Assert.AreEqual(4, suurinArvo);
        }
    }
}