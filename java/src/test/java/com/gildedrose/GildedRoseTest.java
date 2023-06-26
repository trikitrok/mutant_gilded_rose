package com.gildedrose;

import static org.junit.jupiter.api.Assertions.assertEquals;

import org.junit.jupiter.api.Test;

public class GildedRoseTest {

  @Test
  public void fix_me() {
    Item[] items = new Item[]{new Item("foo", 0, 0)};
    GildedRose app = new GildedRose(items);

    app.updateQuality();

    assertEquals("fixme", app.items[0].name);
  }
}
