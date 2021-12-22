# Complyle
A stupid cli for downloading the [Compliant texture pack](https://compliantpack.net) for either Java or Bedrock with support for the different published branches (1.12.2 - 1.18+)

## how does it work?
I plan on making complyle benifit both users and the compliant community by both boosting curseforge downloads whilst fetching zips from github. This is both easy to use and promotes downloads on curseforge.

### a brief summary
NOTE: this is how complyle is intended to work and this plan isn't fully implemented as of 22/12/21

Complyle first starts by downloading the latest curseforge zip (not containin alpha versions unlike github) so that curseforge downloads are increased and wont stunt growth of popularity.
Next, complyle will delete the curseforge zip since its not what the user targeted for download.
Now Complyle will download the requested file from github (includeing alpha versions) and finally move it to your resource pack folder by utilising your registry keys (meaning complyle will work even if you appdata is located elsewhere)
## Installation
head to releases and grab the latest .exe if your on windows else cry because i dont know how to compile for linux and mac.

## Usage
```
C://complyl>complyle <64x|32x> <-b|-j> -v [version]
```
1 specify the resolution of the pack with: x64, 64, 64x, x32, 32 or 32x. 
2 use the -b or -j flag to specify bedrock or java versions
3 use -v if your on java to specify a minecraft version.
4 Enjoy.
