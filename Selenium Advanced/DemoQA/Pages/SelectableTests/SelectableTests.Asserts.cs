using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.SelectableTests
{
    public partial class SelectableTests : BasePage
    {
        public void AssertColoursAreNotEqual(string ColourBefore,string ColourAfter )
        {
            this.WaitForLoad();
            Assert.AreNotEqual(ColourBefore, ColourAfter);
            Assert.AreEqual("rgba(0, 123, 255, 1)", ColourAfter);
        }

        public void AssertColoursAreNotEqual(string ColourBeforeFirst, string ColourAfterFirst,
                                            string ColourBeforeSecond, string ColourAfterSecond)
        {
            this.WaitForLoad();
            Assert.AreNotEqual(ColourBeforeFirst, ColourAfterFirst);
            Assert.AreNotEqual(ColourBeforeSecond, ColourAfterSecond);
            Assert.AreEqual("rgba(0, 123, 255, 1)", ColourAfterFirst);
            Assert.AreEqual("rgba(0, 123, 255, 1)", ColourAfterSecond);
        }

    }

          
    
}
