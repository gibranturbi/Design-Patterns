﻿using static System.Console;

namespace Singleton
{
  sealed class Singleton
  {
    static int instanceCounter = 0;
    private static Singleton singleInstance = null;
    private Singleton()
    {
      instanceCounter++;
      WriteLine("Instances created " + instanceCounter );
    }

    public static Singleton SingleInstance
    {
      get
      {
        if (singleInstance == null)
        {
          singleInstance = new Singleton();
        }
        return singleInstance;
      }
    }
    public void LogMessage(string message)
    {
      WriteLine("Message " + message);
    }
  }
}
