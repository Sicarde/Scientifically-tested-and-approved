/*
Generated by UnityTwine on 12/3/2016 3:41:50 PM
https://github.com/daterre/UnityTwine
*/
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityTwine;

public class Story: TwineStory
{
	public TwineVar sociability;
	public TwineVar suspicion;
	public TwineVar fail;
	public TwineVar morals;
	public TwineVar metFriend;
	public override TwineVar this[string name] {
		get {
			switch(name)
			{
				case "sociability": return sociability;
				case "suspicion": return suspicion;
				case "fail": return fail;
				case "morals": return morals;
				case "metFriend": return metFriend;
				default: throw new KeyNotFoundException(string.Format("There is no variable with the name '{0}'.", name));
			}
		}
		set {
			switch(name) {
				case "sociability": sociability = value; break;
				case "suspicion": suspicion = value; break;
				case "fail": fail = value; break;
				case "morals": morals = value; break;
				case "metFriend": metFriend = value; break;
				default: throw new KeyNotFoundException(string.Format("There is no variable with the name '{0}'.", name));
			}
		}
	}


	void Awake() {
		base.Init();
		passageInit_0();
		passageInit_1();
		passageInit_2();
		passageInit_3();
		passageInit_4();
		passageInit_5();
		passageInit_6();
		passageInit_7();
		passageInit_8();
		passageInit_9();
		passageInit_10();
		passageInit_11();
		passageInit_12();
		passageInit_13();
		passageInit_14();
		passageInit_15();
		passageInit_16();
		passageInit_17();
		passageInit_18();
		passageInit_19();
		passageInit_20();
		passageInit_21();
		passageInit_22();
		passageInit_23();
		passageInit_24();
		passageInit_25();
	}
    
	// .............
	// #0: StoryTitle

	void passageInit_0()
	{
		this.Passages["StoryTitle"] = new TwinePassage("StoryTitle", new string[]{  }, passageExecute_0);
	}

	IEnumerable<TwineOutput> passageExecute_0()
	{
		yield return new TwineText(@"STAC: Playtest");	
	}
    
	// .............
	// #1: Beginning

	void passageInit_1()
	{
		this.Passages["Beginning"] = new TwinePassage("Beginning", new string[]{  }, passageExecute_1);
	}

	IEnumerable<TwineOutput> passageExecute_1()
	{
		yield return new TwineText(@"*Crash*");
		yield return new TwineText(@"");
		yield return new TwineText(@"""Whoops.""");
		yield return new TwineText(@"");
		yield return new TwineText(@"Maybe that last beer had been too much. But it had felt good at the time, so I didn't really care.");
		yield return new TwineText(@"");
		yield return new TwineText(@"And then I was at the lab at midnight, slouched in my chair like I had been hastily thrown there. I was still very drunk, but my mind was racing, which was welcomed. It hadn't happened in a while.");
		yield return new TwineText(@"");
		yield return new TwineText(@"After all, I had lost a very precious friend. Oyo, my parrot, had died a few days before. He was a beautiful scarlet macaw, and one of my closest friends. Yes, that sounds pretty lame of me, but I never cared that much. Well, except after losing him.");
		yield return new TwineText(@"");
		yield return new TwineText(@"A small idea kept poking me in the head. It was a pretty old project, on which I hadn't worked in a very long time.");
		yield return new TwineText(@"");
		yield return new TwineText(@"""Maybe... Yes, maybe that could work.""");
		yield return new TwineText(@"");
		yield return new TwineText(@"I grabbed a few notes from my drawer and got to work. Everything quickly came back to me, and the solution I needed only took me an hour to prepare. All I needed then was to add a specific new component...");
		yield return new TwineText(@"");
		yield return new TwineText(@"Stirring the solution made had a completely different effect than what was in my notes, and I feverishly wrote down everything. It was bright blue instead of red.");
		yield return new TwineText(@"");
		yield return new TwineText(@"Now the goal was to test it on something. And I had an idea, even though a part of my mind was telling me it felt wrong. I quickly ran home and grabbed Oyo's body that I kept in a box, and went back to the lab before getting the idea to abandon. I still had no idea how the lab's guards let me in at almost two in the morning.");
		yield return new TwineText(@"");
		yield return new TwineText(@"I carefully injected the solution directly into his heart. Now I felt really bad, and was on the verge of tears. I had no idea what I was expecting out of this.");
		yield return new TwineText(@"");
		yield return new TwineLink(@"What to do next?", @"What to do next?", @"What to do next?", null, null);
		yield return new TwineText(@"");
		sociability = 0;
		suspicion = 0;
		fail = 0;
		morals = 0;
		metFriend = 0;	
	}
    
