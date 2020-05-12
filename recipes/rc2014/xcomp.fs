0x8000 CONSTANT RAMSTART
0xf000 CONSTANT RS_ADDR
0xfffa CONSTANT PS_ADDR
0x80   CONSTANT ACIA_CTL
0x81   CONSTANT ACIA_IO
4      CONSTANT SDC_SPI
5      CONSTANT SDC_CSLOW
6      CONSTANT SDC_CSHIGH
RAMSTART 0x70 + CONSTANT ACIA_MEM
212 LOAD  ( z80 assembler )
262 LOAD  ( xcomp )
: CODE XCODE ;
: IMMEDIATE XIMM ;
: (entry) (xentry) ;
: CREATE XCREATE ;
: : [ ' X: , ] ;

CURRENT @ XCURRENT !

282 LOAD  ( boot.z80 )
393 LOAD  ( icore low )
352 LOAD  ( acia )
372 LOAD  ( sdc.z80 )
415 LOAD  ( icore high )
(entry) _
( Update LATEST )
PC ORG @ 8 + !
422 452 XPACKR ( core print fmt readln )
123 132 XPACKR ( linker )
," : _ ACIA$ RDLN$ (ok) ; _ "
ORG @ 256 /MOD 2 PC! 2 PC!
H@ 256 /MOD 2 PC! 2 PC!