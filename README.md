# AmoLang
## A better Amongusisabigsussybaka.

AmoLang makes AMONGUSISABIGSUSSYBAKAHAHAHAHAHATHISLANGUAGEISREALLYCOOLPLEASEUSEITMYLIFEDEPENDSONITORELSEPLSPLSPLSPLSPLSPLSPLSkahyghdfhmILLDIEIFYOUDONTUSEITSOPLEASEUSEITALSODONATETOMYGOFUNDMEBECAUSEIMGONNADIEBECAUSEYOUWONTUSETHISLANGUAGEURTHEIMPOSTORANDTHATISSUSIMGOINGTOCALLAMEETINGONYOUYOUVENTEDYOUSUSSYBAKA better and more realistic to use in real situations by adding more commands for logic gestion, maths, and IO whilst keeping the simplicity and humour of the original language. All AMONGUSISABIGSUSSYBAKAHAHAHAHAHATHISLANGUAGEISREALLYCOOLPLEASEUSEITMYLIFEDEPENDSONITORELSEPLSPLSPLSPLSPLSPLSPLSkahyghdfhmILLDIEIFYOUDONTUSEITSOPLEASEUSEITALSODONATETOMYGOFUNDMEBECAUSEIMGONNADIEBECAUSEYOUWONTUSETHISLANGUAGEURTHEIMPOSTORANDTHATISSUSIMGOINGTOCALLAMEETINGONYOUYOUVENTEDYOUSUSSYBAKA programs can be run by AmoLang so you won't have any problems porting them over.

## Commands added:
- ``I SAW <player/num> WITH <player/num> IN MEDBAY`` : if both are equal, execute next line, otherwise skip it.
- ``HOLY MOLY GUYS REWIND TO <player/num>`` : goes to a specific line.
- ``<player> HOW MANY TASKS DID YOU DO`` : stores user input(integer) in a variable.
- ``GUYS GUYS GUYS <string>`` : outputs a string to console.
- ``<player> HOW MANY BODIES`` : outputs the value of a variable to the console.
- ``WAIT A SEC <string>`` : comments a line.
- ``YOU WERE EJECTED`` : halts the program(exit code 0).
- ``<player/num> WAS EJECTED`` : halts the program(user-defined exit code).
- ``<player> WHERE WAS THE BODY`` : stores current line in a variable as a label for proto-functions.

## Original Amongusisabigsussybaka commands:
- ``GUYS I CAN VOUCH <player> IS <num>`` : stores integer in a variable.
- ``<player> CAN VOUCH GO AND TELL THEM COME ON`` : outputs the value of a variable as an ASCII character.
- ``<player> IS JUST LIKE <player>`` : stores value of a variable(second player) in another variable(first player).
- ``IF ITS NOT <player> THEN VOTE ME`` : if variable is not equal to zero, execute the next line. Otherwise, ignore it.
- ``IDK WHAT <player> IS BUT ITS BETWEEN <num> AND <num>`` : stores a random value between the first integer(minimum) and the second integer(maximum) in a variable.
- ``<player> WAS THE IMPOSTOR`` : halts the program if the variable is not equal to zero.
- ``<player> GOES UP`` : increments the variable.
- ``<player> GOES DOWN`` : decrements the variable.
- ``<player> WHO ARE YOU`` : recieve a single ASCII character as input and store it in a variable.

## Samples:

### 100 Hello worlds

This would have taken 1410 lines of Amongusisabigsussybaka. It now takes 9 lines including a comment.

```
WAIT A SEC Print Hello World 100 times
GUYS I CAN VOUCH loopAmount IS 100
printFunc WHERE WAS THE BODY
GUYS GUYS GUYS Hello, World!
loopAmount HOW MANY BODIES
loopAmount GOES DOWN
IF ITS NOT loopAmount THEN VOTE ME
HOLY MOLY GUYS REWIND TO printFunc
YOU WERE EJECTED
```

### Letter guess game

This example showcases AmoLang's proto-functions labels.

```
WAIT A SEC Generates a random lowercase letter and makes you guess it

IDK WHAT randnum IS BUT ITS BETWEEN 97 AND 122

GUYS I CAN VOUCH endFunc IS 13
guessFunc WHERE WAS THE BODY
guess WHO ARE YOU

I SAW guess WITH randnum IN MEDBAY
HOLY MOLY GUYS REWIND TO endFunc WAIT A SEC this goes to line 13
HOLY MOLY GUYS REWIND TO guessFunc WAIT A SEC this goes to line 6. look, in code comments :)

GUYS GUYS GUYS Yay! The letter was:
randnum CAN VOUCH GO AND TELL THEM COME ON
YOU WERE EJECTED
```

### Number guess game

This example showcases AmoLang's integer input.

```
WAIT A SEC Generates a random number and makes you guess it.

IDK WHAT randnum IS BUT ITS BETWEEN 0 AND 100

GUYS I CAN VOUCH endFunc IS 13
guessFunc WHERE WAS THE BODY
guess HOW MANY TASKS DID YOU DO

I SAW guess WITH randnum IN MEDBAY
HOLY MOLY GUYS REWIND TO endFunc WAIT A SEC this goes to line 13
HOLY MOLY GUYS REWIND TO guessFunc WAIT A SEC this goes to line 6. look, in code comments :)

GUYS GUYS GUYS Yay! The number was:
randnum HOW MANY BODIES
YOU WERE EJECTED
```

Original Readme Follows.

# AMONGUSISABIGSUSSYBAKAHAHAHAHAHATHISLANGUAGEISREALLYCOOLPLEASE
This project is distributed under the [Do What The Fuck You Want To Public License](https://en.wikipedia.org/wiki/WTFPL)

EsoLang themed around an among us chat with 3 year olds. The full name of the language is "AMONGUSISABIGSUSSYBAKAHAHAHAHAHATHISLANGUAGEISREALLYCOOLPLEASEUSEITMYLIFEDEPENDSONITORELSEPLSPLSPLSPLSPLSPLSPLSkahyghdfhmILLDIEIFYOUDONTUSEITSOPLEASEUSEITALSODONATETOMYGOFUNDMEBECAUSEIMGONNADIEBECAUSEYOUWONTUSETHISLANGUAGEURTHEIMPOSTORANDTHATISSUSIMGOINGTOCALLAMEETINGONYOUYOUVENTEDYOUSUSSYBAKA"