	// .............
	// #2: 10V

	void passageInit_2()
	{
		this.Passages["10V"] = new TwinePassage("10V", new string[]{  }, passageExecute_2);
	}

	IEnumerable<TwineOutput> passageExecute_2()
	{
		yield return new TwineText(@"Surprisingly, it didn't take long to start working. My heart was beating fast.");
		yield return new TwineText(@"");
		yield return new TwineText(@"""Oh my god. Oh my god I can't believe it.""");
		yield return new TwineText(@"");
		yield return new TwineText(@"Oyo's heart was beating. It took him some time, but then he woke up, shaking his feathers and looking around.");
		yield return new TwineText(@"");
		yield return new TwineText(@"""It worked. It freaking worked!""");
		yield return new TwineText(@"");
		yield return new TwineText(@"I started laughing uncontrollably. I just made the breakthrough of the century. I found a way to resurrect things!");
		yield return new TwineText(@"");
		yield return new TwineText(@"Oyo's cries got me out of my victory dance.");
		yield return new TwineText(@"");
		yield return new TwineText(@"""Yes, yes, don't worry, I'm here.""");
		yield return new TwineText(@"");
		yield return new TwineText(@"I grabbed some water and food that were left in my desk from the times when I would sneak him in (perks of having understanding coworkers). He still looked disoriented, but accepted them happily.");
		yield return new TwineText(@"");
		yield return new TwineText(@"I then took some time to think about the whole thing. I resurrected someone. No, not someone, something. It was an animal. If I wanted to make more progress on this, I had to test on other things. People, maybe. I didn't want to think about that yet.");
		yield return new TwineText(@"");
		yield return new TwineText(@"*Rring rring!*");
		yield return new TwineText(@"");
		yield return new TwineText(@"An incoming call from my best friend, Akira Masahiro, which almost gave me a heat attack. Sometimes, her knowing how late I tend to work make her take some liberties.");
		yield return new TwineText(@"");
		yield return new TwineText(@"Should I answer and tell her everything?");
		yield return new TwineText(@"");
		yield return new TwineLink(@"No, think about it on your own.", @"No, think about it on your own.", @"No, think about it on your own.", null, null);
		yield return new TwineText(@"");
		yield return new TwineLink(@"Yes, ask her for help.", @"Yes, ask her for help.", @"Yes, ask her for help.", null, null);	
	}
    
	// .............
	// #3: No, think about it on your own.

	void passageInit_3()
	{
		this.Passages["No, think about it on your own."] = new TwinePassage("No, think about it on your own.", new string[]{  }, passageExecute_3);
	}

	IEnumerable<TwineOutput> passageExecute_3()
	{
		sociability = sociability - 1;
		yield return new TwineText(@"");
		yield return new TwineText(@"Akira: ""Hey Aya!""");
		yield return new TwineText(@"");
		yield return new TwineText(@"Aya: ""Hey.""");
		yield return new TwineText(@"");
		yield return new TwineText(@"Akira: ""How are you doing? It's been a while, so, I thought, why not call?""");
		yield return new TwineText(@"");
		yield return new TwineText(@"Aya: ""I'm... Fine, thanks. What about you?""");
		yield return new TwineText(@"");
		yield return new TwineText(@"Akira: ""That doesn't sound really *fine* to me.""");
		yield return new TwineText(@"");
		yield return new TwineText(@"Aya: ""I had a rough day at work. Nothing to worry about. Thanks for calling.""");
		yield return new TwineText(@"");
		yield return new TwineText(@"Akira: ""Let me guess. There are some things you still need to wrap up so you don't have time to talk right now?""");
		yield return new TwineText(@"");
		yield return new TwineText(@"Aya: ""... Yeah. Sorry about that.""");
		yield return new TwineText(@"");
		yield return new TwineText(@"Akira: ""No, it's fine. Don't worry. I'll see you later then, bye!""");
		yield return new TwineText(@"");
		yield return new TwineText(@"Aya: ""Bye.""");
		yield return new TwineText(@"");
		yield return new TwineText(@"I didn't like shutting her down like that, but it was necessary. I still wasn't ready to share my secret to anyone. I brought Oyo back at home, and tried to sleep for a while, despite the excitement.");
		yield return new TwineText(@"");
		yield return new TwineLink(@"Day two", @"Day two", @"Day two", null, null);	
	}
    
