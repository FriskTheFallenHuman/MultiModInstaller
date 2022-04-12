using System.Collections.Generic;

/*
 * Class that has localization stuff...
 *
 * I'm going to be honest here...
 * This would need a total change because it would be so hard to add so many lang support
 * I'm sorry Neko
 * 
 */
namespace MultiModInstaller
{
    public class localizationClass
    {
        public static string ci = System.Globalization.CultureInfo.CurrentUICulture.Name;
        public static Dictionary<string, string> localizationDictionary = new Dictionary<string, string>
        {
#region     // English, default, also duplicated for en-GB. {en}
            ["{en-US}"] = @"{en}",
            ["{en-GB}"] = @"{en}",

            ["mainForm.Text{en}"] =
@"MultiModInstaller C# Example Installer",
            ["titleLabel.Text{en}"] =
@"CHANGEME MOD TITLE
by CHANGEME",
            ["quitButton.Text{en}"] =
@"Quit",
            ["prevButton.Text{en}"] =
@"< Back",
            ["nextButton.Text{en}"] =
@"Next >",
            ["thankyouLabel.Text{en}"] = // "$REPLACETEXT$" will be replaced with instructions depending if your game is a Steam copy or not.
@"Success! Now, launch your game.

$REPLACETEXT$

Mod by: CHANGEME
Original SpaghettiInstaller by: Nik the Cat
Arrivederci! (that's ""Goodbye!"" in Italian)",
            ["instructionLabel.Text{en}"] =
@"Buongiorno! (that's ""Hello!"" in Italian)

This installer will help you patch your existing
UNDERTALE/DELTARUNE copy to include CHANGEME mod.

What you'll need:
1) A legitimate copy of UNDERTALE v1.08.
1.1) Anything lower than v1.08 (or 2.0.0.2 on GOG) won't work!
2) A little bit of patience.
3) dog.",
            ["instructionLabel.Text2{en}"] =
@"Buongiorno! (that's ""Hello!"" in Italian)

This installer will help you patch your existing
UNDERTALE/DELTARUNE copy to include CHANGEME mod.

What you'll need:
1) A legitimate copy of UNDERTALE v1.08.
1.1) Anything lower than v1.08 (or 2.0.0.2 on GOG) won't work!
2) A little bit of patience.
3) dog. (not actually required?)", // bau.
            ["errorTitle{en}"] =
@"Yikes.",
            ["questionTitle{en}"] =
@"Question.",
            ["folderBrowserDialog{en}"] =
@"Please select your UNDERTALE/DELTARUNE folder:",
            ["steamQuestion{en}"] =
@"Installer autodetected a Steam copy of UNDERTALE/DELTARUNE, use that?",
            ["gogQuestion{en}"] =
@"Installer autodetected a GOG version of UNDERTALE/DELTARUNE, do you want to use it or choose a custom path?",
            ["backupErrorQuestion{en}"] =
@"Backing up failed.
Sure, you can proceed, but that's pretty risky.
Do you want to continue anyway?",
            ["steamCannotFindFolder{en}"] =
@"Ummm...",
            ["quitQuestionTitle{en}"] =
@"Such a shame :(",
            ["quitQuestion{en}"] =
@"Are you sure you want to quit?",
            ["runasAdmin{en}"] =
@"Can't write to your game directory.
Please run this patcher as Administrator.",
            ["xdeltaError{en}"] =
@"Can't write xdelta3.exe to temp directory.
Cannot proceed.
Remember what I said about antiviruses?",
            ["dataNotFoundError{en}"] =
@"The folder you selected doesn't contain a data file.
Please choose another directory.",
            ["gogPatch{en}"] =
@"Installer detected that you have a GOG version of UNDERTALE/DELTARUNE.
It will be autopatched to a Steam version and then to CHANGEME.
Press OK to continue.",
            ["veryBadError{en}"] =
@"Got an exception.
Perhaps the file could not be read or it's something else.
Try moving your game to another directory.


Exception: ",
            ["cannotFindModPatch{en}"] =
@"Cannot find patch file.
Please unpack everything from mod archive into a directory.
Don't just run it from your archiver.",
            ["patchingFailed{en}"] =
@"Patching failed.
Remember what I said about antiviruses?",
            ["cannotFindGOGSteam{en}"] =
@"Cannot find GOG->Steam patch, make sure you unpacked everything correctly!",
            ["cannotCopyOptionalFiles{en}"] =
@"Could not copy Optional Files.
Either the folder doesn't exist or something else happened.
This error can be ignored.",
            ["optionalFilesQuestion{en}"] =
@"Do you want to install optional files?",
            ["wrongGameVersion{en}"] =
@"Your data file doesn't seem to match what I was expecting...
Possible reasons:
1) Your game version is wrong, your game version must be 1.08(UT)/1.12(DR) (last UNDERTALE/DELTARUNE version), if you want to know how to see your UNDERTALE/DELTARUNE version see the example.png image.
2) Debug Mode is enabled, reinstall the game from your store (Steam, GOG, Microsoft Store).
3) Other mods are installed (dialogues changes, sprites edits), you need a ""clean"" UNDERTALE/DELTARUNE, reinstall the game from your store (Steam, GOG, Microsoft Store).
4) The CHANGEME is already installed.",
            ["revertModSteam{en}"] =
@"If you want to revert the mod,
press 'Verify Integrity of Game Files'
in UNDERTALE's Properties and remove data.win.bau from UT folder.",
            ["revertModGOG{en}"] =
@"If you want to revert the mod,
Go to your UT folder, delete data.win,
and rename data.win.bau to data.win",
            ["cannotDetectSteamPath{en}"] =
@"Installer found that you have a Steam copy of UNDERTALE/DELTARUNE but couldn't find it's path...
Perhaps you chose another installation path?\nChoose your UNDERTALE/DELTARUNE folder after clicking OK.

(let's hope you're not a pirate...)
(it's not an error message and can happen with everyone)",
            ["bauPiracyMsg{en}"] =
@"We are sorry but seems like you don't own a UNDERTALE/DELTARUNE copy.
Has i say at the beginning you need a legic copy
(Bye Bye)",
            ["instructionLabel.Text3{en}"] =
@"Okay, in the next step you will be asked to choose
your UNDERTALE/DELTARUNE directory.

Make sure nothing is blocking this little installer
from overwriting game files.

(perhaps your antivirus?)

Click 'Next' to continue",
            #endregion
        }; // End of localizationDictionary.
    }
}
