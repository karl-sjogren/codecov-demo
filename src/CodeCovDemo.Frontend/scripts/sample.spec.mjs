import { describe, expect, test } from 'vitest';
import { sum, subtract, divide } from './sample';

describe('sample', () => {
  test('adds 1 + 2 to equal 3', () => {
    expect(sum(1, 2)).toBe(3);
  });

  test('subtracts 2 - 1 to equal 1', () => {
    expect(subtract(2, 1)).toBe(1);
  });

  test('divides 6 / 2 to equal 3', () => {
    expect(divide(6, 2)).toBe(3);
  });

});
