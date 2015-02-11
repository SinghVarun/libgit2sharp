﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibGit2Sharp
{
    /// <summary>
    /// Information about a rebase step that is about to be performed.
    /// </summary>
    public class BeforeRebaseStepInfo
    {
        internal BeforeRebaseStepInfo(RebaseStepInfo stepInfo)
        {
            StepInfo = stepInfo;
        }

        /// <summary>
        /// Information on the step that is about to be performed.
        /// </summary>
        public RebaseStepInfo StepInfo { get; private set; }
    }
}
