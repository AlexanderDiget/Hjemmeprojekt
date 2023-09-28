using OrangeTreeSim;
<<<<<<< HEAD
using System.IO.IsolatedStorage;
=======
>>>>>>> 6a2159d2d00d45c6cfcf864b75b885aaaaacf24d

namespace OrangeTreeTest
{
    [TestClass]
    public class UnitTest1
    {
        private OrangeTree orangeTree;

        [TestInitialize]
        public void SetupForTest()
        {
<<<<<<< HEAD
            /*
=======
>>>>>>> 6a2159d2d00d45c6cfcf864b75b885aaaaacf24d
            // Start an orange tree
            orangeTree = new OrangeTree();
            orangeTree.SetAge(0);
            orangeTree.SetHeight(6);
            orangeTree.SetTreeAlive(true);
<<<<<<< HEAD
            */
            orangeTree = new OrangeTree();
            orangeTree.Age = 0;
            orangeTree.Height = 6;
            orangeTree.TreeAlive = true;
=======
>>>>>>> 6a2159d2d00d45c6cfcf864b75b885aaaaacf24d
        }

        [TestMethod]
        public void ShouldIncrementTheTreesAgeWithEachPassingYear()
        {
            //Act
            orangeTree.OneYearPasses();

            //Assert
<<<<<<< HEAD
            //Assert.AreEqual(1, orangeTree.GetAge());
            Assert.AreEqual(1, orangeTree.Age);
=======
            Assert.AreEqual(1, orangeTree.GetAge());
>>>>>>> 6a2159d2d00d45c6cfcf864b75b885aaaaacf24d
        }
        [TestMethod]
        public void ShouldIncrementTheTreesHeightByTwoWithEachPassingYear()
        {
            //Act
            orangeTree.OneYearPasses();

            //Assert
<<<<<<< HEAD
            //Assert.AreEqual(8, orangeTree.GetHeight());
            Assert.AreEqual(8, orangeTree.Height);
=======
            Assert.AreEqual(8, orangeTree.GetHeight());
>>>>>>> 6a2159d2d00d45c6cfcf864b75b885aaaaacf24d
        }
        [TestMethod]
        public void ShouldDieAfter80Years()
        {
            //Act
            for (int i = 1; i <= 80; i++)
            {
                orangeTree.OneYearPasses();
            }

            //Assert
<<<<<<< HEAD
            //Assert.AreEqual(false, orangeTree.GetTreeAlive());
            Assert.AreEqual(false, orangeTree.TreeAlive);
=======
            Assert.AreEqual(false, orangeTree.GetTreeAlive());
>>>>>>> 6a2159d2d00d45c6cfcf864b75b885aaaaacf24d
        }

