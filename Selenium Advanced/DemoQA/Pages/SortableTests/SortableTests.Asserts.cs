using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.SortableTests
{
    public partial class SortableTests : BasePage
    {
        public void AssertChangeOfPlaces(string OneTextAfter, string TwotextAfter)
        {
            this.WaitForLoad();
            Assert.AreEqual("Two", OneTextAfter);
            Assert.AreEqual("One", TwotextAfter);
        }

    }

    

   
}
