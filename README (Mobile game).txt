ICS168 - Mobile Game


		      /
       -------------- ==
     ====             \
   ========
  Bomb Squad
   ========
     ====



Created by:
--------------
Marcelo Pulido (32568767)
Brandon Cheong (45163796)



Bomb Squad is a fast-paced mobile game where you compete with friends to see who gets blown up first.
This game is all about swiping through different panels with buttons on them and pressing the ones that correspond to other players.

Each player associates with a bomb of a certain color- that color is shown by one of the buttons on each panel.
While one or more buttons of the player's color is pressed down, their bomb timer will decrease- the more buttons pressed down, the faster it goes.
Note that only one button can be pressed down for each panel, so pressing a button down on a panel will reset the panel's previous button.
The goal is to avoid having your bomb timer reach 0, and to force other players' bombs to explode first.

In terms of connectivity with other devices, the game can connect between multiple Android devices, and even between PC and Android.

Thanks to time constraints (it being finals week), we weren't able to implement more than 1 panel, which defeats the purpose, but the concept is still there.
There were a few other features we weren't able to implement, but that means we got to experience what many AAA developers deal with.

Again due to time constraints, only two players are able to play with each other, and sadly only the server (host) is able to modify the state of the buttons.
However, we were able to get the Unity Match Maker to work, for an easiler way to connect mobile devices! Traditionally, to connect two devices, one could simply
create a LAN server with the Network UI, and the other player could connect to it under the same Wi-Fi/LAN as long as they know the host's IP address.
For the Match Maker, one player under the same Wi-Fi/LAN can create a lobby with a name, and the second player can connect by using the Match Maker's
"Find Match" option. The second player should see the host's game and be able to connect to it!

To play the game on the PC, simply open the file in Unity, and play directly from the editor by hitting the Play button on the top (all controls work for PC).
To play the game on your Android device, simply go to open the file in Unity, then go to File -> Build & Run while your Android device is connected via a USB
cable (note: your Android device must have Developer Mode on, as well as USB debugging on), and wait for the game to download on your smartphone.
The APK file can also be located at Builds -> Android.apk, if you'd like to directly import it to your device instead if you know how.


Controls
--------
Swipe (left and right) -> Change panel
Touch -> Press a button





Work distribution
-----------------
Marcelo -> All programming
Brandon -> Game concept/design, all art, all music/SFX



~