	// .............
	// #4: Yes, ask her for help.

	void passageInit_4()
	{
		this.Passages["Yes, ask her for help."] = new TwinePassage("Yes, ask her for help.", new string[]{  }, passageExecute_4);
	}

	IEnumerable<TwineOutput> passageExecute_4()
	{
		sociability = sociability + 1;
		yield return new TwineText(@"");
		yield return new TwineText(@"Akira: ""Hey Aya!""");
		yield return new TwineText(@"");
		yield return new TwineText(@"Aya: ""Hey.""");
		yield return new TwineText(@"");
		yield return new TwineText(@"Akira: ""How are you doing? It's been a while, so, I thought, why not call?""");
		yield return new TwineText(@"");
		yield return new TwineText(@"Aya: ""I'm... Fine, thanks. What about you?""");
		yield return new TwineText(@"");
		yield return new TwineText(@"Akira: ""That doesn't sound really *fine* to me.""");
		yield return new TwineText(@"");
		yield return new TwineText(@"Aya: ""Well... Something sort of... Happened.""");
		yield return new TwineText(@"");
		yield return new TwineText(@"Akira: ""What? What happened? Aya are you alright?""");
		yield return new TwineText(@"");
		yield return new TwineText(@"Aya: ""Yes, yes, I'm alright don't worry. It's just... You remember that one pet project I had a while ago? And I didn't seem to be able to find a solution so I abandoned it?""");
		yield return new TwineText(@"");
		yield return new TwineText(@"Akira: ""Uhh, yeah. Wait, don't tell me...""");
		yield return new TwineText(@"");
		yield return new TwineText(@"Aya: ""Yes, I did it.""");
		yield return new TwineText(@"");
		yield return new TwineText(@"Akira: ""Holy shit Aya, this is huge! Who did you... Wake up?""");
		yield return new TwineText(@"");
		yield return new TwineText(@"Aya: ""No one yet! It was just... Well, it's Oyo.""");
		yield return new TwineText(@"");
		yield return new TwineText(@"Akira: ""Oh my god.""");
		yield return new TwineText(@"");
		yield return new TwineText(@"Aya: ""Akira, I... I have no idea what to do!""");
		yield return new TwineText(@"");
		yield return new TwineText(@"Akira: ""Ok, stay calm. For now you should just go to sleep, OK? I'll join you at the lab tomorrow and we'll talk about it.""");
		yield return new TwineText(@"");
		yield return new TwineText(@"Aya: ""Ok, thank you Akira. See you tomorrow, then.""");
		yield return new TwineText(@"");
		yield return new TwineText(@"Akira: ""See you!""");
		yield return new TwineText(@"");
		yield return new TwineText(@"I hung up first. She was right, I had to try and go to sleep. It was hard to fall asleep that night, but at some point, I managed.");
		yield return new TwineText(@"");
		yield return new TwineLink(@"Day two", @"Day two", @"Day two", null, null);	
	}
    
	// .............
	// #5: Day two

	void passageInit_5()
	{
		this.Passages["Day two"] = new TwinePassage("Day two", new string[]{  }, passageExecute_5);
	}

	IEnumerable<TwineOutput> passageExecute_5()
	{
		yield return new TwineText(@"The next day, I didn't look very fresh, thanks to the two small hours of sleep I managed to get. When I arrived at the lab, I set all my current work aside to think of the most urgent one.");
		yield return new TwineText(@"");
		yield return new TwineText(@"I had to continue testing if I wanted to be sure I didn't hallucinate what happened the night before (the alcohol didn't help me make sure of that.)");
		yield return new TwineText(@"");
		if (sociability > 0) { 
		yield return new TwineLink(@"Experiment with Akira.", @"Experiment with Akira.", @"Experiment with Akira.", null, null);} 
		if (sociability <= 0) { 
		} 	
	}
    
	// .............
	// #6: Experiment with Akira.

	void passageInit_6()
	{
		this.Passages["Experiment with Akira."] = new TwinePassage("Experiment with Akira.", new string[]{  }, passageExecute_6);
	}

