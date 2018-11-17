using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS_Calc
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
		/* Config A */
		private double minDmgCalc_A()
		{
			double result = 0.0;
			result = (double)(CrowCoef_A.Value * SkillPercent_A.Value * (WeapMinAtck_A.Value + BonusAtck_A.Value) * (PhysMagicAtck_A.Value / BasePhysMagicAtck_A.Value) * (1 / (1 - Piercing_A.Value)) * (1 + BonusBossDmg_A.Value) * (1 + MiscDmgBonus_A.Value) * (1 + DmgTotalBonus_A.Value));
			return result;
		}
		private double maxDmgCalc_A()
		{
			double result = 0.0;
			result = (double)(CrowCoef_A.Value * SkillPercent_A.Value * (WeapMaxAtck_A.Value + BonusAtck_A.Value) * (PhysMagicAtck_A.Value / BasePhysMagicAtck_A.Value) * (1 / (1 - Piercing_A.Value)) * (1 + BonusBossDmg_A.Value) * (1 + MiscDmgBonus_A.Value) * (1 + DmgTotalBonus_A.Value));
			return result;
		}
		private double avgDmgCalc_A()
		{
			double result = 0.0;
			result = (minDmgCalc_A() + maxDmgCalc_A()) / 2;
			return result;
		}
		private double avgCritDmgCalc_A()
		{
			double result = 0.0;
			result = avgDmgCalc_A() * (double)(CritDmg_A.Value);
			return result;
		}
		private double maxCritDmgCalc_A()
		{
			double result = 0.0;
			result = maxDmgCalc_A() * (double)(CritDmg_A.Value);
			return result;
		}
		private double dmgPerAtkCalc_A()
		{
			double result = 0.0;
			result = (avgCritDmgCalc_A() * (double)CritRate_A.Value) + ((1 - (double)CritRate_A.Value) * avgDmgCalc_A());
			return result;
		}

		/* Config B */
		private double minDmgCalc_B()
		{
			double result = 0.0;
			result = (double)(CrowCoef_B.Value * SkillPercent_B.Value * (WeapMinAtck_B.Value + BonusAtck_B.Value) * (PhysMagicAtck_B.Value / BasePhysMagicAtck_B.Value) * (1 / (1 - Piercing_B.Value)) * (1 + BonusBossDmg_B.Value) * (1 + MiscDmgBonus_B.Value) * (1 + DmgTotalBonus_B.Value));
			return result;
		}
		private double maxDmgCalc_B()
		{
			double result = 0.0;
			result = (double)(CrowCoef_B.Value * SkillPercent_B.Value * (WeapMaxAtck_B.Value + BonusAtck_B.Value) * (PhysMagicAtck_B.Value / BasePhysMagicAtck_B.Value) * (1 / (1 - Piercing_B.Value)) * (1 + BonusBossDmg_B.Value) * (1 + MiscDmgBonus_B.Value) * (1 + DmgTotalBonus_B.Value));
			return result;
		}
		private double avgDmgCalc_B()
		{
			double result = 0.0;
			result = (minDmgCalc_B() + maxDmgCalc_B()) / 2;
			return result;
		}
		private double avgCritDmgCalc_B()
		{
			double result = 0.0;
			result = avgDmgCalc_B() * (double)(CritDmg_C.Value);
			return result;
		}
		private double maxCritDmgCalc_B()
		{
			double result = 0.0;
			result = maxDmgCalc_B() * (double)(CritDmg_C.Value);
			return result;
		}
		private double dmgPerAtkCalc_B()
		{
			double result = 0.0;
			result = (avgCritDmgCalc_B() * (double)CritRate_C.Value) + ((1 - (double)CritRate_C.Value) * avgDmgCalc_B());
			return result;
		}

		private double minDmgCalc_C()
		{
			double result = 0.0;
			result = (double)(CrowCoef_C.Value * SkillPercent_C.Value * (WeapMinAtck_C.Value + BonusAtck_C.Value) * (PhysMagicAtck_C.Value / BasePhysMagicAtck_C.Value) * (1 / (1 - Piercing_C.Value)) * (1 + BonusBossDmg_C.Value) * (1 + MiscDmgBonus_C.Value) * (1 + DmgTotalBonus_C.Value));
			return result;
		}
		private double maxDmgCalc_C()
		{
			double result = 0.0;
			result = (double)(CrowCoef_C.Value * SkillPercent_C.Value * (WeapMaxAtck_C.Value + BonusAtck_C.Value) * (PhysMagicAtck_C.Value / BasePhysMagicAtck_C.Value) * (1 / (1 - Piercing_C.Value)) * (1 + BonusBossDmg_C.Value) * (1 + MiscDmgBonus_C.Value) * (1 + DmgTotalBonus_C.Value));
			return result;
		}
		private double avgDmgCalc_C()
		{
			double result = 0.0;
			result = (minDmgCalc_C() + maxDmgCalc_C()) / 2;
			return result;
		}
		private double avgCritDmgCalc_C()
		{
			double result = 0.0;
			result = avgDmgCalc_C() * (double)(CritDmg_C.Value);
			return result;
		}
		private double maxCritDmgCalc_C()
		{
			double result = 0.0;
			result = maxDmgCalc_C() * (double)(CritDmg_C.Value);
			return result;
		}
		private double dmgPerAtkCalc_C()
		{
			double result = 0.0;
			result = (avgCritDmgCalc_C() * (double)CritRate_C.Value) + ((1 - (double)CritRate_C.Value) * avgDmgCalc_C());
			return result;
		}

		private void Calculate_Button_Click(object sender, EventArgs e)
		{
			// Config A
			MinDmgResultA.Text = (minDmgCalc_A().ToString());
			MaxDmgResultA.Text = (maxDmgCalc_A().ToString());
			AvgDmgResultA.Text = (avgDmgCalc_A().ToString());
			AvgCritDmgResultA.Text = (avgCritDmgCalc_A().ToString());
			MaxCritDmgResultA.Text = (maxDmgCalc_A().ToString());
			DmgPerAtckResultA.Text = (dmgPerAtkCalc_A().ToString());

			// Config B
			MinDmgResultB.Text = (minDmgCalc_B().ToString());
			MaxDmgResultB.Text = (maxDmgCalc_B().ToString());
			AvgDmgResultB.Text = (avgDmgCalc_B().ToString());
			AvgCritDmgResultB.Text = (avgCritDmgCalc_B().ToString());
			MaxCritDmgResultB.Text = (maxDmgCalc_B().ToString());
			DmgPerAtckResultB.Text = (dmgPerAtkCalc_B().ToString());

			// Config C
			MinDmgResultC.Text = (minDmgCalc_C().ToString());
			MaxDmgResultC.Text = (maxDmgCalc_C().ToString());
			AvgDmgResultC.Text = (avgDmgCalc_C().ToString());
			AvgCritDmgResultC.Text = (avgCritDmgCalc_C().ToString());
			MaxCritDmgResultC.Text = (maxDmgCalc_C().ToString());
			DmgPerAtckResultC.Text = (dmgPerAtkCalc_C().ToString());
		}

		private void WeapMinAtck_A_Enter(object sender, EventArgs e)
		{
			WeapMinAtck_A.Select(0, 10);
		}

		private void WeapMaxAtck_A_Enter(object sender, EventArgs e)
		{
			WeapMaxAtck_A.Select(0, 10);
		}

		private void BonusAtck_A_Enter(object sender, EventArgs e)
		{
			BonusAtck_A.Select(0, 10);
		}

		private void PhysMagicAtck_A_Enter(object sender, EventArgs e)
		{
			PhysMagicAtck_A.Select(0, 10);
		}

		private void BasePhysMagicAtck_A_Enter(object sender, EventArgs e)
		{
			BasePhysMagicAtck_A.Select(0, 10);
		}

		private void Piercing_A_Enter(object sender, EventArgs e)
		{
			Piercing_A.Select(0, 10);
		}

		private void CritRate_A_Enter(object sender, EventArgs e)
		{
			CritRate_A.Select(0, 10);
		}

		private void CritDmg_A_Enter(object sender, EventArgs e)
		{
			CritDmg_A.Select(0, 10);
		}

		private void MiscDmgBonus_A_Enter(object sender, EventArgs e)
		{
			MiscDmgBonus_A.Select(0, 10);
		}

		private void BonusBossDmg_A_Enter(object sender, EventArgs e)
		{
			BonusBossDmg_A.Select(0, 10);
		}

		private void DmgTotalBonus_A_Enter(object sender, EventArgs e)
		{
			DmgTotalBonus_A.Select(0, 10);
		}

		private void SkillPercent_A_Enter(object sender, EventArgs e)
		{
			SkillPercent_A.Select(0, 10);
		}
	}
}
