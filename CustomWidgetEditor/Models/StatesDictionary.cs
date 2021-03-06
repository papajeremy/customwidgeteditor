﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web.Mvc;

namespace CustomWidgetEditor.Models
{
  public static class StatesDictionary
  {
    public static Dictionary<string, string> States = new Dictionary<string, string>()
    {
      { "AK", "Alaska" },
      { "AZ", "Arizona" },
      { "IC", "IntoCareers" },
      { "ID", "Idaho" },
      { "IL", "Illinois" },
      { "IN", "Indianna" },
      { "MA", "Massachusetts" },
      { "MN", "Minnisota" },
      { "MO", "Missouri" },
      { "MT", "Montanna" },
      { "NE", "Nebraska" },
      { "NJ", "New Jersey" },
      { "NV", "Nevada" },
      { "OH", "Ohio" },
      { "OK", "Oklahoma" },
      { "SC", "South Carolina" }
    };
  }
}