	IEnumerable<TwineOutput> passageExecute_6()
	{
		sociability = sociability + 1;
		suspicion = suspicion + 1;
		metFriend = 1;
		yield return new TwineText(@"");
		yield return new TwineText(@"As expected, Akira came to help me. Her good mood and energy was contagious, and we went to work right away.");
		yield return new TwineText(@"");
		yield return new TwineText(@"When you work in a huge scientific research facility, borrowing dead animals to another laboratory is a piece of cake. On the few ones we used to do our tests, everything worked properly again, giving us a surge of adrenaline each time, and prompting many high fives.");
		yield return new TwineText(@"");
		yield return new TwineText(@"The problem came when we tried the test on a chimpanzee, the closest animal we could get to a human. The first test didn't work: the solution wasn't strong enough. We Managed to do a second one with a better one, but right after that our employer himself showed up, asking what the hell we were doing. ");
		yield return new TwineText(@"");
		yield return new TwineLink(@"Tell it's for a personal project.", @"Tell it's for a personal project.", @"Tell it's for a personal project.", null, null);
		yield return new TwineText(@"");
		yield return new TwineLink(@"Try to find an excuse.", @"Try to find an excuse.", @"Try to find an excuse.", null, null);
		yield return new TwineText(@"");
		yield return new TwineLink(@"Let Akira handle.", @"Let Akira handle.", @"Let Akira handle.", null, null);	
	}
    
	// .............
	// #7: Experiment on your own.

	void passageInit_7()
	{
		this.Passages["Experiment on your own."] = new TwinePassage("Experiment on your own.", new string[]{  }, passageExecute_7);
	}

	IEnumerable<TwineOutput> passageExecute_7()
	{
		metFriend = -1;
		yield return new TwineText(@"");
		yield return new TwineText(@"I decided to do it on my own. I didn't gather the courage to tell Akira about it the night before, and I still didn't have it at that point.");
		yield return new TwineText(@"");
		yield return new TwineText(@"When you work in a huge scientific research facility, borrowing dead animals to another laboratory is a piece of cake. On the few ones I used to do my tests, everything worked properly again, giving me a surge of adrenaline each time.");
		yield return new TwineText(@"");
		yield return new TwineText(@"The problem came when I tried the test on a chimpanzee, the closest animal I could get to a human. My employer himself showed up, asking what the hell I was doing. I barely avoided more questions thanks to him being in a hurry, and just telling me to stop fooling around and get back to work. Which I did. The rest would have to wait for later. I still manage to take a few notes on the chimpanzee: it almost worked, but the solution needed to be stronger. I would have to think about that later if I wanted to make progress.");
		yield return new TwineText(@"");
		yield return new TwineLink(@"Later.", @"Later.", @"Later.", null, null);	
	}
    
	// .............
	// #8: 1V

	void passageInit_8()
	{
		this.Passages["1V"] = new TwinePassage("1V", new string[]{  }, passageExecute_8);
	}

	IEnumerable<TwineOutput> passageExecute_8()
	{
		fail = fail + 1;
		yield return new TwineText(@"");
		yield return new TwineText(@"""... Nothing. I should probably try a bit more.""");
		yield return new TwineText(@"");
		yield return new TwineLink(@"What to do next?", @"What to do next?", @"What to do next?", null, null);	
	}
    
	// .............
	// #9: 100V

	void passageInit_9()
	{
		this.Passages["100V"] = new TwinePassage("100V", new string[]{  }, passageExecute_9);
	}

	IEnumerable<TwineOutput> passageExecute_9()
	{
		fail = fail + 1;
		yield return new TwineText(@"");
		yield return new TwineText(@"""Did I... Did I really try to do that? Aya, don't you remember any of your physics class?""");
		yield return new TwineText(@"");
		yield return new TwineLink(@"What to do next?", @"What to do next?", @"What to do next?", null, null);	
	}
    
	// .............
	// #10: What to do next?

	void passageInit_10()
	{
		this.Passages["What to do next?"] = new TwinePassage("What to do next?", new string[]{  }, passageExecute_10);
	}

