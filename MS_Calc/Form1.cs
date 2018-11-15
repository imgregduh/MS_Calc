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

		private double minDamageCalc()
		{   // =CrowCoef*SkillPerct*(WepMin+BonusAtck)*(PhysMagAtck/BasePhysMagAtck)*(1/(1-Piercing))*(1+BonusBossDamage)*(1+MiscDmgBonus)*(1+DmgTotalBonus)
			double result = 0.0;
			result = (double)(CrowCoef_A.Value*SkillPercent_A.Value*(WeapMinAtck_A.Value+BonusAtck_A.Value)*(PhysMagicAtck_A.Value/BasePhysMagicAtck_A.Value)*(1/(1-Piercing_A.Value))*(1+BonusBossDmg_A.Value)*(1+MiscDmgBonus_A.Value)*(1+DmgTotalBonus_A.Value));
			return result;
		}
		private double maxDamageCalc()
		{
			double result = 0.0;
			result = (double)(CrowCoef_A.Value * SkillPercent_A.Value * (WeapMaxAtck_A.Value + BonusAtck_A.Value) * (PhysMagicAtck_A.Value / BasePhysMagicAtck_A.Value) * (1 / (1 - Piercing_A.Value)) * (1 + BonusBossDmg_A.Value) * (1 + MiscDmgBonus_A.Value) * (1 + DmgTotalBonus_A.Value));
			return result;
		}
		private double AvgDamageCalc()
		{
			double result = 0.0;
			result = (minDamageCalc() + maxDamageCalc()) / 2;
			return result;
		}
		private double avgCritDamageCalc()
		{
			double result = 0.0;
			result = AvgDamageCalc() * (double)(CritDmg_A.Value);
			return result;
		}
		private double maxCritDamageCalc()
		{
			double result = 0.0;
			result = maxDamageCalc() * (double)(CritDmg_A.Value);
			return result;
		}
		private double dmgPerAttackCalc()
		{
			double result = 0.0;
			result = (avgCritDamageCalc() * (double)CritRate_A.Value)+((1-(double)CritRate_A.Value)*AvgDamageCalc());
			return result;
		}

		private void Calculate_Button_Click(object sender, EventArgs e)
		{

			MinDmgResultA.Text = (minDamageCalc().ToString());
			MaxDmgResultA.Text = (maxDamageCalc().ToString());
			AvgDmgResultA.Text = (AvgDamageCalc().ToString());
			AvgCritDmgResultA.Text = (avgCritDamageCalc().ToString());
			MaxCritDmgResultA.Text = (maxDamageCalc().ToString());
			DmgPerAtckResultA.Text = (dmgPerAttackCalc().ToString());

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
