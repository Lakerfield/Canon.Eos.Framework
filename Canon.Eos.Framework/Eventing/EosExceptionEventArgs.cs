﻿using System;

namespace Canon.Eos.Framework.Eventing
{
  public class EosExceptionEventArgs : EventArgs
  {
    public Exception Exception { get; set; }
  }
}