	IEnumerable<TwineOutput> passageExecute_10()
	{
		yield return new TwineText(@"A generator, cables, and those patches you put on people's skin to transmit a current. Everything was set up.");
		yield return new TwineText(@"");
		yield return new TwineText(@"""Please let this work.""");
		yield return new TwineText(@"");
		yield return new TwineText(@"The goal was to make some current pass through his body to make his nervous system work again. The question was: how much was enough to work, but not too much to fry him?");
		yield return new TwineText(@"");
		yield return new TwineLink(@"1V", @"1V", @"1V", null, null);
		yield return new TwineText(@"");
		yield return new TwineLink(@"10V", @"10V", @"10V", null, null);
		yield return new TwineText(@"");
		yield return new TwineLink(@"100V", @"100V", @"100V", null, null);	
	}
    
	// .............
	// #11: Later.

	void passageInit_11()
	{
		this.Passages["Later."] = new TwinePassage("Later.", new string[]{  }, passageExecute_11);
	}

	IEnumerable<TwineOutput> passageExecute_11()
	{
		yield return new TwineText(@"Now I had to find a human body to do my tests. Finding one is way harder than animal ones, because they are kept more securely, tracked, and usually already embalmed before anyone has the chance to put their hands on it.");
		yield return new TwineText(@"");
		yield return new TwineText(@"");
		yield return new TwineLink(@"Ask around", @"Ask around", @"Ask around", null, null);
		yield return new TwineText(@"");
		yield return new TwineLink(@"Sneak in the dead storage", @"Sneak in the dead storage", @"Sneak in the dead storage", null, null);	
	}
    
	// .............
	// #12: Sneak in the dead storage

	void passageInit_12()
	{
		this.Passages["Sneak in the dead storage"] = new TwinePassage("Sneak in the dead storage", new string[]{  }, passageExecute_12);
	}

	IEnumerable<TwineOutput> passageExecute_12()
	{
		morals = morals - 1;
		sociability = sociability - 1;
		yield return new TwineText(@"");
		yield return new TwineText(@"Thankfully, I know of a lab that stores a body, and even more thankfully, no one was around it when I sneaked in, late in the evening.");
		yield return new TwineText(@"");
		yield return new TwineLink(@"Test on human", @"Test on human", @"Test on human", null, null);	
	}
    
	// .............
	// #13: Ask around

	void passageInit_13()
	{
		this.Passages["Ask around"] = new TwinePassage("Ask around", new string[]{  }, passageExecute_13);
	}

	IEnumerable<TwineOutput> passageExecute_13()
	{
		sociability = sociability + 1;
		suspicion = suspicion + 1;
		morals = morals + 1;
		yield return new TwineText(@"");
		if (sociability > 0) { yield return new TwineText(@"I tried asking around the facility if anyone knew of a dead body I could use for research. Thankfully, I was convincing enough not to raise too many questions (weird personal research problems are pretty common here, after all), and someone kindly let me in their lab late at night to do what I needed.");
		yield return new TwineLink(@"Test on human", @"Test on human", @"Test on human", null, null);} 
		if (sociability <= 0) { yield return new TwineText(@"I tried asking around the facility if anyone knew of a dead body I could use for research. Some people pointed a specific person to me, but they refused, saying that I had nothing to do with anatomy anyway. Well, I don't have their permission, but at least I know where to find my body.");
		yield return new TwineLink(@"Sneak in the dead storage", @"Sneak in the dead storage", @"Sneak in the dead storage", null, null);} 	
	}
    
	// .............
	// #14: Test on human

	void passageInit_14()
	{
		this.Passages["Test on human"] = new TwinePassage("Test on human", new string[]{  }, passageExecute_14);
	}

	IEnumerable<TwineOutput> passageExecute_14()
	{
		yield return new TwineText(@"The whole scene felt weird. I had the body of a man laying naked in front of me, and I was about to bring him back to life.");
		yield return new TwineText(@"");
		yield return new TwineText(@"Now the question was: the solution barely worked on the chimpanzee last time. What quantities should I use?");
		yield return new TwineText(@"");
		yield return new TwineLink(@"Same as for chimpanzee", @"Same as for chimpanzee", @"Same as for chimpanzee", null, null);
		yield return new TwineText(@"");
		yield return new TwineLink(@"Less than chimpanzee", @"Less than chimpanzee", @"Less than chimpanzee", null, null);
		yield return new TwineText(@"");
		yield return new TwineLink(@"More than chimpanzee", @"More than chimpanzee", @"More than chimpanzee", null, null);	
	}
    
	// .............
	// #15: Same as for chimpanzee