        [TestMethod]
        public void ShouldProduceFruitAfter2Years()
        {
            orangeTree.OneYearPasses();
<<<<<<< HEAD
            //Assert.AreEqual(0, orangeTree.GetNumOranges());
            Assert.AreEqual(0, orangeTree.NumOranges);

            orangeTree.OneYearPasses();
            //Assert.AreEqual(5, orangeTree.GetNumOranges());
            Assert.AreEqual(5, orangeTree.NumOranges);
=======
            Assert.AreEqual(0, orangeTree.GetNumOranges());

            orangeTree.OneYearPasses();
            Assert.AreEqual(5, orangeTree.GetNumOranges());
>>>>>>> 6a2159d2d00d45c6cfcf864b75b885aaaaacf24d

        }
        [TestMethod]
        public void ShouldIncreaseFruitProductionBy5PiecesEachYearAfterMaturity()
        {
            orangeTree.OneYearPasses();
            orangeTree.OneYearPasses();
<<<<<<< HEAD
            //Assert.AreEqual(5, orangeTree.GetNumOranges());
            Assert.AreEqual(5, orangeTree.NumOranges);

            orangeTree.OneYearPasses();
            //Assert.AreEqual(10, orangeTree.GetNumOranges());
            Assert.AreEqual(10, orangeTree.NumOranges);

=======
            Assert.AreEqual(5, orangeTree.GetNumOranges());

            orangeTree.OneYearPasses();
            Assert.AreEqual(10, orangeTree.GetNumOranges());
>>>>>>> 6a2159d2d00d45c6cfcf864b75b885aaaaacf24d

        }
        [TestMethod]
        public void ShouldCountNumberOfOrangesEatenThisYear()
        {
            orangeTree.OneYearPasses();
            orangeTree.OneYearPasses();
            orangeTree.EatOrange(1);

<<<<<<< HEAD
            //Assert.AreEqual(1, orangeTree.GetOrangesEaten());
            Assert.AreEqual(1, orangeTree.OrangesEaten);

            orangeTree.EatOrange(3);
            //Assert.AreEqual(4, orangeTree.GetOrangesEaten());
            Assert.AreEqual(4, orangeTree.OrangesEaten);

            //Assert.AreEqual(1, orangeTree.GetNumOranges());
            Assert.AreEqual(1, orangeTree.NumOranges);
=======
            Assert.AreEqual(1, orangeTree.GetOrangesEaten());

            orangeTree.EatOrange(3);
            Assert.AreEqual(4, orangeTree.GetOrangesEaten());

            Assert.AreEqual(1, orangeTree.GetNumOranges());
>>>>>>> 6a2159d2d00d45c6cfcf864b75b885aaaaacf24d
        }
        [TestMethod]
        public void OrangesEatenOneYearPasses()
        {
            //Act
            orangeTree.OneYearPasses();
            orangeTree.OneYearPasses();
            orangeTree.EatOrange(1);
            orangeTree.EatOrange(3);
            orangeTree.OneYearPasses();
            //Assert
<<<<<<< HEAD
            //Assert.AreEqual(0, orangeTree.GetOrangesEaten());
            Assert.AreEqual(0, orangeTree.OrangesEaten);
            //Assert.AreEqual(10, orangeTree.GetNumOranges());
            Assert.AreEqual(10, orangeTree.NumOranges);
=======
            Assert.AreEqual(0, orangeTree.GetOrangesEaten());
            Assert.AreEqual(10, orangeTree.GetNumOranges());
>>>>>>> 6a2159d2d00d45c6cfcf864b75b885aaaaacf24d
        }

        [TestMethod]
        public void DeadTreeDoNotGrowAndProduceFruit()
        {
            //Act
            for (int i = 1; i <= 80; i++)
            {
                orangeTree.OneYearPasses();
            }

<<<<<<< HEAD
            /*
            Assert
            Assert.AreEqual(false, orangeTree.GetTreeAlive());
            Assert.AreEqual(0, orangeTree.GetNumOranges());
            Assert.AreEqual(164, orangeTree.GetHeight());
            Assert.AreEqual(81, orangeTree.GetAge());
            Assert.AreEqual(0, orangeTree.GetNumOranges());
            Assert.AreEqual(164, orangeTree.GetHeight());
            Assert.AreEqual(82, orangeTree.GetAge());
            */

            Assert.AreEqual(false, orangeTree.TreeAlive);
            orangeTree.OneYearPasses();
            Assert.AreEqual(0, orangeTree.NumOranges);
            Assert.AreEqual(164, orangeTree.Height);
            Assert.AreEqual(81, orangeTree.Age);
            orangeTree.OneYearPasses();
            Assert.AreEqual(0, orangeTree.NumOranges);
            Assert.AreEqual(164, orangeTree.Height);
            Assert.AreEqual(82, orangeTree.Age);
=======
            //Assert
            Assert.AreEqual(false, orangeTree.GetTreeAlive());
            orangeTree.OneYearPasses();
            Assert.AreEqual(0, orangeTree.GetNumOranges());
            Assert.AreEqual(164, orangeTree.GetHeight());
            Assert.AreEqual(81, orangeTree.GetAge());
            orangeTree.OneYearPasses();
            Assert.AreEqual(0, orangeTree.GetNumOranges());
            Assert.AreEqual(164, orangeTree.GetHeight());
            Assert.AreEqual(82, orangeTree.GetAge());
>>>>>>> 6a2159d2d00d45c6cfcf864b75b885aaaaacf24d

        }
    }
}

    




       