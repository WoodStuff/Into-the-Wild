Into the Wild is a game made in Unity. Currently it’s on the stage of only having physics and platforms.

You start in a main menu. There are two main tabs of the game: the _inventory_ and the _stages_.

# Inventory

You start with some inventory slots, around 20. You can eventually expand and buy 4 slots at a time with currency.

You also have 10 more slots (the hotbar), which are the only items you can bring into the game (with some exceptions). This totals to 30 at the beginning of the game.

The general currency is coins, which look like green coins. This currency is slightly inflated, at the beginning of the game hundreds of coins have meaningful value.

Besides normal items and weapons, there is also special equipment that don’t count toward the 10 item limit:

- **Armor**, which is split into 3 pieces. They can increase your max HP and give you other buffs. There are also armor set bonuses.
- **Cubes**, which are basically active abilities. You press a hotkey and it does stuff like healing or firing a projectile.

You start with 100 HP and a Wooden Sword, which has 20 damage and is average speed (usable every 0.8s).

## Levelling and tiering

Any item with stats (weapons, tools, armor, cubes) can be levelled up. This is where the second currency comes in, which looks like a blue triangle. This currency is much less inflated (most beginner stages drop only 1 or 2). Levelling stuff up increases the main stat (like damage or max HP) and sometimes side stats (like speed).

Each item has a max level cap though, mostly at 10. These items can be tiered up once they reach their max level. There are 5 tiers of items: Common → Uncommon → Rare → Epic → Supreme.

Most items you get start at Common and you can spend a bigger amount of blue triangles to tier up the item, increasing its level cap by 5 and increasing its stats. They also get an updated design. These tier ups are so they stay relevant through the game.

Tiering up is locked behind Tier Tokens, placeholder name. There are 4 of these Tier Tokens throughout the chapters, each of which unlocks the ability to tier up to the next level.

## Crafting

To craft stuff, you need Crafting Stations. These have no limit and each one gives you more crafting recipes. They can be unlocked by various methods, such as stage rewards or crafting them.

You don’t start with a Crafting Station, so you can’t craft anything at the beginning of the game. Clearing a certain Into the Forest stage awards you with a Workbench, the first Crafting Station that allows you to craft basic items and upgrade your equipment.

# Stages

The Stages tab has a list of stage chapters. Chapters are giant collections of stages that have around 30 of them each. Only the first one (Into the Forest) is unlocked from the start. Only the first stage in a chapter is unlocked at first, and completing a stage unlocks the next one. Unlocking chapters happens similarly.

Additionally, at the top of the Stages tab, there is an Extra Stages “chapter” that takes you to a place with even more stage groups. These stage groups are smaller and don’t belong in the main chapters.

A single stage is an area of a defined size (size varies between stages).

Inside stages are:

- **Spawn point:** The place you spawn in when entering the stage.
- **Terrain:** The terrain of the stage.
- **Finish point:** A block which marks the stage as complete when you go on it. Can have requirements (more on them later), which almost all stages have. In the case this isn’t present on the stage, the spawn point acts as the finish point.
- **Enemies:** Things that you can kill. There might even be spawners that spawn infinite.
- **Purplits:** Collectibles. All must be collected to finish the stage.

Stages can drop things. The usual rewards are coins and blue triangles. They can also drop items or equipment.

## Stage difficulties

Every stage has a difficulty. They are:

- #676ab8 **Basic**
- #63c7cc **Easy**
- #5fd058 **Medium**
- #ced058 **Challenging**
- #d09058 **Hard**
- #d05858 **Extreme**
- #aa67b8 **Insane**
- #d4d4d4 **Far Game**
- #353535 **End-game**

## Requirements, limits and restrictions

All three of these are stage properties that control how the stage is played. **Requirements** require the player to do certain things before completing the stage. **Limits** are in-stage restrictions, they add certain “hazards” that make the stage uncompletable if something happens. **Restrictions** are limitations that force the player to change something before starting the stage.

Requirement examples:

- **Kill** at least _x_ of a **mob**
- Defeat the **boss** (boss battle)

Limit examples:

- **Finish** the stage in **under** _x_ **minutes** (time limit)
- **Finish** the stage without **jumping** more than _x_ **times** (jump limit)
- **Finish** the stage without taking damage from a **given mob**
- **Finish** the stage without killing any type of **given mob**

Restriction examples:

- Certain **equipment** is **disabled**
- Certain **equipment** must be below **level** _x_ (level restriction)
- **Max HP** amount cannot be **over** _x_

## Challenges

Stages can also have challenges, which are harder, altered versions of the stage. Every main chapter stage has 2 challenges.

The first and easier challenge is called a **Normal Challenge**. This challenge is immediately unlocked upon clearing the stage.

The second and harder challenge is called an **Insane Challenge**. These challenges are only unlocked once the whole chapter is beaten, upon which all Insane Challenges of the chapter are unlocked. They are usually much harder than Normal Challenges.

Examples of challenges:

- Slightly **altered stage** terrain and **content**
- Altered **mob spawners** (buffed enemies, spawn rate change, different enemies)
- **Additional** requirement, limit or restriction applied
- Cannot **touch** a specific **block**
- Permanent **effect** applied

# Game mechanics

## Stamina

The stamina point system. All weapons require stamina to attack and using them depletes some stamina. Max stamina is 100.

Stamina can passively regenerate. Here are the base regeneration values:

- **When standing still:** 5 per second
- **When moving:** 2 per second

Moving refers to having some velocity.

# Credits
ChatGPT

![image](https://media.discordapp.net/attachments/1146481600394166293/1172936019876790352/image.png?ex=656220cb&is=654fabcb&hm=4b690583a55bc958b4c162b4a6bfc7649779b686de4b4a251770064435b0b38f&=&width=925&height=244)
