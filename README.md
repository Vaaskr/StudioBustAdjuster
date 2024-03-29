# StudioBustAdjuster
Allows to change most settings of a characters bust within CharaStudio.

Currently Works with Koikatsu

## Features
- Sliders that adjust both the main settings and the extra settings of a characters bust
- Adds Timeline Compatiblity for Bust values and the Bust Scale Values which can be changed via Timeline

## How to install
1. Install latest BepInEx5, BepisPlugins and KKAPI.
2. Download the latest release of the plugin you want.
3. Extract the archive into your game directory. The plugin .dll should end up inside your BepInEx\plugins directory.

The Main sliders can be found within the Current State tab of a character and is labeled Studio Bust Adjuster.

The Bust Scale can be editited through KKABMX(BonemodX) by editing the scale of bones that start with "cf_d_bust##__#" while the extra bust scale can be edited with bones that start with "cf_s_bust##__#".
The Bust Collison scale can also be edited through "cf_hit_bust02_#".  
