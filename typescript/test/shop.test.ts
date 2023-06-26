import {Shop} from '../src/Shop';
import {Item} from "../src/Item";

describe('Gilded Rose', () => {
  it('fix me', () => {
    const items = [new Item('foo', 0, 0)];
    const shop = new Shop(items);
    
    shop.update();
    
    expect(items[0].name).toBe('lala');
  });
});
