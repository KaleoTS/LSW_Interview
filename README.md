# LSW_Interview
Mechanic developed for a LSW_Interview

Package used for the art:
https://github.com/silveira/openpixels

Here is a little diary for the creation of this test;

I started tackling this project by laying the base foundations of the map.
Next, was the base implementation of the player and its movement. I decided to use ready made sprites because my focus is on
the programming part. Fortunately I've found a free package at OpenArtAssets that had almost everything I needed for the player animations. I only added a idle animation
to the pack.
After implementing the player, I worked on the colisions with the object on the map.
I then started working on putting clothes on the player. Here I've hit the first drawback, because I was unable to find a quick way to make the clothes animate properly
with the sprites I was using. After a couple tries, I decided to leave this part to the end, if I got time.

Then I started on the systems, first tackling the Inventory.
The system for the inventory was ok to create, but I got some problems when updating the art. After a few headscratchers, I've found the problem to be a misplaced item
in the inspector. After that, things became easier.
With the inventory ready, I created the pickup methods to allow the player to collect the items aroudn the store.
next was the NPC, I copied the way I did the inventory for easiness, and adjusted where needed.
Implementing the sell/buy of items was next and proved not to be a challenge because of the way I had set up methods to add and remove itens from the lists.
The last part was to implement the money and the positional limitation of the selling(player needs to be close to the NPC to be able to sell/buy). 

By the end I realized i would not have time to enable the player to dress up with the clothes in a satisfactory way, so I humbly ask for forgiviness. It is something
I will learn how to do properly by myself in the future.

Lastly I polished the code a bit and tested the builds.
