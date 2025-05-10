using System;

// Base class
class SocialMedia
{
    public virtual void Post()
    {
        Console.WriteLine("Posting on social media");
    }
}

// Derived class: Facebook
class FacebookPost : SocialMedia
{
    public override void Post()
    {
        Console.WriteLine("Posting on Facebook");
    }
}

// Derived class: Twitter
class TwitterPost : SocialMedia
{
    public override void Post()
    {
        Console.WriteLine("Tweeting on Twitter");
    }
}

// Derived class: Instagram
class InstagramPost : SocialMedia
{
    public override void Post()
    {
        Console.WriteLine("Posting on Instagram");
    }
}

class Program
{
    static void Main()
    {
        // Direct object calls
        FacebookPost fb = new FacebookPost();
        TwitterPost tw = new TwitterPost();
        InstagramPost ig = new InstagramPost();

        fb.Post();
        tw.Post();
        ig.Post();

        Console.WriteLine();

        // Polymorphism: base class reference to derived objects
        SocialMedia post1 = new FacebookPost();
        SocialMedia post2 = new TwitterPost();
        SocialMedia post3 = new InstagramPost();

        post1.Post();
        post2.Post();
        post3.Post();
    }
}