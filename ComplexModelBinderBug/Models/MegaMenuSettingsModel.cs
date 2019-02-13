using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComplexModelBinderBug.Models
{
    // Token: 0x02000047 RID: 71
    public class MegaMenuSettingsModel
    {
        // Token: 0x1700005F RID: 95
        // (get) Token: 0x0600018B RID: 395 RVA: 0x00005E23 File Offset: 0x00004023
        // (set) Token: 0x0600018C RID: 396 RVA: 0x00005E2B File Offset: 0x0000402B
        public bool IsTrialVersion { get; set; }

        // Token: 0x17000060 RID: 96
        // (get) Token: 0x0600018D RID: 397 RVA: 0x00005E34 File Offset: 0x00004034
        // (set) Token: 0x0600018E RID: 398 RVA: 0x00005E3C File Offset: 0x0000403C
        public bool Enabled { get; set; }

        // Token: 0x17000061 RID: 97
        // (get) Token: 0x0600018F RID: 399 RVA: 0x00005E45 File Offset: 0x00004045
        // (set) Token: 0x06000190 RID: 400 RVA: 0x00005E4D File Offset: 0x0000404D
        public bool Enabled_OverrideForStore { get; set; }

        // Token: 0x17000062 RID: 98
        // (get) Token: 0x06000191 RID: 401 RVA: 0x00005E56 File Offset: 0x00004056
        // (set) Token: 0x06000192 RID: 402 RVA: 0x00005E5E File Offset: 0x0000405E
        public int ActiveStoreScopeConfiguration { get; set; }
    }
}