	void passageInit_15()
	{
		this.Passages["Same as for chimpanzee"] = new TwinePassage("Same as for chimpanzee", new string[]{  }, passageExecute_15);
	}

	IEnumerable<TwineOutput> passageExecute_15()
	{
		fail = fail + 1;
		yield return new TwineText(@"");
		yield return new TwineText(@"The body jerks a bit, but nothing happened. I was so close!");
		yield return new TwineText(@"");
		yield return new TwineLink(@"Test on human", @"Test on human", @"Test on human", null, null);	
	}
    
	// .............
	// #16: Less than chimpanzee

	void passageInit_16()
	{
		this.Passages["Less than chimpanzee"] = new TwinePassage("Less than chimpanzee", new string[]{  }, passageExecute_16);
	}

	IEnumerable<TwineOutput> passageExecute_16()
	{
		fail = fail + 1;
		yield return new TwineText(@"");
		yield return new TwineText(@"Nothing happened. I must not have used enough of the solution, I thought.");
		yield return new TwineText(@"");
		yield return new TwineLink(@"Test on human", @"Test on human", @"Test on human", null, null);	
	}
    
	// .............
	// #17: More than chimpanzee

	void passageInit_17()
	{
		this.Passages["More than chimpanzee"] = new TwinePassage("More than chimpanzee", new string[]{  }, passageExecute_17);
	}

	IEnumerable<TwineOutput> passageExecute_17()
	{
		yield return new TwineText(@"Victory! The man moves a bit, then opens his eyes.");
		yield return new TwineText(@"");
		yield return new TwineText(@"He seeemed disoriented and confused, but very alive. ");
		yield return new TwineText(@"");
		yield return new TwineText(@"Slowly, I started realizing what I just did. I brought someone back to life. A whole human. And now I would have to deal with that, and all his questions.");
		yield return new TwineText(@"");
		if (fail > 3) { 
		yield return new TwineLink(@"(End)Something's wrong", @"(End)Something's wrong", @"(End)Something's wrong", null, null);} 
		yield return new TwineText(@"");
		if (fail <= 3) { 
		yield return new TwineLink(@"Explain the situation", @"Explain the situation", @"Explain the situation", null, null);
		yield return new TwineLink(@"Lie", @"Lie", @"Lie", null, null);
		yield return new TwineLink(@"Knock him out", @"Knock him out", @"Knock him out", null, null);
		} 	
	}
    
	// .............
	// #18: (End)Something's wrong

	void passageInit_18()
	{
		this.Passages["(End)Something's wrong"] = new TwinePassage("(End)Something's wrong", new string[]{  }, passageExecute_18);
	}

	IEnumerable<TwineOutput> passageExecute_18()
	{
		yield return new TwineText(@"However, after a few seconds, the man suddenly started looking terrified, and clutched his chest. I did my best to help him, but I was too late, and soon enough he was dead again.");
		yield return new TwineText(@"");
		yield return new TwineText(@"That night marked me forever. Maybe playing God wasn't for me after all.");	
	}
    
	// .............
	// #19: Tell it's for a personal project.

	void passageInit_19()
	{
		this.Passages["Tell it's for a personal project."] = new TwinePassage("Tell it's for a personal project.", new string[]{  }, passageExecute_19);
	}

	IEnumerable<TwineOutput> passageExecute_19()
	{
		morals = morals + 1;
		yield return new TwineText(@"");
		yield return new TwineText(@"Aya: ""It's for a personal project. Sorry about that sir, we'll clean everything up and get back to work. It won't happen again.""");
		yield return new TwineText(@"");
		yield return new TwineText(@"He seemed pleased by these words, because he just nodded and went out.");
		yield return new TwineText(@"");
		yield return new TwineLink(@"Later.", @"Later.", @"Later.", null, null);	
	}
    
	// .............
	// #20: Try to find an excuse.

	void passageInit_20()
	{
		this.Passages["Try to find an excuse."] = new TwinePassage("Try to find an excuse.", new string[]{  }, passageExecute_20);
	}

	IEnumerable<TwineOutput> passageExecute_20()
	{
		suspicion = suspicion + 1;
		morals = morals - 1;
		yield return new TwineText(@"");
		yield return new TwineText(@"Aya: ""It's, uh... We don't really know. There were... Already here when we showed up this morning. I thinks they're from Dr Snow's lab, or something...""");
		yield return new TwineText(@"");
		yield return new TwineText(@"Employer: ""I don't want any excuses. Clean that up and go back to work.""");
		yield return new TwineText(@"");
		yield return new TwineText(@"And with that, he was gone. We didn't have any other choice but to do what we were asked.");
		yield return new TwineText(@"");
		yield return new TwineLink(@"Later.", @"Later.", @"Later.", null, null);	
	}
    
