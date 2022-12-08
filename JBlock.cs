﻿namespace Tetris
//Karen Tituaña 
{
    // Clase hija (JBlock) de una clase padre (Block)
    public class JBlock : Block
    {
        public override int Id => 2;

        protected override Position StartOffset => new(0, 3);

        protected override Position[][] Tiles => new Position[][] {
            // El bloque J tiene 4 movimientos
            new Position[] {new(0, 0), new(1, 0), new(1, 1), new(1, 2)},
            new Position[] {new(0, 1), new(0, 2), new(1, 1), new(2, 1)},
            new Position[] {new(1, 0), new(1, 1), new(1, 2), new(2, 2)},
            new Position[] {new(0, 1), new(1, 1), new(2, 1), new(2, 0)}
        };
        
    }
}
