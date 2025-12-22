> ⚠️ **Archived – No Longer Maintained**
>
> This repository is no longer maintained due to a change in the technologies used by our organisation. No further updates, fixes, or security patches will be provided. The project is archived to prevent the expectation of ongoing support. The code remains available as-is for reference or forking.

# Press Kit

Simplify creating press kits for games industry.

## Build Status

[![NuGet](https://img.shields.io/nuget/v/Etch.OrchardCore.PressKit.svg)](https://www.nuget.org/packages/Etch.OrchardCore.PressKit)

## Orchard Core Reference

This module is referencing a stable build of Orchard Core ([`1.8.3`](https://www.nuget.org/packages/OrchardCore.Module.Targets/1.8.3)).

## Installing

This module is available on NuGet. Add a reference to your Orchard Core web project via the NuGet package manager. Search for "Etch.OrchardCore.PressKit", ensuring include prereleases is checked.

Alternatively, [download the source](https://github.com/etchuk/Etch.OrchardCore.PressKit/archive/main.zip) or clone the repository to your local machine. Add the project to your solution that contains an Orchard Core project and add a reference to Etch.OrchardCore.PressKit.

## Usage

Once a reference to this module has been configured there will be a "Press Kit" feature available within the CMS instance. Enabling this feature will create a new "Press Kit" content type that contains all the parts required for creating a press kit page.

## Features

Defines content definitions for creating a "Press Kit". Displays "Press Kit" content item in industry expected format.

By default the press kit will be displayed using the active theme. Optionally the display can be toggled to have the appearance of [presskit()](https://dopresskit.com/).
