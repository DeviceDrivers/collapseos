0xf000 CONSTANT RS_ADDR
0xfffa CONSTANT PS_ADDR
RS_ADDR 0x80 - CONSTANT RAMSTART
212 LOAD  ( z80 assembler )
262 LOAD  ( xcomp )
: CODE XCODE ;
: IMMEDIATE XIMM ;
: (entry) (xentry) ;
: : [ ' X: , ] ;

CURRENT @ XCURRENT !

0x3000 BIN( !
282 LOAD  ( boot.z80 )
492 LOAD  ( trs80.z80 )
393 LOAD  ( icore low )
415 LOAD  ( icore high )
(entry) _
( Update LATEST )
PC ORG @ 8 + !
," CURRENT @ HERE ! "
422 459 XPACKR ( core print readln fmt blk )
499 500 XPACKR ( trs80.fs )
( 0x0a == NLPTR. TRS-80 wants CR-only newlines )
," : _ ['] CR 0x0a RAM+ ! BLK$ FD$ (ok) RDLN$ ; _ "
ORG @ 256 /MOD 2 PC! 2 PC!
H@ 256 /MOD 2 PC! 2 PC!