	// .............
	// #21: Let Akira handle.

	void passageInit_21()
	{
		this.Passages["Let Akira handle."] = new TwinePassage("Let Akira handle.", new string[]{  }, passageExecute_21);
	}

	IEnumerable<TwineOutput> passageExecute_21()
	{
		suspicion = suspicion - 1;
		yield return new TwineText(@"");
		yield return new TwineText(@"I looked expectantly at Akira, who understood. She explained that another scientist asked us to keep these animals for a while because of some security concerns, and went into a long rant about how security must be put first. It seemed to work, as our employer left with an annoyed wave of the hand. Still, we both went back to work, in order to not raise more suspicion.");
		yield return new TwineText(@"");
		yield return new TwineLink(@"Later.", @"Later.", @"Later.", null, null);	
	}
    
	// .............
	// #22: Explain the situation

	void passageInit_22()
	{
		this.Passages["Explain the situation"] = new TwinePassage("Explain the situation", new string[]{  }, passageExecute_22);
	}

	IEnumerable<TwineOutput> passageExecute_22()
	{
		yield return new TwineText(@"This is the end of the first part of the story.");
		yield return new TwineText(@"");
		yield return new TwineText(@"With this choice, Aya decides to be honest and explain the truth to the man she just woke up. Your previous choices will also follow you, as they will modify the outcome of the story as it continues.");
		yield return new TwineText(@"");
		yield return new TwineText(@"If you want updates on the next parts of the story, please give us your email in the GForm.");
		yield return new TwineText(@"");
		yield return new TwineText(@"Thanks for playing :D");	
	}
    
	// .............
	// #23: Lie

	void passageInit_23()
	{
		this.Passages["Lie"] = new TwinePassage("Lie", new string[]{  }, passageExecute_23);
	}

	IEnumerable<TwineOutput> passageExecute_23()
	{
		yield return new TwineText(@"This is the end of the first part of the story.");
		yield return new TwineText(@"");
		yield return new TwineText(@"With this choice, Aya decides to lie to the man, because she thinks he will not believe her otherwise. Your previous choices will also follow you, as they will modify the outcome of the story as it continues.");
		yield return new TwineText(@"");
		yield return new TwineText(@"If you want updates on the next parts of the story, please give us your email in the GForm.");
		yield return new TwineText(@"");
		yield return new TwineText(@"Thanks for playing :D");	
	}
    
	// .............
	// #24: Knock him out

	void passageInit_24()
	{
		this.Passages["Knock him out"] = new TwinePassage("Knock him out", new string[]{  }, passageExecute_24);
	}

	IEnumerable<TwineOutput> passageExecute_24()
	{
		yield return new TwineText(@"This is the end of the first part of the story.");
		yield return new TwineText(@"");
		yield return new TwineText(@"With this choice, Aya freaks out, and knocks the man out again to get some time to think about what she just did. Your previous choices will also follow you, as they will modify the outcome of the story as it continues.");
		yield return new TwineText(@"");
		yield return new TwineText(@"If you want updates on the next parts of the story, please give us your email in the GForm.");
		yield return new TwineText(@"");
		yield return new TwineText(@"Thanks for playing :D");	
	}
    
	// .............
	// #25: Introduction

	void passageInit_25()
	{
		this.Passages["Introduction"] = new TwinePassage("Introduction", new string[]{  }, passageExecute_25);
	}

	IEnumerable<TwineOutput> passageExecute_25()
	{
		yield return new TwineText(@"Hello, and welcome to this playtest of Scientifically Tested and Approved!");
		yield return new TwineText(@"");
		yield return new TwineText(@"This is a visual novel. The main part of this game is the story. Today, you will only be able to play through the first part of it. This is a work in progress, so it may not be perfect, so you will be given the opportunity to help us improve with a questionaire at the end.");
		yield return new TwineText(@"");
		yield return new TwineText(@"Enjoy!");
		yield return new TwineText(@"");
		yield return new TwineLink(@"Beginning", @"Beginning", @"Beginning", null, null);	
	}

}