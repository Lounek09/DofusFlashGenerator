# DofusFlashGenerator
A WinForm application written in C# and using Flash to generate the maps and the spell icons from Dofus Retro.

## Prerequisites

Before you begin, ensure you have met the following requirements:
- **Operating System :** Windows
- **[.NET](https://dotnet.microsoft.com/en-us/download/dotnet)** installed
- **[Clean Flash Installer](https://gitlab.com/cleanflash/installer)** installed and registered

### How to install and register Flash since the EOL
Download from [Clean Flash Installer](https://gitlab.com/cleanflash/installer)

![setup_flash_1](/README_ressources/step1.png)
![setup_flash_2](/README_ressources/step2.png)
![setup_flash_3](/README_ressources/step3.png)

## Installation

1. Clone the repository `git clone git@github.com:Lounek09/DofusFlashGenerator.git`
3. Navigate to the project folder
4. Build the project `dotnet build`
5. Go to the output folder (by default `%PATH%/DofusFlashGenerator/bin/x86/Release/net7.0-windows/`)
6. Create JSON files containing the map and spell data
    - Map JSON Example :
        ```json
        [
          {
            "mapId": 4,
            "date": "0706131721",
            "key": "45783f2275432c5767664069605b3f6c78614e4a4861464d28503c736165793763242532355d6f264b3f7c33796552505b505140797b73307448632a34237364702532424a6b50545e7b20415f36203c40506e634560274b253242237b4332306c7a6645393c7955705d2c3474465b493369403838752532422772355f765a4d4a342a5624234e45786e67725c6878683e5f263a4a2c2c287d70267a77296a2665372056552e7a35737442556b4d573c2f52232f554054446d227960733246",
            "crackedKey":""
          }
        ]
        ```
        *Note: This JSON is generated from a private API. If you have your own API, replace the URL in this [line](DofusFlashGenerator/Models/MapKey.cs#L7) before building the project.*
    - Spell JSON Example :
        ```json
        {
          "S": [
            {
              "id": 0,
              "n": "Coup de poing",
              "i": {
                "up": 0,
                "pc": [
                  16737792,
                  16737792,
                  16737792,
                  16737792
                ]
              }
            }
          ]
        }
        ```
        *Note: This JSON is generated from the lang of Dofus Retro. It may appear unconventional due to its source.*

## License
Copyright (C) 2023 Lounek


This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program. If not, see <https://www.gnu.org/licenses/>.

The full text of the license can be found in the [LICENSE](LICENSE) file.
