
# Gilded-Rose Kata
<h3>Problem description</h3>
<p>As you know, we are a small inn with a prime location in a prominent city ran
by a friendly innkeeper named Allison.  We also buy and sell only the finest
goods. Unfortunately, our goods are constantly degrading in quality as they
approach their sell by date.</p>
<p>We have a system in place that updates our inventory for us. It was developed
by a no-nonsense type named Leeroy, who has moved on to new adventures. Your
task is to add the new feature to our system so that we can begin selling a
new category of items.</p>
<p>First an introduction to our system:</p>
<ul>
<li>
<p>All items have a sell-in value which denotes the number of days we have to
sell the item</p>
</li>
<li>
<p>All items have a quality value which denotes how valuable the item is</p>
</li>
<li>
<p>At the end of each day our system lowers both values for every item</p>
</li>
</ul>
<p>Pretty simple, right? Well this is where it gets interesting:</p>
<ul>
<li>
<p>Once the sell by date has passed, quality degrades twice as fast</p>
</li>
<li>
<p>The quality of an item is never negative</p>
</li>
<li>
<p>"Aged Brie" actually increases in quality the older it gets</p>
</li>
<li>
<p>The quality of an item is never more than 50</p>
</li>
<li>
<p>"Sulfuras", being a legendary item, never has to be sold or decreases in
quality</p>
</li>
<li>
<p>"Backstage passes", like aged brie, increases in quality as it's sell-in
value approaches; quality increases by 2 when there are 10 days or less
and by 3 when there are 5 days or less but quality drops to 0 after the
concert</p>
</li>
</ul>
<p>We have recently signed a supplier of conjured items. This requires an update
to our system:</p>
<ul>
<li>"Conjured" items degrade in quality twice as fast as normal items</li>
</ul>
<p>Feel free to make any changes to the update-quality method and add any new code
as long as everything still works correctly. However, do not alter the item
function as that belongs to the goblin in the corner who will insta-rage and
one-shot you as he doesn't believe in shared code ownership.</p>
<p>Just for clarification, an item can never have its quality increase above 50,
however "Sulfuras" is a legendary item and as such its quality is 80 and it
never alters.</p>
</article>




To build the project clone repo using git : 

git clone https://github.com/zieemer/Gilded-Rose.git

Open solution in Visual Studio, build and run

All tests are insides Gilded.Rose.Tests project.
It requires Nunit and NUnit 3 Test Adapter packages. They should download automatically when project will start to build via nuget
