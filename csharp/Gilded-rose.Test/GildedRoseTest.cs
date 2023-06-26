using System.Collections.Generic;
using Xunit;

namespace Gilded_rose.Test
{
    public class GildedRoseTest
    {
        [Fact]
        public void fix_me()
        {
            IList<Item> items = new List<Item> { new Item("foo", 0, 0) };
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.Equal("fixme", items[0].Name);
        }

    }
}