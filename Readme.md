
# Some kind of Launcher I guess
Imagine you have some sort of dedicated game machine with no accessible keyboard and you want to choose between multiple games upon boot
That's exactly why I hacked this together; it is by no means perfect but it works for now.

You can control it either with your mouse cursor, or with buttons - whatever you like more (or both)

---
## Running it
Build it yourself I don't have any released binaries as of now
Start the exe with a config.json file as a commandline parameter and you're gucci

---
## Configuration
Go check out my example config.json but basically:
two lists
- *games* which is for, you guessed it, games, has four variables
  - *executable* - a path to the executable you want to start
  - *icon* - an icon to be drawn
  - *parameters* - possible parameters you want your exe to start with
  - *text* - the title of the card in the launcher
- *misc* contains various settings
  - *backgroundcolor*
  - *boxcolor*
  - *highlightcolor*
  - *selectedcolor*
  Are all colors, supplied in #RRGGBB      
   - *threshhold* - how far your cursor has to move for an item to change

---
## ToDo
- have an idea to get back focus for some applications, like starting a vpn through the launcher

---
I hope that's all, if I forgot anything I might add it in the next commit in a year or so