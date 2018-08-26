# tModLoader & TShock Integration POC

This project demonstrates how you can get tModLoader (windows server) working along side TShock.

![Alt text](/Screenshots/ts_and_tml.png?raw=true "TML & TShock ")
![Alt text](/Screenshots/ts_cmd_tml_pc.png?raw=true "Optional Title")

I personally will not be continuing work on this as I have other priority work I need to focus on. 
Feel free to fork and maintain yourself!

I have had the code sitting for at least a year now and I have just updated it to the latest TML/TShock, but fair chance I have missed a few files in order to get the player into the world.
If you are serious in continuing this work I have my initial POC project that can get a TML player into the server and sync mods, you will just need to contact me so I know that there is interest.

## How the hell does this abomination work?
Well, basically it uses OTAPI to patch TML instead of the vanilla server. Then a few extra compatibility adjustments are made for TML to be happy.

### What about XNA?
Yes TML uses the real XNA libraries and TShock doesn't.
Instead of OTAPI shipping XNA shims, I have put in type redirectors in OTAPI, so that if a plugin was referencing the old OTAPI it can potentially work by being redirected to the "real" XNA again.

### What about ITile from OTAPI/TShock/TSAPI?
Yes it works, OTAPI's patcher is smart enough (or dynamic enough) to patch TML's Tile implementations into an interface. TShock only required a couple data type changes in HeapTile.cs

### What about plugins?
They are all screwed...at least partially. 
Basic plugins can potentially just work from TShock, as ITile will be there, and XNA references should be redirected
TML plugins might work if they use Tile arrays (due to the array being replaced), XNA wont be an issue for these

It's certainly possible for this project to use OTAPI's framework to patch dll's as they are loaded, in order to add ITile implementations and XNA redirections (if needed), which then may supported all plugins from both platforms.