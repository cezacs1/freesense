using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;

// Token: 0x020000A0 RID: 160
public class 11AE0F91
{
	// Token: 0x060002C3 RID: 707 RVA: 0x00057890 File Offset: 0x00055490
	private void 3FABA399()
	{
		uint num = 3341484562U;
		11AE0F91.80068AA5 47B6BF;
		if (num != 1244820622U)
		{
			num %= 8859454U;
			11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
			num <<= 9;
			47B6BF = 5F355D3D.F3AC8C0D();
			num = 2995107086U % num;
		}
		do
		{
			num = 3784317712U - num;
			this.16011CAB.07A52495(11AE0F91.281DB71D.62820902(47B6BF));
		}
		while (num < 2569697051U);
	}

	// Token: 0x060002C4 RID: 708 RVA: 0x0005C18C File Offset: 0x00059D8C
	private void FC8F3F05()
	{
		for (;;)
		{
			11AE0F91.833BF530 833BF = this.4FA4D617;
			uint num = 4120101673U;
			int 9BA5622C = 833BF.99BB76A6();
			num = 3376010932U - num;
			Type type = this.50932DAD(9BA5622C);
			object obj2;
			Type type3;
			do
			{
				num = 3695131689U * num;
				11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
				num -= 3892713223U;
				object obj = 5F355D3D.F3AC8C0D().D697DB31();
				num = (1753379604U ^ num);
				obj2 = obj;
				object obj3 = obj2;
				num += 2660144134U;
				Type type2 = obj3.GetType();
				num = (414956967U ^ num);
				type3 = type2;
			}
			while (num + 588381605U == 0U);
			Type left = type3;
			num /= 136909606U;
			bool flag = left != type;
			num = 2928595503U + num;
			if (flag)
			{
				bool flag2 = type.IsAssignableFrom(type3);
				num += 0U;
				if (!flag2)
				{
					break;
				}
			}
			num -= 2897260427U;
			11AE0F91.5F355D3D 5F355D3D2 = this.16011CAB;
			object 9730DA = obj2;
			num = 3099300151U % num;
			Type 4A3DAA3A = type;
			num = 112829365U << (int)num;
			5F355D3D2.07A52495(11AE0F91.80068AA5.872D5EA9(9730DA, 4A3DAA3A));
			if (num >> 19 != 0U)
			{
				return;
			}
		}
		throw new InvalidCastException();
	}

	// Token: 0x060002C5 RID: 709 RVA: 0x000573AC File Offset: 0x00054FAC
	private void B3B7E81E()
	{
		uint num = 2510425403U;
		num = 3291749018U % num;
		11AE0F91.80068AA5 2B1C = this.16011CAB.F3AC8C0D();
		11AE0F91.80068AA5 80068AA;
		do
		{
			num = 3451117448U >> (int)num;
			80068AA = this.16011CAB.F3AC8C0D();
			num = (554820108U & num);
		}
		while (4060425990U <= num);
		11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
		num -= 789619613U;
		11AE0F91.80068AA5 4C94F1BF = 80068AA;
		num = (471808909U & num);
		11AE0F91.80068AA5 268B972E = 11AE0F91.6A9A2996.C1BF27AF(4C94F1BF, 2B1C);
		num &= 2905477005U;
		5F355D3D.07A52495(268B972E);
	}

	// Token: 0x060002C6 RID: 710 RVA: 0x0005B59C File Offset: 0x0005919C
	private void 0717C01B()
	{
		int 9BA5622C = this.4FA4D617.99BB76A6();
		uint num = 505917494U;
		Type type = this.50932DAD(9BA5622C);
		num = 2176397106U % num;
		Type type2 = type;
		num %= 3407142290U;
		if (782668063U - num != 0U)
		{
			11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
			num = (791583786U ^ num);
			11AE0F91.80068AA5 80068AA = 5F355D3D.F3AC8C0D();
			for (;;)
			{
				11AE0F91.80068AA5 80068AA2 = this.16011CAB.F3AC8C0D();
				num = 1971619363U % num;
				num -= 775007509U;
				11AE0F91.5F355D3D 5F355D3D2 = this.16011CAB;
				num = (3518285625U & num);
				11AE0F91.80068AA5 80068AA3 = 5F355D3D2.F3AC8C0D();
				num = 715367611U / num;
				object obj = 80068AA3.D697DB31();
				num >>= 3;
				Array array = obj as Array;
				num %= 3121704322U;
				if (array == null)
				{
					break;
				}
				num |= 4189650603U;
				11AE0F91.80068AA5 80068AA4 = 80068AA;
				num ^= 3148567075U;
				80068AA = 80068AA4.01245B13(type2);
				num -= 3651757455U;
				Type elementType = array.GetType().GetElementType();
				num &= 2441990403U;
				Type left = type2;
				num /= 3827811124U;
				if (left != elementType)
				{
					80068AA = 80068AA.01245B13(elementType);
					num += 0U;
				}
				11AE0F91.80068AA5 80068AA5 = 80068AA;
				num = 3652719008U << (int)num;
				object value = 80068AA5.D697DB31();
				11AE0F91.80068AA5 80068AA6 = 80068AA2;
				num >>= 20;
				int index = 80068AA6.30B7A98C();
				num -= 3643505727U;
				array.SetValue(value, index);
				if (1999465222U >= num)
				{
					return;
				}
			}
			throw new ArgumentException();
		}
	}

	// Token: 0x060002C7 RID: 711 RVA: 0x00057ADC File Offset: 0x000556DC
	private void 5701C228()
	{
		11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
		uint num = 3476245040U;
		11AE0F91.80068AA5 80068AA = 5F355D3D.F3AC8C0D();
		num *= 338887206U;
		11AE0F91.80068AA5 979B1C = 80068AA;
		this.16011CAB.07A52495(11AE0F91.591C5123.798AFEBA(979B1C));
	}

	// Token: 0x060002C8 RID: 712 RVA: 0x0005B498 File Offset: 0x00059098
	private void AABEDF2C()
	{
		uint num;
		11AE0F91.80068AA5 80068AA2;
		do
		{
			11AE0F91.80068AA5 80068AA = this.16011CAB.F3AC8C0D();
			num = 3157760433U;
			80068AA2 = 80068AA;
		}
		while ((566000550U ^ num) == 0U);
		do
		{
			num = (1805102872U & num);
			11AE0F91.80068AA5 80068AA3 = this.16011CAB.F3AC8C0D();
			num |= 85709602U;
			11AE0F91.80068AA5 80068AA4 = 80068AA3;
			num %= 370780679U;
			11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
			num += 4044177853U;
			11AE0F91.80068AA5 d597812C = 80068AA4;
			11AE0F91.80068AA5 20BDE = 80068AA2;
			num >>= 24;
			5F355D3D.07A52495(11AE0F91.1C16CD2C.2434FB9C(d597812C, 20BDE));
		}
		while (num >= 3711569950U);
	}

	// Token: 0x060002C9 RID: 713 RVA: 0x0005C600 File Offset: 0x0005A200
	public object 8ABE7489(object[] 130BEFAB, int 8500EE3D)
	{
		uint num;
		do
		{
			11AE0F91.1280CA96 1280CA = this.4FA4D617;
			num = 1117347077U;
			1280CA.37242F0A(8500EE3D);
			num %= 454750742U;
		}
		while (num == 1814274458U);
		num %= 2661196212U;
		11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
		num = 288605465U << (int)num;
		5F355D3D.07A52495(new 11AE0F91.1C16CD2C(130BEFAB));
		object result;
		try
		{
			for (;;)
			{
				try
				{
					num = 2442952602U;
					for (;;)
					{
						Dictionary<uint, 11AE0F91.E489CC87> dictionary = this.891D0FB6;
						num = 480987571U << (int)num;
						num %= 1133597708U;
						uint key = (uint)this.4FA4D617.853F4BB0();
						num = 1954810122U * num;
						11AE0F91.E489CC87 e489CC = dictionary[key];
						num >>= 31;
						e489CC();
						num = 3309213993U >> (int)num;
						11AE0F91.1280CA96 1280CA2 = this.4FA4D617;
						num >>= 13;
						bool flag = 1280CA2.B395DB29() != 0;
						num >>= 14;
						if (!flag)
						{
							break;
						}
						if (2265590036U - num != 0U)
						{
							goto Block_5;
						}
					}
					break;
					Block_5:
					continue;
				}
				catch (Exception ex)
				{
					num = 2568809350U;
					Exception ex2 = ex;
					if (this.FE3CF238 == null && (2394113702U & num) != 0U)
					{
						Exception ex3 = ex2;
						num -= 2031049532U;
						this.70BBF99F = ex3;
						num ^= 3104930764U;
					}
					num = (1435228715U ^ num);
					this.5F16AE85();
					continue;
				}
				break;
			}
			num = 1169272487U;
			num = 3565709759U << (int)num;
			11AE0F91.80068AA5 80068AA = this.16011CAB.F3AC8C0D();
			num &= 1435300390U;
			object obj = 80068AA.D697DB31();
			num = (1100172940U | num);
			result = obj;
		}
		finally
		{
			num = 3224564903U;
			num = (127093160U | num);
			List<IntPtr> list = this.93160723;
			num = 3642125203U - num;
			using (List<IntPtr>.Enumerator enumerator = list.GetEnumerator())
			{
				for (;;)
				{
					num = 3399853618U << (int)num;
					if (!enumerator.MoveNext() && (num ^ 3675720328U) != 0U)
					{
						break;
					}
					num = 1999603611U;
					Marshal.FreeHGlobal(enumerator.Current);
					num ^= 1716382335U;
				}
			}
			do
			{
				num = 3148995235U;
				List<IntPtr> list2 = this.93160723;
				num = 2626115370U % num;
				list2.Clear();
			}
			while (2838558477U >> (int)num == 0U);
		}
		return result;
	}

	// Token: 0x060002CA RID: 714 RVA: 0x000576F0 File Offset: 0x000552F0
	private void 17110522()
	{
		11AE0F91.80068AA5 80068AA = this.16011CAB.F3AC8C0D();
		uint num = 3365585537U;
		11AE0F91.80068AA5 e59E4D1A = 80068AA;
		num = 673217959U / num;
		num -= 4061069357U;
		11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
		num &= 1243016705U;
		11AE0F91.80068AA5 80068AA2 = 5F355D3D.F3AC8C0D();
		num = 3208173732U << (int)num;
		11AE0F91.80068AA5 25968AB = 80068AA2;
		num = 3650703927U * num;
		11AE0F91.5F355D3D 5F355D3D2 = this.16011CAB;
		num += 2335195670U;
		5F355D3D2.07A52495(11AE0F91.CB943E91.9315E01E(25968AB, e59E4D1A));
	}

	// Token: 0x060002CB RID: 715 RVA: 0x00057B14 File Offset: 0x00055714
	private void 4F3336A2()
	{
		uint num = 1409861129U;
		if (num > 4171073442U)
		{
			goto IL_39;
		}
		IL_11:
		num ^= 2989925035U;
		11AE0F91.80068AA5 80068AA = this.16011CAB.F3AC8C0D();
		num = (2191621932U ^ num);
		if (3625903260U * num == 0U)
		{
			return;
		}
		IL_39:
		11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
		num %= 2734904478U;
		11AE0F91.80068AA5 d = 80068AA;
		num -= 3181463190U;
		11AE0F91.80068AA5 268B972E = 11AE0F91.840DFA36.B78D5C34(d);
		num = 363243810U - num;
		5F355D3D.07A52495(268B972E);
		if (1572203540U >= num)
		{
			goto IL_11;
		}
	}

	// Token: 0x060002CC RID: 716 RVA: 0x000564D0 File Offset: 0x000540D0
	private void 21BF3795()
	{
		uint num;
		do
		{
			11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
			11AE0F91.833BF530 833BF = this.4FA4D617;
			num = 2375343745U;
			double e71A18BC = 833BF.FA8E1432();
			num /= 665285307U;
			11AE0F91.80068AA5 268B972E = new 11AE0F91.122C9D2C(e71A18BC);
			num = 346617642U + num;
			5F355D3D.07A52495(268B972E);
		}
		while ((1006821538U ^ num) == 0U);
	}

	// Token: 0x060002CD RID: 717 RVA: 0x00056BE4 File Offset: 0x000547E4
	private void 772BCFA3()
	{
		uint num;
		do
		{
			num = 2947276938U;
			11AE0F91.80068AA5 a52CDCA = this.16011CAB.F3AC8C0D();
			num >>= 0;
			num = (2511836817U ^ num);
			11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
			num ^= 2643423019U;
			11AE0F91.80068AA5 80068AA = 5F355D3D.F3AC8C0D();
			if ((2444368179U ^ num) == 0U)
			{
				break;
			}
			11AE0F91.5F355D3D 5F355D3D2 = this.16011CAB;
			num = 1461117494U + num;
			11AE0F91.80068AA5 <<EMPTY_NAME>> = 80068AA;
			num ^= 3625188643U;
			5F355D3D2.07A52495(11AE0F91.CB943E91.83352C2C(<<EMPTY_NAME>>, a52CDCA));
		}
		while (3535213076U <= num);
	}

	// Token: 0x060002CE RID: 718 RVA: 0x000578F8 File Offset: 0x000554F8
	private void 089A8488()
	{
		uint num = 755562248U;
		if (num > 890995647U)
		{
			goto IL_25;
		}
		IL_11:
		11AE0F91.80068AA5 b1375B2C = this.16011CAB.F3AC8C0D();
		num -= 262314552U;
		IL_25:
		11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
		num -= 2494297780U;
		5F355D3D.07A52495(11AE0F91.373CCBBA.75837AA8(b1375B2C));
		if (num >> 0 != 0U)
		{
			return;
		}
		goto IL_11;
	}

	// Token: 0x060002CF RID: 719 RVA: 0x00057764 File Offset: 0x00055364
	private void 7B214F82()
	{
		uint num;
		11AE0F91.80068AA5 80068AA2;
		do
		{
			num = 2125496234U;
			11AE0F91.80068AA5 80068AA = this.16011CAB.F3AC8C0D();
			num >>= 11;
			80068AA2 = 80068AA;
		}
		while (num == 2701200182U);
		num = 1731676730U % num;
		11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
		num *= 2677181219U;
		11AE0F91.80068AA5 80068AA3 = 5F355D3D.F3AC8C0D();
		do
		{
			num = 2298895664U * num;
			11AE0F91.5F355D3D 5F355D3D2 = this.16011CAB;
			11AE0F91.80068AA5 8B0D512D = 80068AA3;
			num = 1720012705U - num;
			11AE0F91.80068AA5 47822F0A = 80068AA2;
			num = 437967674U - num;
			5F355D3D2.07A52495(11AE0F91.6A9A2996.BF22DEA6(8B0D512D, 47822F0A));
		}
		while (num > 2821746738U);
	}

	// Token: 0x060002D0 RID: 720 RVA: 0x0005658C File Offset: 0x0005418C
	private void D2008D07()
	{
		uint num = 3599207684U;
		num <<= 27;
		11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
		11AE0F91.80068AA5 80068AA = this.16011CAB.8827D009();
		num = 3886654473U << (int)num;
		5F355D3D.07A52495(80068AA.ECAA59A1());
	}

	// Token: 0x060002D1 RID: 721 RVA: 0x00057CA8 File Offset: 0x000558A8
	private void E91AE9BE()
	{
		uint num = 948353422U;
		if (805980444U * num != 0U)
		{
			num /= 361710133U;
			11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
			num = 545286410U % num;
			11AE0F91.80068AA5 80068AA = 5F355D3D.F3AC8C0D();
			num |= 4195546884U;
			11AE0F91.80068AA5 80068AA2 = 80068AA;
			num += 3868409651U;
			if (2753303552U <= num)
			{
				num = 128812700U + num;
				11AE0F91.5F355D3D 5F355D3D2 = this.16011CAB;
				num = (2846221606U ^ num);
				11AE0F91.80068AA5 b488EEAD = 80068AA2;
				num = 3372399773U + num;
				5F355D3D2.07A52495(11AE0F91.7621E502.77AB949A(b488EEAD));
			}
		}
	}

	// Token: 0x060002D2 RID: 722 RVA: 0x000558CC File Offset: 0x000534CC
	private Type 50932DAD(int 9BA5622C)
	{
		uint num = 2390968096U;
		if (num + 4119015969U == 0U)
		{
			goto IL_3C;
		}
		IL_12:
		num = 473366425U >> (int)num;
		MemberInfo memberInfo = this.68B43D97(9BA5622C);
		num -= 1664575523U;
		MemberInfo memberInfo2 = memberInfo;
		if ((1921900814U ^ num) == 0U)
		{
			goto IL_78;
		}
		IL_3C:
		MemberInfo memberInfo3 = memberInfo2;
		num &= 2241275706U;
		bool flag = memberInfo3 is Type;
		num -= 3281095352U;
		if (flag)
		{
			num |= 2366646456U;
			if (96231308 << (int)num != 0)
			{
				return (Type)memberInfo2;
			}
			goto IL_12;
		}
		IL_78:
		num = 1178143232U - num;
		throw new InvalidOperationException();
	}

	// Token: 0x060002D3 RID: 723 RVA: 0x000579A4 File Offset: 0x000555A4
	private void 78B2EE3B()
	{
		uint num = 1226014992U;
		11AE0F91.80068AA5 80068AA2;
		do
		{
			11AE0F91.80068AA5 80068AA = this.16011CAB.F3AC8C0D();
			num %= 3400822785U;
			80068AA2 = 80068AA;
		}
		while (num == 2451314468U);
		num = 2064730152U >> (int)num;
		11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
		11AE0F91.80068AA5 6E3F = 80068AA2;
		num = 3432223038U % num;
		5F355D3D.07A52495(11AE0F91.6A9A2996.4E8DB1A3(6E3F));
	}

	// Token: 0x060002D4 RID: 724 RVA: 0x0005751C File Offset: 0x0005511C
	private void C535480E()
	{
		uint num = 976423213U;
		11AE0F91.80068AA5 80068AA = this.16011CAB.F3AC8C0D();
		do
		{
			11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
			11AE0F91.80068AA5 fc2F2E = 80068AA;
			num = (1152619939U | num);
			5F355D3D.07A52495(11AE0F91.122C9D2C.AB1162AA(fc2F2E));
		}
		while (num <= 691726219U);
	}

	// Token: 0x060002D5 RID: 725 RVA: 0x00057A00 File Offset: 0x00055600
	private void BB89E48C()
	{
		uint num;
		11AE0F91.80068AA5 80068AA2;
		do
		{
			11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
			num = 2964386955U;
			11AE0F91.80068AA5 80068AA = 5F355D3D.F3AC8C0D();
			num *= 3791744180U;
			80068AA2 = 80068AA;
			num |= 3870596778U;
		}
		while ((num & 2619998494U) == 0U);
		do
		{
			num /= 2719356704U;
			11AE0F91.5F355D3D 5F355D3D2 = this.16011CAB;
			num = 1631553557U / num;
			11AE0F91.80068AA5 d393F = 80068AA2;
			num = 2382472330U * num;
			11AE0F91.80068AA5 268B972E = 11AE0F91.8A270C3B.16294C98(d393F);
			num -= 3985872643U;
			5F355D3D2.07A52495(268B972E);
		}
		while (2182075318U == num);
	}

	// Token: 0x060002D6 RID: 726 RVA: 0x000581C4 File Offset: 0x00055DC4
	private void 1F26AF94()
	{
		uint num = 2182286340U;
		if (num * 3565783188U != 0U)
		{
			goto IL_12;
		}
		11AE0F91.80068AA5 80068AA;
		11AE0F91.80068AA5 80068AA2;
		Type type;
		for (;;)
		{
			IL_3A:
			80068AA = this.16011CAB.F3AC8C0D();
			80068AA2 = this.16011CAB.F3AC8C0D();
			if (1840716950U != num)
			{
				80068AA = 80068AA.01245B13(type);
				num %= 406813312U;
				11AE0F91.80068AA5 80068AA3 = 80068AA2;
				num = (243543327U ^ num);
				bool flag = 80068AA3.FC990F28();
				num = 2081504026U << (int)num;
				if (!flag)
				{
					goto IL_113;
				}
				num = 2997416987U >> (int)num;
				11AE0F91.80068AA5 80068AA4 = 80068AA2;
				num *= 388079928U;
				Type left = 80068AA4.20129380();
				Type right = type;
				num = (2290492598U ^ num);
				bool flag2 = left != right;
				num %= 1562741813U;
				if (!flag2)
				{
					goto IL_144;
				}
				num &= 2726933654U;
				if ((604724789U ^ num) != 0U)
				{
					break;
				}
			}
		}
		11AE0F91.80068AA5 80068AA5 = 80068AA;
		num = 1973454753U / num;
		11AE0F91.80068AA5 80068AA6 = 80068AA2;
		num = (454854455U | num);
		Type 31130EB = 80068AA6.20129380();
		num >>= 28;
		11AE0F91.80068AA5 80068AA7 = 80068AA5.01245B13(31130EB);
		num = 2402920335U + num;
		80068AA = 80068AA7;
		num ^= 3665043385U;
		goto IL_144;
		IL_113:
		num *= 404432792U;
		if ((num ^ 2411003401U) == 0U)
		{
			goto IL_12;
		}
		11AE0F91.80068AA5 80068AA8 = 80068AA2;
		num >>= 30;
		80068AA2 = new 11AE0F91.92167A27(80068AA8.D20542BB(), type);
		num += 1431156776U;
		IL_144:
		num %= 3569247520U;
		80068AA2.7E869424(80068AA.D697DB31());
		return;
		IL_12:
		11AE0F91.833BF530 833BF = this.4FA4D617;
		num *= 3028915235U;
		Type type2 = this.50932DAD(833BF.99BB76A6());
		num = 1226088065U >> (int)num;
		type = type2;
		goto IL_3A;
	}

	// Token: 0x060002D7 RID: 727 RVA: 0x00056D8C File Offset: 0x0005498C
	private void 6F91C53F()
	{
		uint num;
		do
		{
			11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
			num = 4263262722U;
			11AE0F91.80068AA5 80068AA = 5F355D3D.F3AC8C0D();
			num = 907516033U << (int)num;
			11AE0F91.80068AA5 80068AA2 = 80068AA;
			if (2402085935U > num)
			{
				break;
			}
			num = 1076798858U + num;
			11AE0F91.80068AA5 80068AA3 = this.16011CAB.F3AC8C0D();
			num = 3643057196U / num;
			11AE0F91.80068AA5 80068AA4 = 80068AA3;
			num <<= 24;
			11AE0F91.5F355D3D 5F355D3D2 = this.16011CAB;
			num |= 203284646U;
			11AE0F91.80068AA5 <<EMPTY_NAME>> = 80068AA4;
			11AE0F91.80068AA5 1F28B7BB = 80068AA2;
			num = (2131401866U | num);
			11AE0F91.80068AA5 268B972E = 11AE0F91.7621E502.072E5F9D(<<EMPTY_NAME>>, 1F28B7BB);
			num = (1486157355U & num);
			5F355D3D2.07A52495(268B972E);
		}
		while (num > 2443977256U);
	}

	// Token: 0x060002D8 RID: 728 RVA: 0x0005B8B0 File Offset: 0x000594B0
	private void DFB9313F()
	{
		for (;;)
		{
			uint num = 3049104175U;
			11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
			num = (2249123223U | num);
			11AE0F91.80068AA5 80068AA = 5F355D3D.F3AC8C0D();
			num -= 3676034607U;
			11AE0F91.80068AA5 80068AA2 = 80068AA;
			if (2013572114U == num)
			{
				break;
			}
			Array array2;
			do
			{
				num |= 2586282674U;
				11AE0F91.5F355D3D 5F355D3D2 = this.16011CAB;
				num -= 2971677697U;
				11AE0F91.80068AA5 80068AA3 = 5F355D3D2.F3AC8C0D();
				num = 4230472882U / num;
				object obj = 80068AA3.D697DB31();
				num *= 2349859354U;
				Array array = obj as Array;
				num = 1133619901U - num;
				array2 = array;
				bool flag = array2 != null;
				num %= 2919982887U;
				if (!flag)
				{
					goto IL_79;
				}
			}
			while ((num & 3635046690U) == 0U);
			11AE0F91.5F355D3D 5F355D3D3 = this.16011CAB;
			Array 0A043CBB = array2;
			int c424FE = 80068AA2.30B7A98C();
			num -= 2862429978U;
			11AE0F91.80068AA5 268B972E = new 11AE0F91.2C3CDA04(0A043CBB, c424FE);
			num ^= 872477584U;
			5F355D3D3.07A52495(268B972E);
			if (2653478459U >> (int)num != 0U)
			{
				return;
			}
		}
		IL_79:
		throw new ArgumentException();
	}

	// Token: 0x060002D9 RID: 729 RVA: 0x00056FE8 File Offset: 0x00054BE8
	private void 72BB53B8()
	{
		uint num = 423079474U;
		if (num < 1906514453U)
		{
			num >>= 8;
			11AE0F91.80068AA5 80068AA = this.16011CAB.F3AC8C0D();
			num |= 2030291125U;
			do
			{
				num = 1074628121U / num;
				11AE0F91.80068AA5 80068AA2 = this.16011CAB.F3AC8C0D();
				num = 2568409381U + num;
				11AE0F91.80068AA5 80068AA3 = 80068AA2;
				11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
				11AE0F91.80068AA5 87B0B = 80068AA3;
				num = 3994210727U % num;
				11AE0F91.80068AA5 5B364EB = 80068AA;
				num = 2911658245U * num;
				5F355D3D.07A52495(11AE0F91.8A270C3B.6E864C1A(87B0B, 5B364EB));
			}
			while (1863523725U == num);
		}
	}

	// Token: 0x060002DA RID: 730 RVA: 0x000570D4 File Offset: 0x00054CD4
	private void 9C38BD9E()
	{
		uint num = 2886884265U;
		num = 2039414303U - num;
		11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
		num = 160630019U + num;
		11AE0F91.80068AA5 e98FEE = 5F355D3D.F3AC8C0D();
		if (num / 104022959U != 0U)
		{
			11AE0F91.5F355D3D 5F355D3D2 = this.16011CAB;
			num = 672830780U - num;
			11AE0F91.80068AA5 80068AA = 5F355D3D2.F3AC8C0D();
			num ^= 1663426486U;
			11AE0F91.80068AA5 80068AA2 = 80068AA;
			if (num < 1396125611U)
			{
				num += 2804049677U;
				11AE0F91.5F355D3D 5F355D3D3 = this.16011CAB;
				11AE0F91.80068AA5 d43B341E = 80068AA2;
				num /= 675077141U;
				11AE0F91.80068AA5 268B972E = 11AE0F91.122C9D2C.A49C8FA2(d43B341E, e98FEE);
				num = (1336163978U & num);
				5F355D3D3.07A52495(268B972E);
			}
		}
	}

	// Token: 0x060002DB RID: 731 RVA: 0x0005B398 File Offset: 0x00058F98
	private void 51AF9930()
	{
		11AE0F91.80068AA5 80068AA = this.16011CAB.F3AC8C0D();
		uint num = 3431311278U;
		11AE0F91.80068AA5 42AD44A = 80068AA;
		num += 1664607240U;
		for (;;)
		{
			num %= 461661465U;
			11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
			num = 2436292398U * num;
			11AE0F91.80068AA5 80068AA2 = 5F355D3D.F3AC8C0D();
			num = 2811873069U + num;
			11AE0F91.80068AA5 e43088BA = 80068AA2;
			num &= 4104104746U;
			if (3130785960U != num)
			{
				num = (2684505900U & num);
				11AE0F91.5F355D3D 5F355D3D2 = this.16011CAB;
				11AE0F91.80068AA5 268B972E = 11AE0F91.7621E502.8A95E515(e43088BA, 42AD44A);
				num = 1461827349U << (int)num;
				5F355D3D2.07A52495(268B972E);
				if (1488625963U >> (int)num != 0U)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060002DC RID: 732 RVA: 0x00057D28 File Offset: 0x00055928
	private void 1F80B42F()
	{
		uint num = 36913186U;
		11AE0F91.80068AA5 fd2D;
		do
		{
			11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
			num = 3492859315U * num;
			11AE0F91.80068AA5 80068AA = 5F355D3D.F3AC8C0D();
			num += 2276787517U;
			fd2D = 80068AA;
		}
		while (680705704U + num == 0U);
		do
		{
			this.16011CAB.07A52495(11AE0F91.7621E502.572C9C80(fd2D));
		}
		while (732187955U > num);
	}

	// Token: 0x060002DD RID: 733 RVA: 0x00055228 File Offset: 0x00052E28
	private void 7D1F7D2C()
	{
		uint num = 2091963185U;
		if (2492356018U >> (int)num == 0U)
		{
			goto IL_51;
		}
		IL_18:
		num = (679581759U ^ num);
		byte b = this.4FA4D617.23A12822();
		num /= 2805543963U;
		11AE0F91.833BF530 833BF = this.4FA4D617;
		num >>= 12;
		int num2 = 833BF.99BB76A6();
		num = (2745961515U ^ num);
		IL_51:
		num -= 2701905461U;
		11AE0F91.833BF530 833BF2 = this.4FA4D617;
		num = 2240532610U * num;
		int num3 = 833BF2.99BB76A6();
		num = (3254838297U ^ num);
		int num4 = this.4FA4D617.99BB76A6();
		num /= 2879049534U;
		int num5 = num4;
		num *= 707001095U;
		if (2805022128U >> (int)num != 0U)
		{
			num = (1933266449U ^ num);
			int num6 = this.4FA4D617.99BB76A6();
			num += 1301053979U;
			int f73C5FAD = num6;
			num >>= 16;
			11AE0F91.6B1722AF 6B1722AF = this.620F8223;
			int a399EF8E = num2;
			int eb2EDC = num3;
			byte 4CA16EB = b;
			int e50D0FB = num5;
			num = 663229360U + num;
			6B1722AF.C3BD7807(a399EF8E, eb2EDC, 4CA16EB, e50D0FB, f73C5FAD);
			return;
		}
		goto IL_18;
	}

	// Token: 0x060002DE RID: 734 RVA: 0x00056B60 File Offset: 0x00054760
	private void 2B984BB5()
	{
		uint num = 3071884708U;
		if (num + 3523378844U != 0U)
		{
			11AE0F91.80068AA5 ad;
			do
			{
				num = 1872590007U * num;
				11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
				num %= 4077095206U;
				ad = 5F355D3D.F3AC8C0D();
			}
			while (num + 151695498U == 0U);
			11AE0F91.5F355D3D 5F355D3D2 = this.16011CAB;
			num = (4212848652U ^ num);
			11AE0F91.80068AA5 80068AA = 5F355D3D2.F3AC8C0D();
			num = 2961779874U << (int)num;
			11AE0F91.80068AA5 6E83AF = 80068AA;
			num = 1780520986U / num;
			this.16011CAB.07A52495(11AE0F91.122C9D2C.4925D79E(6E83AF, ad));
		}
	}

	// Token: 0x060002DF RID: 735 RVA: 0x0005B130 File Offset: 0x00058D30
	private void 199380B8()
	{
		uint num;
		do
		{
			num = 2301132694U;
			num <<= 3;
			Type type = this.50932DAD(this.4FA4D617.99BB76A6());
			num <<= 20;
			Type type2 = type;
			num = (462177055U | num);
			11AE0F91.80068AA5 80068AA = this.16011CAB.F3AC8C0D();
			object obj = null;
			num = (3246993467U & num);
			object 9590F = obj;
			Type type3 = type2;
			num += 3384740610U;
			bool isValueType = type3.IsValueType;
			num >>= 24;
			if (isValueType)
			{
				Type underlyingType = Nullable.GetUnderlyingType(type2);
				num = 3868738693U % num;
				bool flag = underlyingType == null;
				num = 1133338786U - num;
				num += 3161628714U;
				if (flag)
				{
					Type type4 = type2;
					num = (2134069293U ^ num);
					object uninitializedObject = FormatterServices.GetUninitializedObject(type4);
					num &= 1597293839U;
					9590F = uninitializedObject;
					num ^= 1596997773U;
				}
			}
			80068AA.7E869424(9590F);
		}
		while (731072948U >> (int)num == 0U);
	}

	// Token: 0x060002E0 RID: 736 RVA: 0x00056E20 File Offset: 0x00054A20
	private void DC901D88()
	{
		uint num = 1790490154U;
		11AE0F91.80068AA5 80068AA;
		if (num % 3047750975U != 0U)
		{
			num = 1570299823U * num;
			80068AA = this.16011CAB.F3AC8C0D();
			if (num > 1393956287U)
			{
				return;
			}
		}
		do
		{
			num >>= 16;
			11AE0F91.80068AA5 80068AA2 = this.16011CAB.F3AC8C0D();
			num = (2131279015U | num);
			11AE0F91.80068AA5 80068AA3 = 80068AA2;
			num = (4078971059U | num);
			num = 3298981540U >> (int)num;
			11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
			num /= 3502076163U;
			11AE0F91.80068AA5 d902F43D = 80068AA3;
			num = (3725039272U & num);
			11AE0F91.80068AA5 2A9ED1A = 80068AA;
			num = 3708901125U >> (int)num;
			11AE0F91.80068AA5 268B972E = 11AE0F91.122C9D2C.D332AB36(d902F43D, 2A9ED1A);
			num %= 675173403U;
			5F355D3D.07A52495(268B972E);
		}
		while ((11711278U ^ num) == 0U);
	}

	// Token: 0x060002E1 RID: 737 RVA: 0x00057A78 File Offset: 0x00055678
	private void 7305983E()
	{
		uint num = 4070511770U;
		if (num != 3868788875U)
		{
			11AE0F91.80068AA5 80068AA;
			do
			{
				11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
				num = (1438613379U | num);
				80068AA = 5F355D3D.F3AC8C0D();
			}
			while (146333206U + num == 0U);
			do
			{
				11AE0F91.5F355D3D 5F355D3D2 = this.16011CAB;
				11AE0F91.80068AA5 d120932A = 80068AA;
				num = (1396528045U ^ num);
				5F355D3D2.07A52495(11AE0F91.E2A0AC8B.9A073E2C(d120932A));
			}
			while (num >= 4061183391U);
		}
	}

	// Token: 0x060002E2 RID: 738 RVA: 0x0005A754 File Offset: 0x00058354
	private void AA3ACF94()
	{
		uint num = 2895983280U;
		if ((num & 2914350726U) != 0U)
		{
			goto IL_14;
		}
		11AE0F91.80068AA5 80068AA2;
		for (;;)
		{
			IL_34:
			11AE0F91.833BF530 833BF = new 11AE0F91.833BF530();
			num = 3996170625U / num;
			11AE0F91.833BF530 833BF2 = 833BF;
			if (num + 1066984886U != 0U)
			{
				goto IL_52;
			}
			IL_DE:
			Dictionary<int, 11AE0F91.80068AA5> dictionary = new Dictionary<int, 11AE0F91.80068AA5>();
			num *= 3624772658U;
			object[] array = null;
			num >>= 21;
			if (3719146681U < num)
			{
				goto IL_14;
			}
			ushort num2;
			if ((uint)num2 > (num ^ 1064U))
			{
				if (num == 1906190476U)
				{
					goto IL_14;
				}
				object[] array2 = new object[(int)num2];
				num = 3214164390U * num;
				array = array2;
				int num3 = (int)((uint)num2 - (num - 1076943343U));
				if (num - 4139237011U == 0U)
				{
					goto IL_A4;
				}
				for (;;)
				{
					num = 914806282U >> (int)num;
					if (num >= 1370238616U)
					{
						goto IL_14;
					}
					uint num4 = (uint)num3;
					num = (791154325U | num);
					if (num4 < (num ^ 791166615U))
					{
						break;
					}
					num = 1947651748U;
					11AE0F91.80068AA5 80068AA = this.16011CAB.F3AC8C0D();
					num /= 319835156U;
					80068AA2 = 80068AA;
					bool flag = 80068AA2.FC990F28();
					num = (3047782674U | num);
					if (flag)
					{
						if (num == 3910612255U)
						{
							goto IL_34;
						}
						Dictionary<int, 11AE0F91.80068AA5> dictionary2 = dictionary;
						num = (3431209272U ^ num);
						int key = num3;
						num *= 2888521871U;
						11AE0F91.80068AA5 value = 80068AA2;
						num >>= 10;
						dictionary2[key] = value;
						num ^= 3049206196U;
					}
					object[] array3 = array;
					int num5 = num3;
					11AE0F91.80068AA5 80068AA3 = 80068AA2;
					num = (3592903562U ^ num);
					num ^= 252906930U;
					object obj = 80068AA3.01245B13(this.50932DAD(833BF2.99BB76A6())).D697DB31();
					num = (3969591475U ^ num);
					array3[num5] = obj;
					num |= 783497732U;
					if ((3423303961U ^ num) == 0U)
					{
						goto IL_52;
					}
					int num6 = num3 - (int)(num ^ 2931244956U);
					num = (3442989472U & num);
					num3 = num6;
					num ^= 3423060080U;
				}
				num ^= 791165631U;
			}
			11AE0F91.833BF530 833BF3 = 833BF2;
			num = (2081511966U ^ num);
			int num7 = 833BF3.99BB76A6();
			if (3221809286U + num == 0U)
			{
				goto IL_14;
			}
			int num9;
			int num8 = num9;
			num -= 3978454558U;
			uint num10 = num ^ 2398025784U;
			num *= 1370713629U;
			object obj2 = num8 & (int)num10;
			num = (10276403U ^ num);
			uint num11 = num ^ 4041778315U;
			num = (2762433210U | num);
			if (obj2 <= num11)
			{
				goto IL_32F;
			}
			num = 2174992062U - num;
			if (num >= 3643853757U)
			{
				goto IL_14;
			}
			if (array != null)
			{
				object[] array4 = array;
				num *= 4196287513U;
				bool flag2 = array4[(int)(num - 3242910795U)];
				num += 866452080U;
				if (flag2)
				{
					goto IL_32F;
				}
				num += 2546200904U;
			}
			if (1627470108U / num == 0U)
			{
				break;
			}
			IL_A4:
			11AE0F91.833BF530 833BF4 = 833BF2;
			num = 780698264U + num;
			ushort num12 = (ushort)833BF4.50AB0933();
			num = (758566712U & num);
			num2 = num12;
			num = (4036226470U ^ num);
			if (959238838U >> (int)num == 0U)
			{
				goto IL_DE;
			}
			IL_52:
			11AE0F91.1280CA96 1280CA = 833BF2;
			11AE0F91.80068AA5 80068AA4 = 80068AA2;
			num = 681846152U * num;
			1280CA.37242F0A(80068AA4.30B7A98C());
			if (num > 1645969555U)
			{
				goto IL_A4;
			}
			11AE0F91.80068AA5 80068AA5 = 80068AA2;
			num >>= 3;
			num9 = 80068AA5.3BA55C01();
			num /= 682785317U;
			if (-2112699078 << (int)num != 0)
			{
				goto IL_A4;
			}
			goto IL_14;
		}
		throw new NullReferenceException();
		IL_32F:
		if (2022520505U <= num)
		{
			11AE0F91.833BF530 833BF2;
			11AE0F91.833BF530 833BF5 = 833BF2;
			num = 621856781U >> (int)num;
			833BF5.99BB76A6();
			num /= 2434911367U;
			num = 747186599U * num;
			11AE0F91 11AE0F = new 11AE0F91();
			num &= 1812844069U;
			object[] array;
			object[] 130BEFAB = array;
			num &= 1169281714U;
			int 8500EE3D = 833BF2.B395DB29();
			num <<= 23;
			object obj3 = 11AE0F.8ABE7489(130BEFAB, 8500EE3D);
			num = 1211138189U - num;
			object 9730DA = obj3;
			num = 2575635074U >> (int)num;
			Dictionary<int, 11AE0F91.80068AA5> dictionary;
			Dictionary<int, 11AE0F91.80068AA5>.Enumerator enumerator = dictionary.GetEnumerator();
			num |= 3625503136U;
			Dictionary<int, 11AE0F91.80068AA5>.Enumerator enumerator2 = enumerator;
			try
			{
				do
				{
					for (;;)
					{
						num <<= 20;
						if (num * 1438288016U != 0U)
						{
							num *= 1057875767U;
							bool flag3 = enumerator2.MoveNext();
							num ^= 2310850338U;
							if (!flag3)
							{
								break;
							}
						}
						num = 3861894790U;
						KeyValuePair<int, 11AE0F91.80068AA5> keyValuePair = enumerator2.Current;
						num = (2945663651U | num);
						num = 1870964381U % num;
						11AE0F91.80068AA5 value2 = keyValuePair.Value;
						num = 238558876U >> (int)num;
						object[] array5 = array;
						num *= 662860438U;
						int key2 = keyValuePair.Key;
						num /= 512049191U;
						object 9590F = array5[key2];
						num = 1663868800U * num;
						value2.7E869424(9590F);
						num ^= 3625766312U;
					}
				}
				while (num / 2537440425U == 0U);
			}
			finally
			{
				do
				{
					num = 1309724292U;
					((IDisposable)enumerator2).Dispose();
				}
				while (4054953992U - num == 0U);
			}
			int num7;
			while (num7 != 0)
			{
				Type type2;
				do
				{
					Type type = this.50932DAD(num7);
					num = 100665151U;
					type2 = type;
					num = 28859570U << (int)num;
				}
				while (num << 17 != 0U);
				Type left = type2;
				Type typeFromHandle = typeof(void);
				num = 4077556751U * num;
				bool flag4 = left != typeFromHandle;
				num = (2282830721U | num);
				if (!flag4)
				{
					break;
				}
				num = (640507432U | num);
				if (2066164737U < num)
				{
					11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
					11AE0F91.80068AA5 268B972E = 11AE0F91.80068AA5.872D5EA9(9730DA, type2);
					num -= 4103793285U;
					5F355D3D.07A52495(268B972E);
					break;
				}
			}
			return;
		}
		IL_14:
		11AE0F91.5F355D3D 5F355D3D2 = this.16011CAB;
		num = 4188418193U + num;
		11AE0F91.80068AA5 80068AA6 = 5F355D3D2.F3AC8C0D();
		num += 1160407727U;
		80068AA2 = 80068AA6;
		goto IL_34;
	}

	// Token: 0x060002E3 RID: 739 RVA: 0x00056C60 File Offset: 0x00054860
	private void 0DAF2509()
	{
		for (;;)
		{
			11AE0F91.80068AA5 80068AA = this.16011CAB.F3AC8C0D();
			uint num = 1890545320U;
			11AE0F91.80068AA5 c0991E9F = 80068AA;
			num = 588360349U % num;
			if ((num ^ 2302494652U) != 0U)
			{
				11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
				num = 3917783997U >> (int)num;
				11AE0F91.80068AA5 80068AA2 = 5F355D3D.F3AC8C0D();
				num = 2696085804U >> (int)num;
				if (3298673848U != num)
				{
					num = 328691628U - num;
					11AE0F91.5F355D3D 5F355D3D2 = this.16011CAB;
					11AE0F91.80068AA5 e6B2ED2E = 80068AA2;
					num &= 1142739363U;
					11AE0F91.80068AA5 268B972E = 11AE0F91.6A9A2996.D29D5A89(e6B2ED2E, c0991E9F);
					num >>= 0;
					5F355D3D2.07A52495(268B972E);
					if (2995091224U > num)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060002E4 RID: 740 RVA: 0x0005728C File Offset: 0x00054E8C
	private void 093ADD14()
	{
		uint num = 2343729813U;
		11AE0F91.80068AA5 0812228D;
		if (num >= 2310029364U)
		{
			do
			{
				11AE0F91.80068AA5 80068AA = this.16011CAB.F3AC8C0D();
				num *= 4062702979U;
				0812228D = 80068AA;
			}
			while (396028445U > num);
		}
		for (;;)
		{
			num &= 2688080684U;
			11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
			num >>= 16;
			11AE0F91.80068AA5 80068AA2 = 5F355D3D.F3AC8C0D();
			num = (4163268352U | num);
			11AE0F91.80068AA5 95266A = 80068AA2;
			if (1656723245U % num != 0U)
			{
				num = (2251986066U & num);
				11AE0F91.5F355D3D 5F355D3D2 = this.16011CAB;
				11AE0F91.80068AA5 268B972E = 11AE0F91.8A270C3B.5A235921(95266A, 0812228D);
				num = 4229921832U + num;
				5F355D3D2.07A52495(268B972E);
				if (num >= 1982762631U)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060002E5 RID: 741 RVA: 0x0005C520 File Offset: 0x0005A120
	private void 58150F83()
	{
		11AE0F91.80068AA5 80068AA = this.16011CAB.F3AC8C0D();
		uint num = 1018136065U;
		11AE0F91.80068AA5 80068AA2 = 80068AA;
		11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
		11AE0F91.80068AA5 f79EB = 80068AA2;
		num = (2017336074U & num);
		11AE0F91.80068AA5 268B972E = 11AE0F91.80068AA5.49072FA8(f79EB);
		num <<= 25;
		5F355D3D.07A52495(268B972E);
	}

	// Token: 0x060002E6 RID: 742 RVA: 0x0005742C File Offset: 0x0005502C
	private void AEBF8284()
	{
		uint num = 1394720262U;
		11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
		num *= 622890386U;
		11AE0F91.80068AA5 80068AA = 5F355D3D.F3AC8C0D();
		num -= 521414674U;
		11AE0F91.80068AA5 80068AA2 = 80068AA;
		num &= 69651740U;
		num *= 327886648U;
		11AE0F91.5F355D3D 5F355D3D2 = this.16011CAB;
		num = 507337530U * num;
		11AE0F91.80068AA5 80068AA3 = 5F355D3D2.F3AC8C0D();
		num /= 1744909104U;
		do
		{
			11AE0F91.5F355D3D 5F355D3D3 = this.16011CAB;
			num |= 4054025889U;
			11AE0F91.80068AA5 ca29A81C = 80068AA3;
			11AE0F91.80068AA5 2B3A = 80068AA2;
			num -= 1017469732U;
			11AE0F91.80068AA5 268B972E = 11AE0F91.8A270C3B.3B22901F(ca29A81C, 2B3A);
			num &= 1176698519U;
			5F355D3D3.07A52495(268B972E);
		}
		while (num + 4070142642U == 0U);
	}

	// Token: 0x060002E7 RID: 743 RVA: 0x0005706C File Offset: 0x00054C6C
	private void FDBC0105()
	{
		11AE0F91.80068AA5 80068AA = this.16011CAB.F3AC8C0D();
		uint num = 1278442023U;
		11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
		num = 741574971U - num;
		11AE0F91.80068AA5 80068AA2 = 5F355D3D.F3AC8C0D();
		num |= 1778798388U;
		11AE0F91.80068AA5 80068AA3 = 80068AA2;
		num -= 2737291781U;
		11AE0F91.5F355D3D 5F355D3D2 = this.16011CAB;
		11AE0F91.80068AA5 9FAB5F = 80068AA3;
		num += 3155923974U;
		11AE0F91.80068AA5 1DB = 80068AA;
		num = 1067810959U - num;
		5F355D3D2.07A52495(11AE0F91.7621E502.45966726(9FAB5F, 1DB));
	}

	// Token: 0x060002E8 RID: 744 RVA: 0x00057160 File Offset: 0x00054D60
	private void 712AC49C()
	{
		uint num = 1286710156U;
		num *= 3930042299U;
		11AE0F91.80068AA5 80068AA = this.16011CAB.F3AC8C0D();
		num = 1402352568U >> (int)num;
		11AE0F91.80068AA5 80068AA2 = 80068AA;
		num = 1124216097U >> (int)num;
		num = (907611052U & num);
		11AE0F91.80068AA5 80068AA3 = this.16011CAB.F3AC8C0D();
		num -= 482129045U;
		11AE0F91.80068AA5 80068AA4 = 80068AA3;
		11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
		11AE0F91.80068AA5 71AC249A = 80068AA4;
		num -= 1343726754U;
		11AE0F91.80068AA5 3092593C = 80068AA2;
		num = 3113400619U - num;
		5F355D3D.07A52495(11AE0F91.CB943E91.3195F2BC(71AC249A, 3092593C));
	}

	// Token: 0x060002E9 RID: 745 RVA: 0x0005B268 File Offset: 0x00058E68
	private void D78EBE0B()
	{
		uint num = 4078992915U;
		11AE0F91.80068AA5 80068AA = this.16011CAB.F3AC8C0D();
		num >>= 21;
		11AE0F91.80068AA5 80068AA2 = this.16011CAB.F3AC8C0D();
		num <<= 8;
		11AE0F91.80068AA5 80068AA3 = 80068AA2;
		if (num < 3308609817U)
		{
			num += 2066346931U;
			11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
			num = 2132950402U / num;
			11AE0F91.80068AA5 d70FBB = 80068AA3;
			num = 3938343088U / num;
			11AE0F91.80068AA5 11344B3D = 80068AA;
			num >>= 28;
			11AE0F91.80068AA5 268B972E = 11AE0F91.6A9A2996.1E2BD10B(d70FBB, 11344B3D);
			num = 1580370219U << (int)num;
			5F355D3D.07A52495(268B972E);
		}
	}

	// Token: 0x060002EA RID: 746 RVA: 0x00056880 File Offset: 0x00054480
	private void CA3A9E35()
	{
		uint num;
		do
		{
			11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
			num = 2653059230U;
			11AE0F91.80068AA5 80068AA = 5F355D3D.F3AC8C0D();
			num ^= 2896880015U;
			11AE0F91.5F355D3D 5F355D3D2 = this.16011CAB;
			num += 3884087684U;
			int e99A = 80068AA.3BA55C01();
			num = (1586351415U & num);
			5F355D3D2.07A52495(new 11AE0F91.CB943E91(e99A));
		}
		while (num > 1208033451U);
	}

	// Token: 0x060002EB RID: 747 RVA: 0x00058708 File Offset: 0x00056308
	private void 8220A112()
	{
		uint num = 2021660462U;
		11AE0F91.80068AA5 80068AA = this.16011CAB.F3AC8C0D();
		num = 2483514U / num;
		11AE0F91.80068AA5 80068AA2 = 80068AA;
		11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
		num <<= 17;
		11AE0F91.80068AA5 80068AA3 = 80068AA2;
		11AE0F91.80068AA5 80068AA4 = 80068AA2;
		num -= 1572841393U;
		Type 31130EB = 80068AA4.20129380();
		num = (781841721U ^ num);
		11AE0F91.80068AA5 268B972E = 80068AA3.01245B13(31130EB);
		num = (2097464244U ^ num);
		5F355D3D.07A52495(268B972E);
	}

	// Token: 0x060002EC RID: 748 RVA: 0x0005B6E4 File Offset: 0x000592E4
	private void FA2F4684()
	{
		uint num = 3072895668U;
		if (604152883U >= num)
		{
			goto IL_3F;
		}
		Type type;
		do
		{
			IL_11:
			num = (1478115721U & num);
			11AE0F91.833BF530 833BF = this.4FA4D617;
			num = (2116950172U | num);
			type = this.50932DAD(833BF.99BB76A6());
		}
		while ((num ^ 1075226042U) == 0U);
		IL_3F:
		11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
		num = 2133447814U << (int)num;
		11AE0F91.80068AA5 80068AA = 5F355D3D.F3AC8C0D();
		if (4194856633U == num)
		{
			goto IL_11;
		}
		num *= 2618001799U;
		11AE0F91.5F355D3D 5F355D3D2 = this.16011CAB;
		num = 3835214602U * num;
		object obj = 5F355D3D2.F3AC8C0D().D697DB31();
		num = (1295710736U ^ num);
		Array array = obj as Array;
		num &= 3291869880U;
		Array array2 = array;
		if (num % 2124509078U == 0U)
		{
			goto IL_11;
		}
		if (array2 == null)
		{
			throw new ArgumentException();
		}
		do
		{
			num *= 429431860U;
			num = 1479745087U / num;
			11AE0F91.5F355D3D 5F355D3D3 = this.16011CAB;
			Array array3 = array2;
			num %= 394962837U;
			11AE0F91.80068AA5 80068AA2 = 80068AA;
			num *= 763711395U;
			object value = array3.GetValue(80068AA2.30B7A98C());
			num = (2871599386U & num);
			Type 4A3DAA3A = type;
			num /= 1303625600U;
			11AE0F91.80068AA5 268B972E = 11AE0F91.80068AA5.872D5EA9(value, 4A3DAA3A);
			num -= 1043088030U;
			5F355D3D3.07A52495(268B972E);
		}
		while (4052832829U <= num);
	}

	// Token: 0x060002ED RID: 749 RVA: 0x00056CFC File Offset: 0x000548FC
	private void 89163288()
	{
		uint num = 1244392464U;
		if (1879455530U % num == 0U)
		{
			goto IL_2E;
		}
		IL_12:
		num = 3860322830U / num;
		11AE0F91.80068AA5 c72C723E = this.16011CAB.F3AC8C0D();
		num = 1814255124U - num;
		IL_2E:
		num = (1337351982U & num);
		11AE0F91.80068AA5 80068AA = this.16011CAB.F3AC8C0D();
		num = (360731941U ^ num);
		if (822646030U + num == 0U)
		{
			goto IL_12;
		}
		num <<= 1;
		11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
		11AE0F91.80068AA5 f93E = 80068AA;
		num = 2559092777U / num;
		5F355D3D.07A52495(11AE0F91.8A270C3B.DC82EF39(f93E, c72C723E));
		if (2837432757U > num)
		{
			return;
		}
		goto IL_12;
	}

	// Token: 0x060002EE RID: 750 RVA: 0x000563D8 File Offset: 0x00053FD8
	private void C8089F07()
	{
		uint num = 2525620371U;
		11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
		num = (3567496363U | num);
		int e99A = this.4FA4D617.99BB76A6();
		num &= 3088583708U;
		5F355D3D.07A52495(new 11AE0F91.CB943E91(e99A));
	}

	// Token: 0x060002EF RID: 751 RVA: 0x00057B90 File Offset: 0x00055790
	private void 3F1DE48B()
	{
		uint num = 1663127448U;
		11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
		num = 1914060803U >> (int)num;
		11AE0F91.80068AA5 80068AA = 5F355D3D.F3AC8C0D();
		num = 1563750541U % num;
		11AE0F91.80068AA5 5891ED = 80068AA;
		num = 1150039436U + num;
		do
		{
			num = 4045333013U + num;
			11AE0F91.5F355D3D 5F355D3D2 = this.16011CAB;
			num = (765292959U ^ num);
			11AE0F91.80068AA5 268B972E = 11AE0F91.4422B13D.E50C09B0(5891ED);
			num = 3683098680U + num;
			5F355D3D2.07A52495(268B972E);
		}
		while (3047971735U > num);
	}

	// Token: 0x060002F0 RID: 752 RVA: 0x00057D80 File Offset: 0x00055980
	private void E514B901()
	{
		uint num = 1695196335U;
		do
		{
			11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
			num = 999020717U * num;
			11AE0F91.80068AA5 b1254E = 5F355D3D.F3AC8C0D();
			if (num >= 2879704857U)
			{
				break;
			}
			num %= 788600631U;
			this.16011CAB.07A52495(11AE0F91.122C9D2C.390D87B2(b1254E));
		}
		while (2586959630U == num);
	}

	// Token: 0x060002F1 RID: 753 RVA: 0x00055318 File Offset: 0x00052F18
	private unsafe object 2C82EC16(int 6B33559F)
	{
		uint num = 649066250U;
		if (6B33559F == 0)
		{
			return null;
		}
		num = (3322346813U & num);
		Dictionary<uint, object> a314EB = 11AE0F91.A314EB83;
		num &= 2977988748U;
		Dictionary<uint, object> dictionary = a314EB;
		bool flag = num + 4294934520U != 0U;
		object result;
		try
		{
			if (num / 3347638168U == 0U)
			{
				goto IL_40;
			}
			uint key;
			object obj;
			string text;
			byte[] array2;
			for (;;)
			{
				IL_A7:
				bool flag2 = 11AE0F91.A314EB83.TryGetValue(key, out obj);
				num /= 2056824997U;
				if (flag2)
				{
					break;
				}
				num -= 3518096179U;
				if (1317582730U > num)
				{
					num = (689438754U ^ num);
					IntPtr value = 0F35EF88.88B78B84((uint)6B33559F);
					num -= 51494667U;
					byte* ptr = (byte*)((void*)value);
					num <<= 21;
					uint num2 = num ^ 2962916653U;
					num = 1881099405U % num;
					uint num3 = num2;
					num = 2568018691U / num;
					if ((490344738U ^ num) == 0U)
					{
						goto IL_40;
					}
					int num4 = *(int*)ptr;
					num *= 1896406933U;
					int num5 = num4 ^ (int)num3;
					num %= 4146511763U;
					if (num > 2872457137U)
					{
						goto IL_40;
					}
					bool flag3 = num5 != 0;
					num = (2243469982U & num);
					if (!flag3)
					{
						if (num == 1964618781U)
						{
							goto IL_74;
						}
						string empty = string.Empty;
						num = 2318793748U % num;
						text = empty;
						if (3507479559U * num != 0U)
						{
							goto Block_11;
						}
					}
					else
					{
						ptr += (num ^ 17334928U);
						num = 4160799656U >> (int)num;
						if (1253456415U < num)
						{
							goto IL_40;
						}
						int num6 = num5;
						num &= 2116602803U;
						byte[] array = new byte[num6];
						num = 1394202669U + num;
						array2 = array;
						num &= 3993234189U;
						int num7 = (int)(num ^ 1107419917U);
						num = 3095874726U >> (int)num;
						int num8 = num7;
						if (915741213U <= num)
						{
							goto IL_74;
						}
						for (;;)
						{
							int num9 = num8;
							num += 2687428629U;
							if (num9 >= num5)
							{
								break;
							}
							byte[] array3 = array2;
							int num10 = num8;
							int num11 = ptr;
							num = 809006993U;
							byte b = *(num11 + num8);
							uint num12 = num3;
							num |= 1622936460U;
							uint num13 = num8;
							num = 2343057290U % num;
							int num14 = num13 & num + 3843311666U;
							num &= 3063974842U;
							byte b2 = num12 << num14;
							num = 3199277461U / num;
							uint num15 = num3;
							num &= 1261753367U;
							uint num16 = (num ^ 34U) - (uint)num8;
							num *= 1587644442U;
							int num17 = num16 & (num ^ 3175288875U);
							num &= 1166273054U;
							byte b3 = num15 >> num17;
							num -= 1446527237U;
							byte b4 = b ^ (b2 | b3);
							num |= 1604352651U;
							array3[num10] = b4;
							num *= 2533693886U;
							if (num > 1226501050U)
							{
								goto IL_74;
							}
							int num18 = num8;
							num >>= 21;
							int num19 = num18 + (int)(num ^ 464U);
							num = 3744361527U << (int)num;
							num8 = num19;
							num += 664257594U;
						}
						num <<= 19;
						if (2436092567U % num != 0U)
						{
							goto Block_16;
						}
					}
				}
			}
			result = obj;
			if (1085248798U != num)
			{
				return result;
			}
			goto IL_40;
			Block_11:
			goto IL_353;
			Block_16:
			Encoding utf = Encoding.UTF8;
			byte[] bytes = array2;
			num = (3045917586U & num);
			string @string = utf.GetString(bytes);
			num = 272209931U - num;
			text = @string;
			num += 278433061U;
			IL_353:
			11AE0F91.A314EB83.Add(key, text);
			if (num < 3087282443U)
			{
				object result2 = text;
				num |= 2123257112U;
				return result2;
			}
			IL_40:
			object obj2 = dictionary;
			num = (3795486223U | num);
			num &= 4092185U;
			Monitor.Enter(obj2, ref flag);
			num = 2125172644U / num;
			if (93941684U * num == 0U)
			{
				goto IL_A7;
			}
			IL_74:
			num = (3794572053U | num);
			uint num20 = num ^ 1647088447U;
			num |= 3709914260U;
			uint num21 = (uint)(6B33559F | (int)num20);
			num += 440332545U;
			key = num21;
			num = 616053786U + num;
			goto IL_A7;
		}
		finally
		{
			bool flag4 = flag;
			num = 4068609049U;
			if (!flag4)
			{
				goto IL_3A7;
			}
			num /= 2484234662U;
			IL_396:
			Monitor.Exit(dictionary);
			num += 4068609048U;
			IL_3A7:
			if (num * 2679516435U == 0U)
			{
				goto IL_396;
			}
		}
		return result;
	}

	// Token: 0x060002F2 RID: 754 RVA: 0x000571E4 File Offset: 0x00054DE4
	private void EDA983B7()
	{
		uint num = 1167430305U;
		11AE0F91.80068AA5 93BE21A;
		if (num - 2133411843U != 0U)
		{
			do
			{
				num |= 2281730477U;
				11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
				num = (2729294255U | num);
				93BE21A = 5F355D3D.F3AC8C0D();
			}
			while (1980823185U >= num);
		}
		num = (380381346U & num);
		11AE0F91.5F355D3D 5F355D3D2 = this.16011CAB;
		num = (3568780183U ^ num);
		11AE0F91.80068AA5 80068AA = 5F355D3D2.F3AC8C0D();
		num %= 2478664715U;
		11AE0F91.80068AA5 80068AA2 = 80068AA;
		do
		{
			num = 2864302518U + num;
			11AE0F91.5F355D3D 5F355D3D3 = this.16011CAB;
			num <<= 22;
			11AE0F91.80068AA5 263CD = 80068AA2;
			num = 3280621454U * num;
			11AE0F91.80068AA5 268B972E = 11AE0F91.6A9A2996.05197C0C(263CD, 93BE21A);
			num ^= 588373637U;
			5F355D3D3.07A52495(268B972E);
		}
		while (num + 1882044054U == 0U);
	}

	// Token: 0x060002F3 RID: 755 RVA: 0x0005651C File Offset: 0x0005411C
	private void 22843BA6()
	{
		uint num = 3786004098U;
		num -= 839482627U;
		11AE0F91.833BF530 833BF = this.4FA4D617;
		num ^= 311668494U;
		int 6B33559F = 833BF.99BB76A6();
		num *= 1804314529U;
		object obj = this.2C82EC16(6B33559F);
		num = 20680375U * num;
		object obj2 = obj;
		num ^= 1713265333U;
		11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
		object 8237D7A = obj2;
		num -= 2990409731U;
		11AE0F91.80068AA5 268B972E = new 11AE0F91.1C16CD2C(8237D7A);
		num = 3154474U + num;
		5F355D3D.07A52495(268B972E);
	}

	// Token: 0x060002F4 RID: 756 RVA: 0x00056768 File Offset: 0x00054368
	private void 0C0392BB()
	{
		11AE0F91.80068AA5 b5B = this.16011CAB.F3AC8C0D();
		uint num = 1485686427U;
		11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
		num = 3205083838U / num;
		11AE0F91.80068AA5 80068AA = 5F355D3D.F3AC8C0D();
		num /= 1024859174U;
		11AE0F91.80068AA5 80068AA2 = 80068AA;
		num = 4020179457U >> (int)num;
		if (num + 1672904220U != 0U)
		{
			do
			{
				11AE0F91.5F355D3D 5F355D3D2 = this.16011CAB;
				num <<= 31;
				11AE0F91.80068AA5 2B2EEDA = 80068AA2;
				num = 1276792726U - num;
				5F355D3D2.07A52495(11AE0F91.7621E502.790434B9(2B2EEDA, b5B));
			}
			while (1143742U == num);
		}
	}

	// Token: 0x060002F5 RID: 757 RVA: 0x00057E2C File Offset: 0x00055A2C
	private void ED399CB1()
	{
		uint num = 925998603U;
		Type type;
		Dictionary<object, DynamicMethod> dictionary;
		if (num <= 2889796759U)
		{
			num |= 3332545556U;
			type = this.50932DAD(this.4FA4D617.99BB76A6());
			num /= 2745233691U;
			Dictionary<object, DynamicMethod> a2896C2E = 11AE0F91.A2896C2E;
			num |= 2601628804U;
			dictionary = a2896C2E;
		}
		bool flag = num - 2601628805U != 0U;
		DynamicMethod dynamicMethod;
		try
		{
			num = 504390917U * num;
			if (num >= 3274072993U)
			{
				object obj = dictionary;
				num >>= 16;
				num = 1753786904U >> (int)num;
				Monitor.Enter(obj, ref flag);
				num = 530815881U * num;
				if (num != 1536975635U)
				{
					do
					{
						Dictionary<object, DynamicMethod> a2896C2E2 = 11AE0F91.A2896C2E;
						object key = type;
						num = (3568971812U ^ num);
						if (a2896C2E2.TryGetValue(key, out dynamicMethod))
						{
							goto IL_168;
						}
					}
					while ((1521780658U ^ num) == 0U);
					string name = "";
					num = 2713186819U + num;
					Type typeFromHandle = typeof(int);
					num |= 3424127234U;
					Type[] parameterTypes = null;
					num -= 2961307451U;
					RuntimeTypeHandle handle = typeof(11AE0F91).TypeHandle;
					num = (4012032535U & num);
					Module module = Type.GetTypeFromHandle(handle).Module;
					bool skipVisibility = (num ^ 788709893U) != 0U;
					num &= 697993876U;
					dynamicMethod = new DynamicMethod(name, typeFromHandle, parameterTypes, module, skipVisibility);
				}
			}
			DynamicMethod dynamicMethod2 = dynamicMethod;
			num &= 680624905U;
			ILGenerator ilgenerator = dynamicMethod2.GetILGenerator();
			OpCode @sizeof = OpCodes.Sizeof;
			num = (121125002U | num);
			Type cls = type;
			num ^= 3875563162U;
			ilgenerator.Emit(@sizeof, cls);
			OpCode ret = OpCodes.Ret;
			num = 294034726U + num;
			ilgenerator.Emit(ret);
			Dictionary<object, DynamicMethod> a2896C2E3 = 11AE0F91.A2896C2E;
			num &= 1418816955U;
			object key2 = type;
			num = 1295322163U * num;
			a2896C2E3.Add(key2, dynamicMethod);
			num ^= 2661151242U;
			IL_168:;
		}
		finally
		{
			do
			{
				num = 69087270U;
				if (flag)
				{
					num >>= 20;
					Monitor.Exit(dictionary);
					num += 69087205U;
				}
			}
			while (496957877U < num);
		}
		num = 353587353U;
		11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
		MethodBase methodBase = dynamicMethod;
		num <<= 7;
		object obj2 = null;
		object[] parameters = null;
		num = (2148208957U | num);
		object obj3 = methodBase.Invoke(obj2, parameters);
		num %= 2945477909U;
		int e99A = (int)obj3;
		num = 84753808U << (int)num;
		5F355D3D.07A52495(new 11AE0F91.CB943E91(e99A));
	}

	// Token: 0x060002F6 RID: 758 RVA: 0x00056668 File Offset: 0x00054268
	private void 39A40BB7()
	{
		uint num = 2988607678U;
		11AE0F91.80068AA5 80068AA = this.16011CAB.F3AC8C0D();
		num += 2593991057U;
		11AE0F91.80068AA5 3D2F802E = 80068AA;
		num >>= 11;
		11AE0F91.80068AA5 80068AA2 = this.16011CAB.F3AC8C0D();
		if (3883930891U > num)
		{
			num >>= 15;
			11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
			num /= 1606216490U;
			11AE0F91.80068AA5 ebb2F = 80068AA2;
			num >>= 16;
			5F355D3D.07A52495(11AE0F91.6A9A2996.1126E12A(ebb2F, 3D2F802E));
		}
	}

	// Token: 0x060002F7 RID: 759 RVA: 0x0005803C File Offset: 0x00055C3C
	private void A430E9BA()
	{
		for (;;)
		{
			uint num = 2058827144U;
			Type type = this.50932DAD(this.4FA4D617.99BB76A6());
			num = 1888146344U - num;
			if (237846787U >> (int)num == 0U)
			{
				goto IL_59;
			}
			11AE0F91.80068AA5 80068AA = this.16011CAB.F3AC8C0D();
			num = 3105958458U * num;
			if (!80068AA.FC990F28())
			{
				num += 730066992U;
				goto IL_59;
			}
			IL_8C:
			num &= 36341919U;
			if (3282064136U < num)
			{
				continue;
			}
			11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
			11AE0F91.80068AA5 80068AA2 = 80068AA;
			num <<= 9;
			Type 31130EB = type;
			num &= 329119538U;
			5F355D3D.07A52495(80068AA2.01245B13(31130EB));
			if (num / 2142310329U == 0U)
			{
				break;
			}
			continue;
			IL_59:
			IntPtr f79C96A = 80068AA.D20542BB();
			num = 2609744769U >> (int)num;
			Type 820612B = type;
			num = 1589534619U / num;
			11AE0F91.80068AA5 80068AA3 = new 11AE0F91.92167A27(f79C96A, 820612B);
			num >>= 21;
			80068AA = 80068AA3;
			num += 3959624512U;
			goto IL_8C;
		}
	}

	// Token: 0x060002F8 RID: 760 RVA: 0x0005ACB8 File Offset: 0x000588B8
	private void 2227AD16()
	{
		uint num = 3828004639U;
		MethodBase methodBase2;
		ParameterInfo[] parameters;
		Dictionary<int, 11AE0F91.80068AA5> dictionary2;
		object[] array2;
		do
		{
			num &= 1513398686U;
			num = 3205685386U / num;
			MethodBase methodBase = this.613B5197(this.4FA4D617.99BB76A6());
			num -= 3171429892U;
			methodBase2 = methodBase;
			if ((2813834882U ^ num) != 0U)
			{
				MethodBase methodBase3 = methodBase2;
				num <<= 18;
				parameters = methodBase3.GetParameters();
				num >>= 1;
			}
			Dictionary<int, 11AE0F91.80068AA5> dictionary = new Dictionary<int, 11AE0F91.80068AA5>();
			num %= 1931561008U;
			dictionary2 = dictionary;
			num = (2652599552U ^ num);
			int num2 = parameters.Length;
			num = 1437799557U << (int)num;
			int num3 = num2;
			num = 2408625805U - num;
			object[] array = new object[num3];
			num <<= 21;
			array2 = array;
			num = 3266176393U % num;
		}
		while (num + 830480422U == 0U);
		11AE0F91.B59F4436 b59F = new 11AE0F91.B59F4436();
		num = (1429997725U | num);
		11AE0F91.B59F4436 b59F2 = b59F;
		try
		{
			num = 1149486104U + num;
			object obj3;
			for (;;)
			{
				ParameterInfo[] array3 = parameters;
				num = (2108119730U & num);
				int num4 = array3.Length;
				num &= 2964192168U;
				int num5 = num4 - (int)(num ^ 268505249U);
				num >>= 19;
				int num6 = num5;
				if (2898227468U > num)
				{
					goto IL_114;
				}
				goto IL_15B;
				Type type;
				do
				{
					IL_119:
					ParameterInfo[] array4 = parameters;
					num = 1604355893U;
					int num7 = num6;
					num = (2055589157U | num);
					Type parameterType = array4[num7].ParameterType;
					num |= 1906913983U;
					type = parameterType;
					num = 1905181096U >> (int)num;
				}
				while (num + 3978588216U == 0U);
				IL_15B:
				11AE0F91.80068AA5 80068AA = this.16011CAB.F3AC8C0D();
				bool flag = 80068AA.FC990F28();
				num |= 3374220336U;
				if (!flag)
				{
					goto IL_21B;
				}
				Type type2 = type;
				num = (3767529094U & num);
				if (!type2.IsByRef)
				{
					num = 431455795U >> (int)num;
					object[] array5 = array2;
					int num8 = num6;
					num = 2670775169U + num;
					11AE0F91.B59F4436 b59F3 = b59F2;
					num <<= 7;
					object obj = b59F3.7C285EBA(80068AA.D697DB31());
					num = (3683899907U | num);
					array5[num8] = obj;
				}
				else
				{
					num |= 2921439805U;
					if (2441221039U != num)
					{
						Dictionary<int, 11AE0F91.80068AA5> dictionary3 = dictionary2;
						num ^= 740747404U;
						int key = num6;
						11AE0F91.80068AA5 value = 80068AA;
						num = 2461123617U * num;
						dictionary3[key] = value;
						num ^= 3033345249U;
						goto IL_21B;
					}
					continue;
				}
				IL_274:
				if (num > 4136144779U)
				{
					int num9 = num6;
					num = 3566914952U % num;
					num6 = num9 - (int)(num ^ 3566914953U);
					num ^= 3566915464U;
					goto IL_29F;
				}
				continue;
				IL_21B:
				if (num <= 4203736101U)
				{
					object[] array6 = array2;
					num >>= 25;
					int num10 = num6;
					11AE0F91.80068AA5 80068AA2 = 80068AA;
					num &= 2016047619U;
					Type 31130EB = type;
					num >>= 1;
					11AE0F91.80068AA5 80068AA3 = 80068AA2.01245B13(31130EB);
					num &= 2057340163U;
					object obj2 = 80068AA3.D697DB31();
					num = (2055403583U ^ num);
					array6[num10] = obj2;
					num += 2234835396U;
					goto IL_274;
				}
				goto IL_119;
				IL_29F:
				num >>= 31;
				if ((num ^ 2383891481U) != 0U)
				{
					int num11 = num6;
					num = 3139692442U << (int)num;
					uint num12 = num ^ 3139692442U;
					num -= 1184683554U;
					if (num11 >= num12)
					{
						goto IL_119;
					}
					num = 3171679289U * num;
					if (3315130927U <= num)
					{
						goto IL_119;
					}
					MethodBase methodBase4 = methodBase2;
					num = (1536379266U ^ num);
					obj3 = ((ConstructorInfo)methodBase4).Invoke(array2);
					if (num - 3675033659U != 0U)
					{
						break;
					}
					continue;
				}
				IL_114:
				goto IL_29F;
			}
			Dictionary<int, 11AE0F91.80068AA5> dictionary4 = dictionary2;
			num = 3574108213U / num;
			Dictionary<int, 11AE0F91.80068AA5>.Enumerator enumerator = dictionary4.GetEnumerator();
			num |= 1790286986U;
			Dictionary<int, 11AE0F91.80068AA5>.Enumerator enumerator2 = enumerator;
			try
			{
				if (num % 2133959192U == 0U)
				{
					goto IL_374;
				}
				IL_343:
				goto IL_3A8;
				IL_374:
				KeyValuePair<int, 11AE0F91.80068AA5> keyValuePair;
				11AE0F91.80068AA5 value2 = keyValuePair.Value;
				object[] array7 = array2;
				num ^= 251856537U;
				int key2 = keyValuePair.Key;
				num = 3742503614U * num;
				value2.7E869424(array7[key2]);
				num ^= 1646742916U;
				IL_3A8:
				num = (1848439835U & num);
				if (enumerator2.MoveNext())
				{
					num = 2785359270U;
					keyValuePair = enumerator2.Current;
					num = 4180939709U << (int)num;
					if (1999369865U > num)
					{
						goto IL_374;
					}
					goto IL_343;
				}
			}
			finally
			{
				do
				{
					num = 2989834137U;
					((IDisposable)enumerator2).Dispose();
				}
				while (2368064016U > num);
			}
			11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
			num = 222197172U;
			object 9730DA = obj3;
			num = 3617566478U / num;
			11AE0F91.80068AA5 268B972E = 11AE0F91.80068AA5.872D5EA9(9730DA, methodBase2.DeclaringType);
			num ^= 4004225714U;
			5F355D3D.07A52495(268B972E);
		}
		finally
		{
			num = 1136643887U;
			11AE0F91.B59F4436 b59F4 = b59F2;
			num = 2922284462U - num;
			b59F4.Dispose();
		}
	}

	// Token: 0x060002F9 RID: 761 RVA: 0x00056AC0 File Offset: 0x000546C0
	private void 9E8D6895()
	{
		uint num = 3749833629U;
		if (num >> 2 == 0U)
		{
			goto IL_42;
		}
		IL_12:
		num = 2820871852U / num;
		11AE0F91.80068AA5 80068AA = this.16011CAB.F3AC8C0D();
		num = 2604227753U << (int)num;
		11AE0F91.80068AA5 80068AA2 = 80068AA;
		num = 673793685U >> (int)num;
		IL_42:
		11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
		num &= 2996660363U;
		11AE0F91.80068AA5 80068AA3 = 5F355D3D.F3AC8C0D();
		num += 146096650U;
		11AE0F91.5F355D3D 5F355D3D2 = this.16011CAB;
		11AE0F91.80068AA5 ec83BAA = 80068AA3;
		num /= 898595613U;
		11AE0F91.80068AA5 daa7143A = 80068AA2;
		num = 1949440175U * num;
		11AE0F91.80068AA5 268B972E = 11AE0F91.7621E502.DF333B1F(ec83BAA, daa7143A);
		num = (1275311039U & num);
		5F355D3D2.07A52495(268B972E);
		if (num != 1612736017U)
		{
			return;
		}
		goto IL_12;
	}

	// Token: 0x060002FA RID: 762 RVA: 0x00056474 File Offset: 0x00054074
	private void A530FA28()
	{
		uint num = 898644786U;
		if ((3222597935U ^ num) != 0U)
		{
			do
			{
				11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
				num ^= 269058717U;
				11AE0F91.833BF530 833BF = this.4FA4D617;
				num = 1132462517U << (int)num;
				5F355D3D.07A52495(new 11AE0F91.7621E502(833BF.EC8194B9()));
			}
			while (num / 462567054U != 0U);
		}
	}

	// Token: 0x060002FB RID: 763 RVA: 0x00057C48 File Offset: 0x00055848
	private void 049343B2()
	{
		11AE0F91.80068AA5 80068AA = this.16011CAB.F3AC8C0D();
		uint num = 2719521802U;
		11AE0F91.80068AA5 80068AA2 = 80068AA;
		if (num != 1252411838U)
		{
			do
			{
				num >>= 22;
				11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
				11AE0F91.80068AA5 ef3D = 80068AA2;
				num = 1753548458U + num;
				11AE0F91.80068AA5 268B972E = 11AE0F91.39A8C69A.362B2039(ef3D);
				num = (3657696150U ^ num);
				5F355D3D.07A52495(268B972E);
			}
			while (1329439881U > num);
		}
	}

	// Token: 0x060002FC RID: 764 RVA: 0x0005BCA8 File Offset: 0x000598A8
	private void F61F83A8()
	{
		this.16011CAB.F3AC8C0D();
	}

	// Token: 0x060002FD RID: 765 RVA: 0x0005B200 File Offset: 0x00058E00
	private void 002924BC()
	{
		11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
		uint num = 4055561627U;
		11AE0F91.80068AA5 80068AA = 5F355D3D.F3AC8C0D();
		11AE0F91.80068AA5 80068AA3;
		do
		{
			11AE0F91.80068AA5 80068AA2 = this.16011CAB.F3AC8C0D();
			num = 866126365U << (int)num;
			80068AA3 = 80068AA2;
			num = 421735998U + num;
		}
		while (1319879059U == num);
		11AE0F91.5F355D3D 5F355D3D2 = this.16011CAB;
		11AE0F91.80068AA5 693B5EA = 80068AA3;
		11AE0F91.80068AA5 2186702E = 80068AA;
		num = (1997637047U ^ num);
		5F355D3D2.07A52495(11AE0F91.CB943E91.041A47B4(693B5EA, 2186702E));
	}

	// Token: 0x060002FE RID: 766 RVA: 0x0005BFA8 File Offset: 0x00059BA8
	private void 62AE5307()
	{
		uint num;
		do
		{
			num = 1370268174U;
			if (this.70BBF99F == null)
			{
				if (num % 2509283614U == 0U)
				{
					continue;
				}
			}
			else
			{
				num = (1840672809U | num);
				if (2686014621U - num != 0U)
				{
					goto Block_2;
				}
			}
			num -= 1082229931U;
			11AE0F91.833BF530 833BF = this.4FA4D617;
			num ^= 245706790U;
			833BF.73A4C02F();
		}
		while (1169117317 << (int)num == 0);
		return;
		Block_2:
		this.5F16AE85();
	}

	// Token: 0x060002FF RID: 767 RVA: 0x0005B430 File Offset: 0x00059030
	private void 8FB9EF9F()
	{
		11AE0F91.80068AA5 3C32D3BE = this.16011CAB.F3AC8C0D();
		uint num = 1686562623U;
		11AE0F91.80068AA5 6E;
		do
		{
			11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
			num -= 1444427139U;
			11AE0F91.80068AA5 80068AA = 5F355D3D.F3AC8C0D();
			num = 2351072403U + num;
			6E = 80068AA;
			num = 856552979U * num;
		}
		while (num <= 2092956834U);
		11AE0F91.5F355D3D 5F355D3D2 = this.16011CAB;
		num = (1579658792U | num);
		5F355D3D2.07A52495(11AE0F91.122C9D2C.FE86852D(6E, 3C32D3BE));
	}

	// Token: 0x06000300 RID: 768 RVA: 0x00057688 File Offset: 0x00055288
	private void B0337393()
	{
		uint num = 445037201U;
		11AE0F91.80068AA5 e1BEE;
		if (832663358U > num)
		{
			11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
			num %= 1403407237U;
			e1BEE = 5F355D3D.F3AC8C0D();
			num = (3357509943U ^ num);
		}
		11AE0F91.80068AA5 80068AA = this.16011CAB.F3AC8C0D();
		11AE0F91.5F355D3D 5F355D3D2 = this.16011CAB;
		num ^= 2906095535U;
		11AE0F91.80068AA5 d92C293C = 80068AA;
		num += 3121669423U;
		5F355D3D2.07A52495(11AE0F91.8A270C3B.A50D6222(d92C293C, e1BEE));
	}

	// Token: 0x06000301 RID: 769 RVA: 0x00057950 File Offset: 0x00055550
	private void F980998C()
	{
		uint num = 3048263092U;
		11AE0F91.80068AA5 80068AA = this.16011CAB.F3AC8C0D();
		num = 177263398U - num;
		11AE0F91.80068AA5 41B799B = 80068AA;
		if (698515730U < num)
		{
			11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
			num = 1988543766U / num;
			11AE0F91.80068AA5 268B972E = 11AE0F91.CB943E91.3B302122(41B799B);
			num = (3129903902U & num);
			5F355D3D.07A52495(268B972E);
		}
	}

	// Token: 0x06000302 RID: 770 RVA: 0x0005C43C File Offset: 0x0005A03C
	private void 201A9D35()
	{
		bool flag = this.70BBF99F != null;
		uint num = 3565490315U;
		if (flag)
		{
			num = 3374659598U + num;
			if (num > 1403849645U)
			{
				num <<= 23;
				throw this.70BBF99F;
			}
		}
		throw new InvalidOperationException();
	}

	// Token: 0x06000303 RID: 771 RVA: 0x00059ECC File Offset: 0x00057ACC
	private void DBA82680()
	{
		uint num;
		for (;;)
		{
			num = 3745134129U;
			11AE0F91.4F0A3DA2 4F0A3DA = this.01336239(this.4FA4D617.99BB76A6());
			num = 2290377004U << (int)num;
			11AE0F91.4F0A3DA2 4F0A3DA2 = 4F0A3DA;
			num = 1185692847U << (int)num;
			Type[] array2;
			Type[] array4;
			for (;;)
			{
				11AE0F91.4F0A3DA2 4F0A3DA3 = 4F0A3DA2;
				num >>= 24;
				if (!4F0A3DA3.11AF2ABB)
				{
					break;
				}
				do
				{
					num = 876111039U >> (int)num;
					BindingFlags bindingFlags = (BindingFlags)(num ^ 13689234U);
					num ^= 3181574426U;
					Type[] array = 4F0A3DA2.2D850224();
					num = (3205202107U ^ num);
					array2 = array;
					num = 2862634044U / num;
					Type[] array3 = array2;
					num *= 4054054016U;
					int num2 = array3.Length;
					num -= 4119440441U;
					int num3 = num2;
					int num4 = (int)(num ^ 973292998U);
					num |= 2126113410U;
					int num5 = num3 + num4;
					num = 2310762783U % num;
					array4 = new Type[num5];
				}
				while (num == 641097662U);
				Array array5 = array2;
				num = 3484291002U << (int)num;
				Array array6 = array4;
				num = 4053154958U / num;
				int index = (int)(num ^ 1U);
				num -= 4196404517U;
				array5.CopyTo(array6, index);
				num -= 2964892189U;
				if ((3272267149U ^ num) != 0U)
				{
					goto Block_3;
				}
			}
			if ((num ^ 1923363987U) != 0U)
			{
				break;
			}
			continue;
			Block_3:
			array4[array2.Length] = typeof(IntPtr);
			Type[] array7 = array4;
			num += 665085624U;
			int num6 = array7.Length;
			num = (1083919282U | num);
			object[] array8 = new object[num6];
			if (2486105269U != num)
			{
				Dictionary<int, 11AE0F91.80068AA5> dictionary = new Dictionary<int, 11AE0F91.80068AA5>();
				num = 3970920374U - num;
				if (num + 1628239890U != 0U)
				{
					goto Block_5;
				}
			}
		}
		throw new ArgumentException();
		Block_5:
		11AE0F91.B59F4436 b59F = new 11AE0F91.B59F4436();
		num = 3163362312U << (int)num;
		11AE0F91.B59F4436 b59F2 = b59F;
		try
		{
			num |= 3971760153U;
			Type[] array4;
			object[] array8;
			Dictionary<int, 11AE0F91.80068AA5> dictionary;
			for (;;)
			{
				IL_1AF:
				object[] array9 = array8;
				num -= 335828098U;
				int num7 = array9.Length;
				num = 28626308U + num;
				int num8 = num7 - (int)(num - 3664558362U);
				if (num > 2919772600U)
				{
					for (;;)
					{
						IL_1DE:
						for (;;)
						{
							num = 345285398U >> (int)num;
							uint num9 = (uint)num8;
							num = 4220209595U << (int)num;
							if (num9 < num - 3995936492U)
							{
								goto Block_13;
							}
							num = 3107012264U;
							Type type;
							if ((num & 2400655255U) != 0U)
							{
								Type[] array10 = array4;
								int num10 = num8;
								num = (454203438U | num);
								type = array10[num10];
								if (num == 2444617619U)
								{
									goto IL_1AF;
								}
							}
							num *= 2466252694U;
							11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
							num %= 1830220834U;
							11AE0F91.80068AA5 80068AA = 5F355D3D.F3AC8C0D();
							for (;;)
							{
								11AE0F91.80068AA5 80068AA2 = 80068AA;
								num *= 806852793U;
								bool flag = 80068AA2.FC990F28();
								num &= 2240392221U;
								if (!flag)
								{
									goto IL_2D0;
								}
								bool isByRef = type.IsByRef;
								num = (2476312753U | num);
								if (isByRef)
								{
									num /= 3852040850U;
									Dictionary<int, 11AE0F91.80068AA5> dictionary2 = dictionary;
									int key = num8;
									11AE0F91.80068AA5 value = 80068AA;
									num = 615225919U + num;
									dictionary2[key] = value;
									num += 3696526805U;
									goto IL_2D0;
								}
								object[] array11 = array8;
								int num11 = num8;
								11AE0F91.B59F4436 b59F3 = b59F2;
								num /= 134618263U;
								IntPtr intPtr = b59F3.7C285EBA(80068AA.D697DB31());
								num &= 2780250624U;
								array11[num11] = intPtr;
								if (4162220572U <= num)
								{
									goto IL_1DE;
								}
								IL_315:
								num -= 3753398923U;
								if (1312226315U / num != 0U)
								{
									break;
								}
								continue;
								IL_2D0:
								num >>= 25;
								object[] array12 = array8;
								num &= 1511126059U;
								int num12 = num8;
								11AE0F91.80068AA5 80068AA3 = 80068AA;
								Type 31130EB = type;
								num %= 2359077637U;
								11AE0F91.80068AA5 80068AA4 = 80068AA3.01245B13(31130EB);
								num *= 2081218205U;
								array12[num12] = 80068AA4.D697DB31();
								num ^= 0U;
								goto IL_315;
							}
							int num13 = num8;
							num = (1838718398U | num);
							int num14 = (int)(num ^ 1843379710U);
							num ^= 2896871314U;
							num8 = num13 - num14;
							num ^= 454671222U;
						}
					}
				}
			}
			Block_13:
			num &= 2768434107U;
			Dictionary<object, DynamicMethod> a2896C2E = 11AE0F91.A2896C2E;
			num = 649319227U + num;
			Dictionary<object, DynamicMethod> dictionary3 = a2896C2E;
			num /= 2099333508U;
			bool flag2 = (num ^ 1U) != 0U;
			11AE0F91.4F0A3DA2 4F0A3DA2;
			DynamicMethod dynamicMethod;
			try
			{
				num &= 3842338307U;
				if ((3381981759U ^ num) == 0U)
				{
					goto IL_415;
				}
				IL_3CB:
				object obj = dictionary3;
				num = 3155884811U >> (int)num;
				Monitor.Enter(obj, ref flag2);
				IL_3E4:
				Dictionary<object, DynamicMethod> a2896C2E2 = 11AE0F91.A2896C2E;
				object key2 = 4F0A3DA2;
				num ^= 2583755918U;
				bool flag3 = a2896C2E2.TryGetValue(key2, out dynamicMethod);
				num /= 2234534421U;
				if (flag3)
				{
					goto IL_62F;
				}
				num = 4060972217U * num;
				IL_415:
				string name = "";
				Type left = 4F0A3DA2.300483B6;
				RuntimeTypeHandle handle = typeof(void).TypeHandle;
				num = 537880610U >> (int)num;
				Type typeFromHandle = Type.GetTypeFromHandle(handle);
				num >>= 22;
				Type returnType;
				if (!(left != typeFromHandle))
				{
					returnType = null;
				}
				else
				{
					returnType = 4F0A3DA2.300483B6;
					num += 0U;
				}
				Type[] parameterTypes = array4;
				RuntimeTypeHandle handle2 = typeof(11AE0F91).TypeHandle;
				num *= 3180887054U;
				dynamicMethod = new DynamicMethod(name, returnType, parameterTypes, Type.GetTypeFromHandle(handle2).Module, (num ^ 1U) != 0U);
				num = 2277189523U >> (int)num;
				if (num >> 20 == 0U)
				{
					goto IL_3CB;
				}
				ILGenerator ilgenerator2;
				for (;;)
				{
					DynamicMethod dynamicMethod2 = dynamicMethod;
					num >>= 18;
					ILGenerator ilgenerator = dynamicMethod2.GetILGenerator();
					num *= 1074401201U;
					ilgenerator2 = ilgenerator;
					int num15 = (int)(num ^ 3579864974U);
					if (num <= 152074884U)
					{
						goto IL_3CB;
					}
					for (;;)
					{
						num = 3692264633U - num;
						if (1385363329U % num == 0U)
						{
							goto IL_3E4;
						}
						int num16 = num15;
						num >>= 22;
						Type[] array13 = array4;
						num /= 1670986004U;
						int num17 = array13.Length;
						num = (3105669512U & num);
						if (num16 >= num17)
						{
							num = (2048566200U ^ num);
							if (2066821022U > num)
							{
								goto Block_27;
							}
						}
						ILGenerator ilgenerator3 = ilgenerator2;
						Dictionary<int, 11AE0F91.80068AA5> dictionary4 = dictionary;
						num = 1471011859U;
						OpCode opcode;
						if (!dictionary4.ContainsKey(num15))
						{
							opcode = OpCodes.Ldarg;
						}
						else
						{
							opcode = OpCodes.Ldarga;
							num ^= 0U;
						}
						ilgenerator3.Emit(opcode, num15);
						num += 1326677284U;
						if ((3146004109U ^ num) == 0U)
						{
							break;
						}
						int num18 = num15 + (int)(num ^ 2797689142U);
						num ^= 874024213U;
						num15 = num18;
						num ^= 1203352492U;
					}
				}
				Block_27:
				ILGenerator ilgenerator4 = ilgenerator2;
				num = 640174345U / num;
				OpCode calli = OpCodes.Calli;
				num = 2771307305U - num;
				11AE0F91.4F0A3DA2 4F0A3DA4 = 4F0A3DA2;
				num -= 3518744848U;
				CallingConvention unmanagedCallConv = 4F0A3DA4.9D1F5603;
				11AE0F91.4F0A3DA2 4F0A3DA5 = 4F0A3DA2;
				num = 2268080654U * num;
				Type[] array2;
				ilgenerator4.EmitCalli(calli, unmanagedCallConv, 4F0A3DA5.300483B6, array2);
				ILGenerator ilgenerator5 = ilgenerator2;
				num += 387924612U;
				ilgenerator5.Emit(OpCodes.Ret);
				num ^= 1225554830U;
				Dictionary<object, DynamicMethod> a2896C2E3 = 11AE0F91.A2896C2E;
				num -= 121308461U;
				object key3 = 4F0A3DA2;
				num |= 2970763906U;
				a2896C2E3.Add(key3, dynamicMethod);
				num ^= 4183031742U;
				IL_62F:;
			}
			finally
			{
				num = 3468605452U;
				bool flag4 = flag2;
				num ^= 1083786675U;
				if (!flag4)
				{
					goto IL_678;
				}
				num = 2047215530U >> (int)num;
				if (num == 775808050U)
				{
					goto IL_678;
				}
				IL_667:
				Monitor.Exit(dictionary3);
				num += 2384985535U;
				IL_678:
				if (num << 18 == 0U)
				{
					goto IL_667;
				}
			}
			MethodBase methodBase = dynamicMethod;
			num = 974674229U;
			object obj2 = null;
			BindingFlags bindingFlags;
			BindingFlags invokeAttr = bindingFlags;
			Binder binder = null;
			object[] parameters = array8;
			num /= 1572178439U;
			object obj3 = methodBase.Invoke(obj2, invokeAttr, binder, parameters, null);
			num ^= 3459813033U;
			object obj4 = obj3;
			num *= 4221996094U;
			Dictionary<int, 11AE0F91.80068AA5> dictionary5 = dictionary;
			num = 345344924U << (int)num;
			using (Dictionary<int, 11AE0F91.80068AA5>.Enumerator enumerator = dictionary5.GetEnumerator())
			{
				if (num / 319705239U == 0U)
				{
					goto IL_6E5;
				}
				IL_6E0:
				goto IL_739;
				IL_6E5:
				KeyValuePair<int, 11AE0F91.80068AA5> keyValuePair = enumerator.Current;
				num = 2780793242U;
				11AE0F91.80068AA5 value2 = keyValuePair.Value;
				num = (4112953140U & num);
				object[] array14 = array8;
				num = 2183567896U << (int)num;
				num *= 1200769686U;
				value2.7E869424(array14[keyValuePair.Key]);
				num ^= 1492582400U;
				IL_739:
				num = (876084259U | num);
				if (num % 3098531871U == 0U)
				{
					goto IL_6E0;
				}
				num >>= 19;
				if (enumerator.MoveNext())
				{
					goto IL_6E5;
				}
			}
			do
			{
				11AE0F91.4F0A3DA2 4F0A3DA6 = 4F0A3DA2;
				num = 2132488068U;
				Type left2 = 4F0A3DA6.300483B6;
				num %= 3123857283U;
				bool flag5 = left2 != typeof(void);
				num = 380303510U - num;
				if (flag5)
				{
					num = 37320883U << (int)num;
					if (num >> 28 != 0U)
					{
						num = 1536079527U >> (int)num;
						11AE0F91.5F355D3D 5F355D3D2 = this.16011CAB;
						num %= 1569017866U;
						object 9730DA = obj4;
						num <<= 22;
						5F355D3D2.07A52495(11AE0F91.80068AA5.872D5EA9(9730DA, 4F0A3DA2.300483B6));
						num ^= 1045416210U;
					}
				}
			}
			while ((1303470230U & num) == 0U);
		}
		finally
		{
			b59F2.Dispose();
		}
	}

	// Token: 0x06000304 RID: 772 RVA: 0x00056228 File Offset: 0x00053E28
	private void 1214FC83()
	{
		uint num = 689011894U;
		short fe154B;
		11AE0F91.80068AA5 80068AA2;
		for (;;)
		{
			11AE0F91.833BF530 833BF = this.4FA4D617;
			num = 3440691496U / num;
			short num2 = 833BF.50AB0933();
			num %= 1694952749U;
			fe154B = num2;
			num = 772710712U + num;
			Type type2;
			if (num + 1829179275U != 0U)
			{
				num *= 730843026U;
				11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
				num = (4237124880U & num);
				Type type = this.50932DAD(5F355D3D.F3AC8C0D().30B7A98C());
				num = 4261950873U * num;
				type2 = type;
				num = (3249204768U & num);
				goto IL_6D;
			}
			IL_81:
			num *= 337698733U;
			11AE0F91.80068AA5 80068AA = this.16011CAB.F3AC8C0D();
			num >>= 31;
			80068AA2 = 80068AA;
			num = (967029525U ^ num);
			11AE0F91.80068AA5 80068AA3 = 80068AA2;
			num = 2592178610U - num;
			object obj = 80068AA3.D697DB31();
			num = (774376085U | num);
			if (num <= 1652688054U)
			{
				continue;
			}
			bool flag = obj != null;
			num %= 3895471232U;
			if (!flag)
			{
				if ((1168696352U & num) == 0U)
				{
					goto IL_6D;
				}
				bool isValueType = type2.IsValueType;
				num ^= 3298484228U;
				num ^= 3298484228U;
				if (isValueType)
				{
					num = 2871643419U - num;
					Type type3 = type2;
					num = (1606097587U ^ num);
					object obj2 = Activator.CreateInstance(type3);
					num >>= 18;
					obj = obj2;
					num += 1862120889U;
				}
			}
			object 9730DA = obj;
			Type 4A3DAA3A = type2;
			num = 1217270324U + num;
			80068AA2 = 11AE0F91.80068AA5.872D5EA9(9730DA, 4A3DAA3A);
			11AE0F91.80068AA5 80068AA4;
			if (80068AA4.FC990F28())
			{
				num ^= 2151234968U;
				11AE0F91.80068AA5 a23F9F = 80068AA2;
				num %= 2962833816U;
				11AE0F91.80068AA5 3221CAA = 80068AA4;
				num = 967690301U / num;
				11AE0F91.80068AA5 80068AA5 = new 11AE0F91.2DBFD518(a23F9F, 3221CAA);
				num = 3599214866U * num;
				80068AA2 = 80068AA5;
				num += 3775150015U;
			}
			if (1058845880U <= num)
			{
				break;
			}
			continue;
			IL_6D:
			80068AA4 = this.16011CAB.F3AC8C0D();
			num = 654818865U / num;
			goto IL_81;
		}
		num <<= 20;
		11AE0F91.5F355D3D 5F355D3D2 = this.16011CAB;
		num = 2612359980U - num;
		5F355D3D2.5C817C1A((int)fe154B, 80068AA2);
	}

	// Token: 0x06000305 RID: 773 RVA: 0x000575E8 File Offset: 0x000551E8
	private void DE89C0B1()
	{
		uint num = 3004282792U;
		if (num > 4028567437U)
		{
			goto IL_38;
		}
		11AE0F91.80068AA5 80068AA;
		do
		{
			IL_11:
			11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
			num = 1417967774U + num;
			80068AA = 5F355D3D.F3AC8C0D();
			num &= 3641608587U;
		}
		while (3011957163U == num);
		IL_38:
		num = 898816563U << (int)num;
		11AE0F91.80068AA5 80068AA2 = this.16011CAB.F3AC8C0D();
		num |= 159666312U;
		if (num + 363788571U == 0U)
		{
			goto IL_11;
		}
		11AE0F91.5F355D3D 5F355D3D2 = this.16011CAB;
		11AE0F91.80068AA5 79102A = 80068AA2;
		11AE0F91.80068AA5 d2343DA = 80068AA;
		num &= 655252145U;
		11AE0F91.80068AA5 268B972E = 11AE0F91.6A9A2996.F6392A0C(79102A, d2343DA);
		num = 2350611080U / num;
		5F355D3D2.07A52495(268B972E);
		if (num != 27891859U)
		{
			return;
		}
		goto IL_11;
	}

	// Token: 0x06000306 RID: 774 RVA: 0x0005C560 File Offset: 0x0005A160
	private void 44982030()
	{
		11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
		uint num = 102165561U;
		IntPtr cb = 5F355D3D.F3AC8C0D().D20542BB();
		num = (262282641U & num);
		IntPtr intPtr = Marshal.AllocHGlobal(cb);
		num -= 2450412334U;
		IntPtr intPtr2 = intPtr;
		num = 2553906491U - num;
		if (1605058981U != num)
		{
			List<IntPtr> list = this.93160723;
			IntPtr item = intPtr2;
			num = 923593641U + num;
			list.Add(item);
			num /= 689548948U;
			11AE0F91.5F355D3D 5F355D3D2 = this.16011CAB;
			num = 4055592110U >> (int)num;
			IntPtr b68DCD = intPtr2;
			num = 1991569932U >> (int)num;
			11AE0F91.80068AA5 268B972E = new 11AE0F91.8A270C3B(b68DCD);
			num = 2688332054U + num;
			5F355D3D2.07A52495(268B972E);
		}
	}

	// Token: 0x06000307 RID: 775 RVA: 0x00056938 File Offset: 0x00054538
	private void 07B2F3A6()
	{
		uint num = 3426245566U;
		num |= 3116086403U;
		11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
		num ^= 1552623616U;
		11AE0F91.80068AA5 80068AA = 5F355D3D.F3AC8C0D();
		num /= 1384439979U;
		11AE0F91.80068AA5 80068AA2 = 80068AA;
		num |= 27403936U;
		11AE0F91.5F355D3D 5F355D3D2 = this.16011CAB;
		num -= 2685824808U;
		11AE0F91.80068AA5 80068AA3 = 5F355D3D2.F3AC8C0D();
		num = (3701216823U ^ num);
		11AE0F91.80068AA5 80068AA4 = 80068AA3;
		num = (1603367726U ^ num);
		num |= 2048950570U;
		11AE0F91.5F355D3D 5F355D3D3 = this.16011CAB;
		num <<= 28;
		11AE0F91.80068AA5 6B8D = 80068AA4;
		11AE0F91.80068AA5 f4A21B = 80068AA2;
		num >>= 7;
		11AE0F91.80068AA5 268B972E = 11AE0F91.CB943E91.69235B90(6B8D, f4A21B);
		num = (3727284376U ^ num);
		5F355D3D3.07A52495(268B972E);
	}

	// Token: 0x06000308 RID: 776 RVA: 0x000583F8 File Offset: 0x00055FF8
	private void B7A5FF1A()
	{
		for (;;)
		{
			uint num = 481569815U;
			11AE0F91.833BF530 833BF = this.4FA4D617;
			num |= 1949839526U;
			short num2 = 833BF.50AB0933();
			num = 2208235436U + num;
			num = (1613920561U ^ num);
			11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
			int 24058B = (int)num2;
			num |= 3349714490U;
			11AE0F91.80068AA5 80068AA = 5F355D3D.252E6C8E(24058B);
			num = 220673188U - num;
			11AE0F91.80068AA5 80068AA2 = 80068AA;
			if (965467795U % num == 0U || (80068AA2.FC990F28() && num <= 2141598616U))
			{
				break;
			}
			num += 2207020548U;
			if (3836934182U > num)
			{
				11AE0F91.5F355D3D 5F355D3D2 = this.16011CAB;
				11AE0F91.80068AA5 268B972E = new 11AE0F91.4E9D35B2(80068AA2);
				num += 3904100492U;
				5F355D3D2.07A52495(268B972E);
				if ((2710159768U & num) != 0U)
				{
					return;
				}
			}
		}
		throw new ArgumentException();
	}

	// Token: 0x06000309 RID: 777 RVA: 0x00057C04 File Offset: 0x00055804
	private void AABE0611()
	{
		uint num;
		do
		{
			11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
			num = 1084891821U;
			11AE0F91.80068AA5 97BC8C = 5F355D3D.F3AC8C0D();
			num *= 3501339325U;
			this.16011CAB.07A52495(11AE0F91.122C9D2C.1215CBB2(97BC8C));
		}
		while (2780532885U - num == 0U);
	}

	// Token: 0x0600030A RID: 778 RVA: 0x00057DD8 File Offset: 0x000559D8
	private void 30382632()
	{
		uint num;
		do
		{
			11AE0F91.80068AA5 80068AA = this.16011CAB.F3AC8C0D();
			num = 513164437U;
			11AE0F91.80068AA5 80068AA2 = 80068AA;
			num >>= 6;
			11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
			num >>= 22;
			11AE0F91.80068AA5 3C = 80068AA2;
			num /= 4181303215U;
			5F355D3D.07A52495(11AE0F91.122C9D2C.4FBA800B(3C));
		}
		while (num / 1973945987U != 0U);
	}

	// Token: 0x0600030B RID: 779 RVA: 0x0005B514 File Offset: 0x00059114
	private void FCA67381()
	{
		uint num = 2090355893U;
		int 9BA5622C = this.4FA4D617.99BB76A6();
		num = (697750555U | num);
		Type type = this.50932DAD(9BA5622C);
		if (554732167U / num == 0U)
		{
			num ^= 1890858940U;
			11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
			Type elementType = type;
			num = 3239672967U - num;
			11AE0F91.80068AA5 80068AA = this.16011CAB.F3AC8C0D();
			num = 3937440425U + num;
			object 8237D7A = Array.CreateInstance(elementType, 80068AA.30B7A98C());
			num <<= 9;
			11AE0F91.80068AA5 268B972E = new 11AE0F91.1C16CD2C(8237D7A);
			num &= 856340502U;
			5F355D3D.07A52495(268B972E);
		}
	}

	// Token: 0x0600030C RID: 780 RVA: 0x000565D0 File Offset: 0x000541D0
	private void 5787FF07()
	{
		uint num = 1296009655U;
		11AE0F91.80068AA5 80068AA2;
		11AE0F91.80068AA5 80068AA4;
		if (4120582927U >= num)
		{
			do
			{
				11AE0F91.80068AA5 80068AA = this.16011CAB.F3AC8C0D();
				num = 2593003547U * num;
				80068AA2 = 80068AA;
			}
			while (4139509823U * num == 0U);
			do
			{
				11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
				num %= 3934950696U;
				11AE0F91.80068AA5 80068AA3 = 5F355D3D.F3AC8C0D();
				num ^= 3408807719U;
				80068AA4 = 80068AA3;
			}
			while (num == 3707886120U);
		}
		11AE0F91.5F355D3D 5F355D3D2 = this.16011CAB;
		num = 347899789U * num;
		11AE0F91.80068AA5 <<EMPTY_NAME>> = 80068AA4;
		num = 2300918182U % num;
		11AE0F91.80068AA5 8E1F55A = 80068AA2;
		num = 1587356593U * num;
		11AE0F91.80068AA5 268B972E = 11AE0F91.CB943E91.1127EB82(<<EMPTY_NAME>>, 8E1F55A);
		num = (2494673061U ^ num);
		5F355D3D2.07A52495(268B972E);
	}

	// Token: 0x0600030D RID: 781 RVA: 0x00058384 File Offset: 0x00055F84
	private void 452387B5()
	{
		11AE0F91.80068AA5 80068AA;
		for (;;)
		{
			uint num = 3198564756U;
			11AE0F91.833BF530 833BF = this.4FA4D617;
			num = 2293348772U << (int)num;
			short num2 = 833BF.50AB0933();
			num = (201741625U ^ num);
			short 24058B = num2;
			if (num > 136218403U)
			{
				num = 1812222350U / num;
				80068AA = this.16011CAB.252E6C8E((int)24058B);
				if (2032008894U - num != 0U)
				{
					break;
				}
			}
		}
		this.16011CAB.07A52495(80068AA.ECAA59A1());
	}

	// Token: 0x0600030E RID: 782 RVA: 0x000566D8 File Offset: 0x000542D8
	private void 7F0E3C35()
	{
		uint num;
		do
		{
			11AE0F91.80068AA5 f68039A = this.16011CAB.F3AC8C0D();
			num = 2837700287U;
			11AE0F91.80068AA5 80068AA;
			if (num != 3568453002U)
			{
				num >>= 28;
				80068AA = this.16011CAB.F3AC8C0D();
				num = 161074339U >> (int)num;
				if (3987063599U == num)
				{
					continue;
				}
			}
			11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
			num = (3204680229U ^ num);
			11AE0F91.80068AA5 b = 80068AA;
			num = 2031261225U % num;
			11AE0F91.80068AA5 268B972E = 11AE0F91.8A270C3B.6CA30927(b, f68039A);
			num = 3624331906U + num;
			5F355D3D.07A52495(268B972E);
		}
		while (num >> 8 == 0U);
	}

	// Token: 0x0600030F RID: 783 RVA: 0x000574C0 File Offset: 0x000550C0
	private void AF3315A2()
	{
		uint num;
		do
		{
			num = 2334884481U;
			11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
			num = 1681585664U % num;
			11AE0F91.80068AA5 80068AA = 5F355D3D.F3AC8C0D();
			num = (378846780U ^ num);
			num = (1094693390U ^ num);
			11AE0F91.5F355D3D 5F355D3D2 = this.16011CAB;
			11AE0F91.80068AA5 0D911CBC = 80068AA;
			num = 1904250007U - num;
			5F355D3D2.07A52495(11AE0F91.7621E502.C523BC0D(0D911CBC));
		}
		while (num / 882305965U == 0U);
	}

	// Token: 0x06000310 RID: 784 RVA: 0x00055A28 File Offset: 0x00053628
	private 11AE0F91.4F0A3DA2 01336239(int 1BB9F88F)
	{
		Dictionary<uint, object> a314EB = 11AE0F91.A314EB83;
		uint num = 4163105308U;
		Dictionary<uint, object> dictionary = a314EB;
		num <<= 19;
		bool flag = (num ^ 2430599168U) != 0U;
		11AE0F91.4F0A3DA2 result;
		try
		{
			num = (109544579U & num);
			object obj2;
			for (;;)
			{
				object obj = dictionary;
				num = (4010606241U | num);
				Monitor.Enter(obj, ref flag);
				num |= 4261493173U;
				uint num2 = num ^ 3213754293U;
				num = 1721028494U / num;
				uint num3 = (uint)(1BB9F88F | (int)num2);
				num /= 4127351300U;
				uint num4 = num3;
				num += 1661533719U;
				if (1208823838U <= num)
				{
					11AE0F91.4F0A3DA2 4F0A3DA;
					for (;;)
					{
						Dictionary<uint, object> a314EB2 = 11AE0F91.A314EB83;
						uint key = num4;
						num = (1746305458U | num);
						num = (3619450126U & num);
						if (a314EB2.TryGetValue(key, out obj2))
						{
							num = (3759144605U & num);
							if ((3691913749U ^ num) != 0U)
							{
								goto Block_4;
							}
						}
						else
						{
							num %= 1854135834U;
							byte[] array = 11AE0F91.08BC110D.ResolveSignature(1BB9F88F);
							num <<= 10;
							byte[] array2 = array;
							num = 2721524745U * num;
							4F0A3DA = new 11AE0F91.4F0A3DA2();
							num = 2368801820U - num;
							11AE0F91.4F0A3DA2 4F0A3DA2 = 4F0A3DA;
							num |= 2056109845U;
							byte[] a2228B = array2;
							num = 1748437020U >> (int)num;
							4F0A3DA2.CB2E97A6(a2228B, 11AE0F91.08BC110D);
							num |= 2158097727U;
							if ((num ^ 546856960U) != 0U)
							{
								break;
							}
						}
					}
					Dictionary<uint, object> a314EB3 = 11AE0F91.A314EB83;
					num = (934572948U | num);
					uint key2 = num4;
					num &= 2385910062U;
					object value = 4F0A3DA;
					num >>= 9;
					a314EB3.Add(key2, value);
					num >>= 23;
					if (num <= 2559002168U)
					{
						result = 4F0A3DA;
						if (4177847818U >> (int)num != 0U)
						{
							goto Block_7;
						}
					}
				}
			}
			Block_4:
			object obj3 = obj2;
			num = (663049486U | num);
			11AE0F91.4F0A3DA2 4F0A3DA3 = (11AE0F91.4F0A3DA2)obj3;
			num = 1059415712U + num;
			result = 4F0A3DA3;
			Block_7:;
		}
		finally
		{
			bool flag2 = flag;
			num = 2040759591U;
			if (flag2)
			{
				object obj4 = dictionary;
				num *= 3474525712U;
				Monitor.Exit(obj4);
				num += 1683230903U;
			}
		}
		return result;
	}

	// Token: 0x06000311 RID: 785 RVA: 0x0005C3F8 File Offset: 0x00059FF8
	private void BE1E5493()
	{
		11AE0F91.80068AA5 80068AA = this.16011CAB.F3AC8C0D();
		uint num = 184839989U;
		object obj = 80068AA.D697DB31();
		num /= 193588256U;
		Exception ex = obj as Exception;
		if (ex == null)
		{
			num = 4136449935U + num;
			throw new ArgumentException();
		}
		throw ex;
	}

	// Token: 0x06000312 RID: 786 RVA: 0x0005C278 File Offset: 0x00059E78
	private void 458B70A4()
	{
		uint num;
		MemberInfo memberInfo2;
		for (;;)
		{
			IL_00:
			num = 4181636256U;
			int num2 = this.4FA4D617.99BB76A6();
			num >>= 18;
			if (num <= 1570401301U)
			{
				for (;;)
				{
					int e58000BA = num2;
					num = (69396277U & num);
					MemberInfo memberInfo = this.68B43D97(e58000BA);
					num ^= 271128499U;
					memberInfo2 = memberInfo;
					num += 1150502294U;
					if (656366252U == num)
					{
						goto IL_00;
					}
					if (memberInfo2 is Type)
					{
						goto Block_1;
					}
					if (num - 3584306874U != 0U)
					{
						bool flag = memberInfo2 is MethodBase;
						num = 3230706621U % num;
						if (flag)
						{
							goto Block_3;
						}
						bool flag2 = memberInfo2 is FieldInfo;
						num = (1937982472U & num);
						if (flag2)
						{
							break;
						}
						if (3473993605U > num)
						{
							goto Block_6;
						}
					}
				}
				if (1913037746U >> (int)num != 0U)
				{
					goto Block_5;
				}
			}
		}
		Block_1:
		11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
		num = 1737696643U + num;
		Type type = (Type)memberInfo2;
		num = (815727505U | num);
		RuntimeTypeHandle typeHandle = type.TypeHandle;
		num ^= 2870227712U;
		11AE0F91.80068AA5 268B972E = new 11AE0F91.1718F939(typeHandle);
		num = 1572441728U - num;
		5F355D3D.07A52495(268B972E);
		return;
		Block_3:
		11AE0F91.5F355D3D 5F355D3D2 = this.16011CAB;
		num -= 708047109U;
		MemberInfo memberInfo3 = memberInfo2;
		num = 2250295056U >> (int)num;
		MethodBase methodBase = (MethodBase)memberInfo3;
		num = (1787500673U & num);
		RuntimeMethodHandle methodHandle = methodBase.MethodHandle;
		num = 3927067167U % num;
		11AE0F91.80068AA5 268B972E2 = new 11AE0F91.1718F939(methodHandle);
		num *= 1092307120U;
		5F355D3D2.07A52495(268B972E2);
		return;
		Block_5:
		num = 1796714424U - num;
		11AE0F91.5F355D3D 5F355D3D3 = this.16011CAB;
		FieldInfo fieldInfo = (FieldInfo)memberInfo2;
		num = (1997177778U & num);
		5F355D3D3.07A52495(new 11AE0F91.1718F939(fieldInfo.FieldHandle));
		return;
		Block_6:
		throw new InvalidOperationException();
	}

	// Token: 0x06000313 RID: 787 RVA: 0x000569D0 File Offset: 0x000545D0
	private void 5C22D991()
	{
		uint num;
		11AE0F91.80068AA5 80068AA2;
		do
		{
			11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
			num = 3963118377U;
			11AE0F91.80068AA5 80068AA = 5F355D3D.F3AC8C0D();
			num = (170732816U | num);
			80068AA2 = 80068AA;
		}
		while (889918891U > num);
		11AE0F91.5F355D3D 5F355D3D2 = this.16011CAB;
		num = 1630765630U / num;
		11AE0F91.80068AA5 80068AA3 = 5F355D3D2.F3AC8C0D();
		num <<= 10;
		11AE0F91.5F355D3D 5F355D3D3 = this.16011CAB;
		11AE0F91.80068AA5 618E = 80068AA3;
		11AE0F91.80068AA5 c03B5E8B = 80068AA2;
		num %= 1434479773U;
		5F355D3D3.07A52495(11AE0F91.6A9A2996.8C9F8D33(618E, c03B5E8B));
	}

	// Token: 0x06000314 RID: 788 RVA: 0x00055BF8 File Offset: 0x000537F8
	private void 5F16AE85()
	{
		uint num;
		11AE0F91.628F1DA3 628F1DA2;
		for (;;)
		{
			IL_00:
			num = 590999178U;
			this.16011CAB.0D034593();
			num <<= 5;
			for (;;)
			{
				IL_1C:
				this.4FA4D617.B03F07A7();
				if ((num ^ 4205710857U) != 0U)
				{
					for (;;)
					{
						num -= 2636556432U;
						if (1748690954U * num != 0U)
						{
							num <<= 25;
							bool flag = this.620F8223.21AF50A3() != 0;
							num *= 3250430653U;
							if (!flag)
							{
								goto Block_26;
							}
							goto IL_39;
						}
						IL_5C:
						num = (1748519818U & num);
						List<11AE0F91.628F1DA3> list2;
						int num3;
						if (this.FE3CF238 != null)
						{
							List<11AE0F91.628F1DA3> list = list2;
							num = 808496692U << (int)num;
							num /= 1798434078U;
							11AE0F91.628F1DA3 fe3CF = this.FE3CF238;
							num *= 1352904327U;
							int num2 = list.IndexOf(fe3CF);
							num = 3273265587U - num;
							num3 = num2 + (int)(num - 1920361259U);
						}
						else
						{
							num3 = (int)(num ^ 1210600330U);
							num ^= 979249318U;
						}
						num &= 239045908U;
						11AE0F91.628F1DA3 fe3CF2 = null;
						num = 3267340035U % num;
						this.FE3CF238 = fe3CF2;
						num = (3003975701U ^ num);
						int num4 = num3;
						if (num + 1032290450U != 0U)
						{
							for (;;)
							{
								num = 4180815162U / num;
								int num5 = num4;
								num = 3383679632U + num;
								int count = list2.Count;
								num = (1169561497U & num);
								if (num5 >= count)
								{
									break;
								}
								num = 891692686U;
								List<11AE0F91.628F1DA3> list3 = list2;
								int index = num4;
								num /= 1723092015U;
								11AE0F91.628F1DA3 628F1DA = list3[index];
								num = 607418513U << (int)num;
								628F1DA2 = 628F1DA;
								num ^= 2628650901U;
								if (num - 2978427786U == 0U)
								{
									goto IL_1C;
								}
								byte b = 628F1DA2.DB0E7732();
								if (4261826713U == num)
								{
									goto IL_00;
								}
								if (b != 0)
								{
									num = 1729063580U % num;
									if (num > 2635914545U)
									{
										goto IL_39;
									}
									byte b2 = b;
									num = 4286890509U - num;
									uint num6 = num ^ 2557826928U;
									num >>= 6;
									if (b2 == num6)
									{
										goto IL_302;
									}
								}
								else
								{
									num /= 1712429825U;
									Exception ex = this.70BBF99F;
									num = 2226662951U << (int)num;
									Type type = ex.GetType();
									num = (1989590547U | num);
									Type type2 = type;
									num = 3768112154U >> (int)num;
									if (2167716285U + num == 0U)
									{
										goto IL_1C;
									}
									num = (396123791U ^ num);
									int 9BA5622C = 628F1DA2.BF1FDE10();
									num = (3827288704U | num);
									Type type3 = this.50932DAD(9BA5622C);
									Type left = type2;
									num -= 4035294259U;
									Type right = type3;
									num += 538008576U;
									if (left == right)
									{
										goto IL_265;
									}
									num /= 2845953720U;
									Type type4 = type2;
									num <<= 27;
									bool flag2 = type4.IsSubclassOf(type3);
									num ^= 39966045U;
									if (flag2)
									{
										goto Block_10;
									}
								}
								num = 2788519607U + num;
								if (2224019479U * num == 0U)
								{
									goto IL_00;
								}
								num4 += (int)(num ^ 2828485653U);
								num += 176882082U;
							}
							num = 95602337U % num;
							num *= 2787067451U;
							11AE0F91.6B1722AF 6B1722AF = this.620F8223;
							num = 1652834820U - num;
							6B1722AF.181C1CA4();
							num -= 4028360969U;
							if (num == 3389408678U)
							{
								goto IL_00;
							}
							List<11AE0F91.628F1DA3> list4 = list2;
							num >>= 23;
							int num7 = list4.Count;
							for (;;)
							{
								int num8 = num7;
								num = 2083298094U % num;
								uint num9 = num ^ 318U;
								num = 422791102U % num;
								if (num8 <= num9)
								{
									break;
								}
								List<11AE0F91.628F1DA3> list5 = list2;
								num = 2559427483U;
								11AE0F91.628F1DA3 628F1DA3 = list5[num7 - (int)(num ^ 2559427482U)];
								num /= 2005988513U;
								11AE0F91.628F1DA3 628F1DA4 = 628F1DA3;
								11AE0F91.628F1DA3 628F1DA5 = 628F1DA4;
								num = 2654774076U << (int)num;
								uint num10 = (uint)628F1DA5.DB0E7732();
								num = 4130987395U * num;
								if (num10 == num + 1533237402U)
								{
									goto IL_4FB;
								}
								if (2466829363U >= num)
								{
									goto IL_00;
								}
								11AE0F91.628F1DA3 628F1DA6 = 628F1DA4;
								num ^= 3826435260U;
								byte b3 = 628F1DA6.DB0E7732();
								num |= 2962519715U;
								uint num11 = num - 4036917235U;
								num = 1639541384U << (int)num;
								if (b3 == num11)
								{
									num += 1620879208U;
									goto IL_4FB;
								}
								IL_541:
								if (3316473097U >= num)
								{
									int num12 = num7;
									num &= 2929314715U;
									int num13 = (int)(num - 67108863U);
									num = 2474887335U - num;
									num7 = num12 - num13;
									num += 1887189233U;
									continue;
								}
								goto IL_00;
								IL_4FB:
								if (2998611246U + num != 0U)
								{
									num = 1510919809U / num;
									11AE0F91.833BF530 833BF = this.4FA4D617;
									11AE0F91.628F1DA3 628F1DA7 = 628F1DA4;
									num = (4077904782U | num);
									int 1C850D8A = 628F1DA7.1393F713();
									num -= 201747105U;
									833BF.F43AFA0C(1C850D8A);
									num += 1559660307U;
									goto IL_541;
								}
								goto IL_1C;
							}
							if (num - 3231305483U == 0U)
							{
								goto IL_00;
							}
							bool flag3 = this.4FA4D617.1B80EDB7() != 0;
							num ^= 1732104628U;
							if (flag3)
							{
								goto Block_24;
							}
							continue;
							IL_265:
							if (3275728425U > num)
							{
								break;
							}
							goto IL_39;
							Block_10:
							num += 617197822U;
							goto IL_265;
						}
						goto IL_1C;
						IL_39:
						11AE0F91.6B1722AF 6B1722AF2 = this.620F8223;
						num = 204477586U;
						List<11AE0F91.628F1DA3> list6 = 6B1722AF2.0E82BAB5().3B1EF53A();
						num ^= 1150938936U;
						list2 = list6;
						goto IL_5C;
					}
					num >>= 27;
					11AE0F91.6B1722AF 6B1722AF3 = this.620F8223;
					num = 2198523565U * num;
					6B1722AF3.181C1CA4();
					num -= 76943146U;
					num -= 1132773678U;
					11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
					num = (967554964U ^ num);
					object 8237D7A = this.70BBF99F;
					num = 547874484U * num;
					5F355D3D.07A52495(new 11AE0F91.1C16CD2C(8237D7A));
					num = 2995701292U % num;
					if (num >= 1395636383U)
					{
						goto Block_12;
					}
					continue;
					IL_302:
					num >>= 18;
					11AE0F91.628F1DA3 fe3CF3 = 628F1DA2;
					num = 3760764730U - num;
					this.FE3CF238 = fe3CF3;
					num <<= 7;
					if (num <= 3191782446U)
					{
						goto Block_13;
					}
				}
			}
		}
		Block_12:
		num ^= 688277181U;
		this.4FA4D617.37242F0A(628F1DA2.1393F713());
		return;
		Block_13:
		11AE0F91.5F355D3D 5F355D3D2 = this.16011CAB;
		num &= 1108353959U;
		object 8237D7A2 = this.70BBF99F;
		num = 279076105U * num;
		11AE0F91.80068AA5 268B972E = new 11AE0F91.1C16CD2C(8237D7A2);
		num /= 3768027395U;
		5F355D3D2.07A52495(268B972E);
		num &= 2626645802U;
		num |= 3468534076U;
		11AE0F91.1280CA96 1280CA = this.4FA4D617;
		num = 3833707037U - num;
		11AE0F91.628F1DA3 628F1DA8 = 628F1DA2;
		num |= 1848090772U;
		int 301C73A = 628F1DA8.BF1FDE10();
		num &= 1544536849U;
		1280CA.37242F0A(301C73A);
		return;
		Block_24:
		11AE0F91.833BF530 833BF2 = this.4FA4D617;
		num = 45865128U - num;
		833BF2.73A4C02F();
		return;
		Block_26:
		num = 1394868158U * num;
		throw this.70BBF99F;
	}

	// Token: 0x06000315 RID: 789 RVA: 0x000568D8 File Offset: 0x000544D8
	private void 9009AF06()
	{
		uint num = 3040769062U;
		int c7A9131D;
		if ((num ^ 982694708U) != 0U)
		{
			11AE0F91.833BF530 833BF = this.4FA4D617;
			num = 1572289935U + num;
			int num2 = (int)833BF.23A12822();
			num -= 1452703023U;
			c7A9131D = num2;
			num %= 478530492U;
			if (num == 1765243433U)
			{
				return;
			}
		}
		this.16011CAB.8827D009().3F831A1B(c7A9131D);
	}

	// Token: 0x06000316 RID: 790 RVA: 0x00057328 File Offset: 0x00054F28
	private void 52A1932E()
	{
		uint num;
		11AE0F91.80068AA5 9BB5A19A;
		11AE0F91.80068AA5 6E0C1F;
		do
		{
			11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
			num = 2257668239U;
			11AE0F91.80068AA5 80068AA = 5F355D3D.F3AC8C0D();
			num >>= 20;
			9BB5A19A = 80068AA;
			num = 1955983664U - num;
			num &= 448206382U;
			6E0C1F = this.16011CAB.F3AC8C0D();
		}
		while (1610843396U == num);
		do
		{
			num = 314494128U << (int)num;
			11AE0F91.5F355D3D 5F355D3D2 = this.16011CAB;
			11AE0F91.80068AA5 268B972E = 11AE0F91.CB943E91.CF0D6F0C(6E0C1F, 9BB5A19A);
			num += 1586028077U;
			5F355D3D2.07A52495(268B972E);
		}
		while (num >> 2 == 0U);
	}

	// Token: 0x06000317 RID: 791 RVA: 0x000577E8 File Offset: 0x000553E8
	private void CB96929A()
	{
		uint num = 3683022110U;
		11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
		num = (3207682583U & num);
		11AE0F91.80068AA5 80068AA = 5F355D3D.F3AC8C0D();
		num = 1545861051U + num;
		do
		{
			num = (948910006U & num);
			11AE0F91.5F355D3D 5F355D3D2 = this.16011CAB;
			num /= 4103309966U;
			11AE0F91.80068AA5 80068AA2 = 5F355D3D2.F3AC8C0D();
			num += 60525312U;
			11AE0F91.80068AA5 80068AA3 = 80068AA2;
			num = 3131759648U - num;
			num ^= 2436786948U;
			11AE0F91.5F355D3D 5F355D3D3 = this.16011CAB;
			num = 1611968546U - num;
			11AE0F91.80068AA5 012C = 80068AA3;
			num = 2745035907U >> (int)num;
			11AE0F91.80068AA5 e4996BBB = 80068AA;
			num %= 3088346043U;
			11AE0F91.80068AA5 268B972E = 11AE0F91.8A270C3B.CF1BAB34(012C, e4996BBB);
			num <<= 7;
			5F355D3D3.07A52495(268B972E);
		}
		while ((num ^ 547855410U) == 0U);
	}

	// Token: 0x06000318 RID: 792 RVA: 0x0005B984 File Offset: 0x00059584
	private void F5BDCEB1()
	{
		uint num = 522662947U;
		if (num != 723509815U)
		{
			goto IL_11;
		}
		goto IL_58;
		object obj2;
		do
		{
			IL_2C:
			object obj = this.16011CAB.F3AC8C0D().D697DB31();
			num = 2283551873U >> (int)num;
			obj2 = obj;
		}
		while (1882832401U * num == 0U);
		IL_58:
		MethodBase methodBase;
		while (obj2 != null)
		{
			num = (1747531179U | num);
			Type type = obj2.GetType();
			num = (456395299U ^ num);
			Type type2 = type;
			if (num >> 26 != 0U)
			{
				Type declaringType = methodBase.DeclaringType;
				ParameterInfo[] parameters = methodBase.GetParameters();
				int num2 = parameters.Length;
				num = 3483398559U << (int)num;
				Type[] array = new Type[num2];
				num = 1161618956U % num;
				Type[] array2 = array;
				int num3 = (int)(num ^ 1161618956U);
				num -= 2829355141U;
				ParameterInfo[] array3 = parameters;
				num = (615636742U ^ num);
				int num4 = (int)(num + 1205239167U);
				for (;;)
				{
					num = 799841817U + num;
					if (num < 1417696660U)
					{
						goto IL_11;
					}
					int num5 = num4;
					num = 1873411605U + num;
					int num6 = array3.Length;
					num -= 4072250293U;
					int num7 = num6;
					num -= 2785599648U;
					if (num5 >= num7)
					{
						break;
					}
					ParameterInfo parameterInfo = array3[num4];
					num = 2494796087U;
					if (num == 2903142327U)
					{
						goto IL_2C;
					}
					Type[] array4 = array2;
					num *= 3543599527U;
					int num8 = num3;
					num |= 1922556562U;
					int num9 = (int)(num ^ 4221561842U);
					num = 1757386934U - num;
					int num10 = num8 + num9;
					num %= 2243037481U;
					num3 = num10;
					array4[num8] = parameterInfo.ParameterType;
					if (486718086U >= num)
					{
						goto IL_2C;
					}
					int num11 = num4;
					int num12 = (int)(num + 2464174910U);
					num = (186702848U | num);
					int num13 = num11 + num12;
					num = 1034390568U + num;
					num4 = num13;
					num ^= 349047402U;
				}
				while (1426983075U <= num)
				{
					Type left = type2;
					num ^= 765404059U;
					bool flag = left != null;
					num = 3833666871U - num;
					num += 2929812626U;
					if (!flag)
					{
						goto IL_2DD;
					}
					num = 1782457902U / num;
					if (423040399U < num)
					{
						goto IL_58;
					}
					bool flag2 = type2 != declaringType;
					num <<= 9;
					if (!flag2)
					{
						num += 1886811656U;
						goto IL_2DD;
					}
					Type type3 = type2;
					MemberInfo memberInfo = methodBase;
					num = 2611572507U;
					string name = memberInfo.Name;
					num &= 707863698U;
					BindingFlags bindingAttr = (BindingFlags)(num ^ 169874468U);
					num = 2938276224U << (int)num;
					Binder binder = null;
					num = 1266775944U + num;
					CallingConventions callConvention = (CallingConventions)(num ^ 1904310155U);
					num &= 3449907487U;
					Type[] types = array2;
					ParameterModifier[] modifiers = null;
					num |= 1119003928U;
					MethodInfo method = type3.GetMethod(name, bindingAttr, binder, callConvention, types, modifiers);
					num -= 1916550579U;
					MethodInfo left2 = method;
					num *= 1411346069U;
					MethodInfo right = null;
					num &= 3665938857U;
					if (left2 != right)
					{
						num = 2022413367U >> (int)num;
						if ((3246518418U ^ num) == 0U)
						{
							break;
						}
						bool flag3 = method.GetBaseDefinition() == methodBase;
						num ^= 2562491459U;
						if (flag3)
						{
							MethodBase methodBase2 = method;
							num = 2862592395U * num;
							methodBase = methodBase2;
							num ^= 30396011U;
							goto IL_2DD;
						}
					}
					num <<= 9;
					Type type4 = type2;
					num = (545668911U & num);
					Type baseType = type4.BaseType;
					num = (2065658114U ^ num);
					type2 = baseType;
					num ^= 3307258200U;
				}
				goto IL_11;
			}
			goto IL_2C;
		}
		IL_2DD:
		num = 1043786298U * num;
		num *= 2015921725U;
		11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
		num = (496420669U & num);
		MethodBase 3916BE9F = methodBase;
		num >>= 2;
		11AE0F91.80068AA5 268B972E = new 11AE0F91.AEB82B22(3916BE9F);
		num = (45772719U | num);
		5F355D3D.07A52495(268B972E);
		return;
		IL_11:
		num = (79020959U ^ num);
		methodBase = this.613B5197(this.4FA4D617.99BB76A6());
		goto IL_2C;
	}

	// Token: 0x06000319 RID: 793 RVA: 0x00058768 File Offset: 0x00056368
	private void E0194BA5()
	{
		uint num = 134520360U;
		for (;;)
		{
			num /= 4038837770U;
			11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
			num = (3434538775U | num);
			11AE0F91.80068AA5 80068AA = 5F355D3D.F3AC8C0D();
			for (;;)
			{
				11AE0F91.80068AA5 80068AA2 = 80068AA;
				num = 236243765U * num;
				int num2 = 80068AA2.30B7A98C();
				num = 4239779331U >> (int)num;
				MethodBase methodBase2;
				int num4;
				Type[] array;
				ParameterInfo[] array2;
				if (num < 1947533441U)
				{
					int 16BDA8B = num2;
					num ^= 4064246291U;
					MethodBase methodBase = this.613B5197(16BDA8B);
					num *= 486687001U;
					methodBase2 = methodBase;
					if (num <= 2199074451U)
					{
						break;
					}
					int num3 = 80068AA.3BA55C01();
					num = 3617462790U - num;
					num4 = num3;
					if (2803075115U >> (int)num == 0U)
					{
						break;
					}
					MethodBase methodBase3 = methodBase2;
					num &= 3079667606U;
					CallingConventions callingConvention = methodBase3.CallingConvention;
					num = 2989748245U - num;
					uint num5 = num - 2695615505U;
					num >>= 4;
					if (callingConvention == num5)
					{
						if ((num ^ 1789198779U) == 0U)
						{
							break;
						}
						11AE0F91.4F0A3DA2 4F0A3DA = this.01336239(num2);
						bool flag = 4F0A3DA.11AF2ABB;
						num <<= 27;
						if (!flag)
						{
							goto Block_6;
						}
						array = 4F0A3DA.2D850224();
						if (num >> 10 != 0U)
						{
							goto IL_127;
						}
						break;
					}
					else
					{
						ParameterInfo[] parameters = methodBase2.GetParameters();
						num -= 4269842358U;
						array2 = parameters;
						ParameterInfo[] array3 = array2;
						num = 1579138191U >> (int)num;
						array = new Type[array3.Length];
					}
				}
				int num6 = (int)(num - 771063U);
				num <<= 20;
				int num7 = num6;
				if (1747366422U > num)
				{
					while (825843517 << (int)num != 0)
					{
						int num8 = num7;
						int num9 = array2.Length;
						num ^= 2176605090U;
						if (num8 >= num9)
						{
							num ^= 3066846114U;
							goto IL_219;
						}
						Type[] array4 = array;
						num = 270107710U;
						int num10 = num7;
						num = 2268091835U - num;
						Type parameterType = array2[num7].ParameterType;
						num = 1771080619U + num;
						array4[num10] = parameterType;
						num &= 4146159031U;
						if (-121893232 << (int)num == 0)
						{
							break;
						}
						int num11 = num7 + (int)(num ^ 3760282913U);
						num = 2552457404U / num;
						num7 = num11;
						num ^= 1064304640U;
					}
					break;
				}
				continue;
				IL_219:
				num = 1528206721U >> (int)num;
				bool flag2 = num4 != 0;
				num = 899207869U << (int)num;
				bool flag3 = (num ^ 1798415736U) != 0U;
				num = 613530121U >> (int)num;
				bool flag4 = flag2 && flag3;
				num = (3778268570U ^ num);
				if (flag4)
				{
					num = (1580126648U & num);
					if (1269205303U >> (int)num == 0U)
					{
						goto IL_127;
					}
					num = 244743984U + num;
					num = (380651297U | num);
					Type type = this.50932DAD(this.16011CAB.F3AC8C0D().30B7A98C());
					string name = methodBase2.Name;
					num = 3525999124U + num;
					BindingFlags bindingAttr = (int)num + (BindingFlags)(-820220097);
					num = 808552344U >> (int)num;
					Binder binder = null;
					Type[] types = array;
					num = 311837116U - num;
					ParameterModifier[] modifiers = null;
					num ^= 4179318819U;
					MethodInfo method = type.GetMethod(name, bindingAttr, binder, types, modifiers);
					num = 1368131863U - num;
					MethodInfo methodInfo = method;
					num |= 313836300U;
					MethodInfo left = methodInfo;
					num = 1552016672U >> (int)num;
					bool flag5 = left != null;
					num = (3541309573U | num);
					num ^= 841471254U;
					if (flag5)
					{
						num *= 2544599224U;
						MethodBase methodBase4 = methodInfo;
						num ^= 3994563477U;
						methodBase2 = methodBase4;
						num += 3171244886U;
					}
				}
				BindingFlags bindingFlags = (BindingFlags)(num ^ 3778268563U);
				num *= 1207988496U;
				BindingFlags bindingFlags2 = bindingFlags;
				MethodInfo methodInfo2 = methodBase2 as MethodInfo;
				num = 1160906553U - num;
				if (1033723576U >= num)
				{
					break;
				}
				Dictionary<int, 11AE0F91.80068AA5> dictionary = new Dictionary<int, 11AE0F91.80068AA5>();
				num -= 3683457037U;
				Dictionary<int, 11AE0F91.80068AA5> dictionary2 = dictionary;
				num = 1579822081U << (int)num;
				if (num + 1259263371U == 0U)
				{
					break;
				}
				Type[] array5 = array;
				num = 2109371438U << (int)num;
				object[] array6 = new object[array5.Length];
				num = (3115980317U & num);
				object[] array7 = array6;
				if (4002461205U != num)
				{
					goto Block_16;
				}
				continue;
				IL_127:
				goto IL_219;
			}
		}
		Block_6:
		num %= 3049235094U;
		throw new ArgumentException();
		Block_16:
		11AE0F91.B59F4436 b59F = new 11AE0F91.B59F4436();
		try
		{
			num /= 2386353069U;
			if (num * 1253851020U != 0U)
			{
				goto IL_4E4;
			}
			IL_408:
			11AE0F91.80068AA5 80068AA3 = null;
			num = 3090884759U << (int)num;
			IL_41B:
			int num4;
			bool flag6 = num4 != 0;
			num >>= 10;
			bool flag7 = num + 4291948858U != 0U;
			num += 4145889319U;
			if (flag6 && flag7)
			{
				num %= 1059265848U;
				if (num % 1955769504U == 0U)
				{
					goto IL_408;
				}
				11AE0F91.80068AA5 80068AA4 = this.16011CAB.F3AC8C0D();
				num >>= 26;
				80068AA3 = 80068AA4;
				num += 4148907747U;
			}
			IL_477:
			object[] array7;
			int num12 = array7.Length;
			num = (3558110355U & num);
			int num13 = num12;
			num <<= 28;
			int num14 = (int)(num ^ 268435457U);
			num = 3643538828U % num;
			int num15 = num13 - num14;
			num = (4071959478U & num);
			int num16 = num15;
			if (3800575250U - num != 0U)
			{
				goto IL_62C;
			}
			goto IL_41B;
			IL_4E4:
			11AE0F91.5F355D3D 5F355D3D2 = this.16011CAB;
			num = (3173145621U ^ num);
			11AE0F91.80068AA5 80068AA = 5F355D3D2.F3AC8C0D();
			num <<= 14;
			11AE0F91.80068AA5 80068AA5 = 80068AA;
			num = (2276134276U ^ num);
			bool flag8 = 80068AA5.FC990F28();
			num *= 2434405670U;
			Dictionary<int, 11AE0F91.80068AA5> dictionary2;
			Type type3;
			if (flag8)
			{
				if (num == 3433381174U)
				{
					goto IL_41B;
				}
				Type type2 = type3;
				num = 2426430612U << (int)num;
				bool isByRef = type2.IsByRef;
				num /= 2510769078U;
				if (!isByRef)
				{
					object[] array8 = array7;
					int num17 = num16;
					11AE0F91.B59F4436 b59F2 = b59F;
					num |= 364438177U;
					IntPtr intPtr = b59F2.7C285EBA(80068AA.D697DB31());
					num = (1838970284U ^ num);
					object obj = intPtr;
					num %= 2961644335U;
					array8[num17] = obj;
					goto IL_5FF;
				}
				num ^= 2569561365U;
				Dictionary<int, 11AE0F91.80068AA5> dictionary3 = dictionary2;
				num = 3727353090U * num;
				dictionary3[num16] = 80068AA;
				num ^= 1468286642U;
			}
			object[] array9 = array7;
			int num18 = num16;
			num += 313310259U;
			11AE0F91.80068AA5 80068AA6 = 80068AA;
			num /= 3324736405U;
			Type 31130EB = type3;
			num -= 3523853954U;
			object obj2 = 80068AA6.01245B13(31130EB).D697DB31();
			num = 2402013887U + num;
			array9[num18] = obj2;
			num ^= 3305538352U;
			IL_5FF:
			num ^= 1495200407U;
			if (num == 3592413098U)
			{
				goto IL_477;
			}
			num16 -= (int)(num ^ 557475227U);
			num ^= 555437086U;
			IL_62C:
			if (num16 < (int)(num ^ 2173316U))
			{
				if (num > 949811973U)
				{
					goto IL_408;
				}
				MethodBase methodBase2;
				if (80068AA3 == null)
				{
					bool isStatic = methodBase2.IsStatic;
					num = 1069143860U >> (int)num;
					num += 4230319121U;
					if (!isStatic)
					{
						num ^= 3912615297U;
						num = 128179356U / num;
						80068AA3 = this.16011CAB.F3AC8C0D();
						num += 2173316U;
					}
				}
				bool flag9 = 80068AA3 != null;
				num = (2996214450U | num);
				object obj3;
				if (!flag9)
				{
					obj3 = null;
				}
				else
				{
					num -= 311686173U;
					11AE0F91.80068AA5 80068AA7 = 80068AA3;
					num = (2835507201U & num);
					obj3 = 80068AA7.D697DB31();
					num += 313883573U;
				}
				object obj4;
				bool flag10 = (obj4 = obj3) != null;
				num *= 2232820155U;
				if (!flag10)
				{
					num -= 1830519483U;
					obj4 = null;
					num += 1830519483U;
				}
				object obj5 = obj4;
				num /= 1891332634U;
				int num19 = num4;
				uint num20 = num ^ 34U;
				num = (1402445744U | num);
				object obj6 = num19 & (int)num20;
				uint num21 = num + 2892521550U;
				num |= 2645625216U;
				bool flag11 = obj6 > num21;
				num = 1915707838U << (int)num;
				if (3183399060U < num)
				{
					goto IL_41B;
				}
				if (flag11)
				{
					if ((1971983111U & num) == 0U)
					{
						goto IL_408;
					}
					bool flag12 = obj5 != null;
					num = (2333051551U & num);
					num += 82837504U;
					if (!flag12)
					{
						throw new NullReferenceException();
					}
				}
				object obj7 = null;
				num = 1049346095U << (int)num;
				if (2553862534U <= num)
				{
					goto IL_41B;
				}
				MethodBase methodBase5 = methodBase2;
				num = 2209908512U >> (int)num;
				CallingConventions callingConvention2 = methodBase5.CallingConvention;
				num <<= 21;
				uint num22 = num - 3995074558U;
				num &= 1504361253U;
				Type[] array;
				MethodInfo methodInfo2;
				Dictionary<object, DynamicMethod> dictionary4;
				bool flag13;
				DynamicMethod dynamicMethod;
				if (callingConvention2 == num22)
				{
					num = 2344326827U - num;
					dictionary4 = 11AE0F91.A2896C2E;
					flag13 = ((num ^ 1134270123U) != 0U);
					try
					{
						int num2;
						Type[] array11;
						ILGenerator ilgenerator;
						for (;;)
						{
							IL_7F9:
							Monitor.Enter(dictionary4, ref flag13);
							if (385970073U <= num)
							{
								goto IL_80E;
							}
							for (;;)
							{
								IL_830:
								MethodBase methodBase6 = methodInfo2;
								num /= 428717850U;
								int num23 = methodBase6.GetParameters().Length;
								num = 4171528971U / num;
								int num24 = num23;
								for (;;)
								{
									IL_84F:
									int num25 = array.Length;
									int num26 = num24;
									num = 4001780225U << (int)num;
									int num27 = num25 - num26;
									num = 264179619U * num;
									Type[] array10 = new Type[num27];
									num -= 1694722482U;
									array11 = array10;
									num &= 4236254089U;
									if (num / 2013616641U == 0U)
									{
										goto IL_7F9;
									}
									Array sourceArray = array;
									num = 4247401372U << (int)num;
									int sourceIndex = num24;
									num -= 1782035841U;
									Array destinationArray = array11;
									num &= 2232668472U;
									int destinationIndex = (int)(num ^ 2232664120U);
									num = 2224414258U % num;
									Type[] array12 = array;
									num *= 1621925889U;
									Array.Copy(sourceArray, sourceIndex, destinationArray, destinationIndex, array12.Length - num24);
									if ((1119711533U ^ num) != 0U)
									{
										string name2 = "";
										MethodInfo left2 = methodInfo2;
										num *= 2075929380U;
										bool flag14 = left2 != null;
										num = (1673223857U ^ num);
										if (!flag14)
										{
											goto IL_966;
										}
										MethodInfo methodInfo3 = methodInfo2;
										num = (2743596037U ^ num);
										Type returnType = methodInfo3.ReturnType;
										RuntimeTypeHandle handle = typeof(void).TypeHandle;
										num = (2611502241U | num);
										Type typeFromHandle = Type.GetTypeFromHandle(handle);
										num = 244161831U << (int)num;
										if (!(returnType != typeFromHandle))
										{
											num += 790231993U;
											goto IL_966;
										}
										num = 3213845276U % num;
										Type returnType2 = methodInfo2.ReturnType;
										num ^= 2696059047U;
										IL_991:
										num = 2457899274U + num;
										Type[] parameterTypes = array;
										RuntimeTypeHandle handle2 = typeof(11AE0F91).TypeHandle;
										num = (697657221U ^ num);
										Module module = Type.GetTypeFromHandle(handle2).Module;
										num += 1083502767U;
										dynamicMethod = new DynamicMethod(name2, returnType2, parameterTypes, module, (num ^ 3636517870U) != 0U);
										if (3040745534U - num == 0U)
										{
											goto IL_7F9;
										}
										ilgenerator = dynamicMethod.GetILGenerator();
										num = 3072310152U - num;
										int num28 = (int)(num + 564207719U);
										if (4130921750U - num == 0U)
										{
											goto IL_7F9;
										}
										for (;;)
										{
											num = 1721898301U - num;
											if (num == 4061776164U)
											{
												goto IL_84F;
											}
											int num29 = num28;
											Type[] array13 = array;
											num = (161455506U ^ num);
											int num30 = array13.Length;
											num = 1411349552U * num;
											int num31 = num30;
											num = (2092594315U & num);
											if (num29 >= num31)
											{
												goto Block_75;
											}
											num = 1210699137U;
											if (783529607 << (int)num == 0)
											{
												goto IL_7F9;
											}
											ILGenerator ilgenerator2 = ilgenerator;
											OpCode ldarg = OpCodes.Ldarg;
											int arg = num28;
											num = (540655659U ^ num);
											ilgenerator2.Emit(ldarg, arg);
											if (num < 522677178U)
											{
												goto IL_7F9;
											}
											int num32 = num28;
											num |= 1100586158U;
											int num33 = num32 + (int)(num ^ 1771675055U);
											num /= 3844797874U;
											num28 = num33;
											num ^= 3730759577U;
										}
										IL_966:
										num = (272397075U | num);
										returnType2 = null;
										goto IL_991;
									}
									break;
								}
							}
							Block_75:
							num = 28820994U + num;
							if (num < 3642725948U)
							{
								break;
							}
							IL_80E:
							Dictionary<object, DynamicMethod> a2896C2E = 11AE0F91.A2896C2E;
							int num34 = num2;
							num = 1545224741U * num;
							if (!a2896C2E.TryGetValue(num34, out dynamicMethod))
							{
								goto IL_830;
							}
							goto IL_B3A;
						}
						ILGenerator ilgenerator3 = ilgenerator;
						OpCode call = OpCodes.Call;
						num = 2283706146U - num;
						MethodInfo methodInfo4 = methodInfo2;
						num %= 2457976236U;
						ilgenerator3.EmitCall(call, methodInfo4, array11);
						num = 2838538804U * num;
						ilgenerator.Emit(OpCodes.Ret);
						num = (2584316692U ^ num);
						Dictionary<object, DynamicMethod> a2896C2E2 = 11AE0F91.A2896C2E;
						num >>= 24;
						object key = num2;
						DynamicMethod value = dynamicMethod;
						num = 33957510U * num;
						a2896C2E2.Add(key, value);
						num += 3102304255U;
						IL_B3A:;
					}
					finally
					{
						num = 808310048U;
						bool flag15 = flag13;
						num ^= 1538424869U;
						if (flag15)
						{
							num = (3366673939U ^ num);
							object obj8 = dictionary4;
							num %= 3515898684U;
							Monitor.Exit(obj8);
							num ^= 3366673939U;
						}
					}
				}
				else
				{
					num = 4131366668U >> (int)num;
					if (3591335308U > num)
					{
						goto IL_BE9;
					}
					if (flag11)
					{
						goto IL_1341;
					}
					MethodBase methodBase7 = methodBase2;
					num &= 1503993610U;
					bool isVirtual = methodBase7.IsVirtual;
					num = 170404753U * num;
					num ^= 4032361604U;
					if (isVirtual)
					{
						goto IL_C3A;
					}
					goto IL_1341;
				}
				IL_B7D:
				num = 1814226841U;
				BindingFlags bindingFlags2;
				if (3062915367U != num)
				{
					MethodBase methodBase8 = dynamicMethod;
					num = (3759887514U ^ num);
					object obj9 = null;
					num = 3174871343U / num;
					BindingFlags invokeAttr = bindingFlags2;
					num = (3691646387U & num);
					Binder binder2 = null;
					object[] parameters2 = array7;
					num += 419515049U;
					CultureInfo culture = null;
					num -= 3917526279U;
					object obj10 = methodBase8.Invoke(obj9, invokeAttr, binder2, parameters2, culture);
					num = 621625128U - num;
					obj7 = obj10;
					if (num >> 22 == 0U)
					{
						goto IL_C3A;
					}
				}
				IL_BE9:
				goto IL_1517;
				IL_C3A:
				MethodBase methodBase9 = methodBase2;
				num <<= 4;
				bool isFinal = methodBase9.IsFinal;
				num <<= 20;
				num ^= 4198475532U;
				if (isFinal)
				{
					goto IL_1341;
				}
				if (num <= 1169588377U)
				{
					goto IL_B7D;
				}
				int num35 = array.Length;
				num /= 883981472U;
				int num36 = num35 + (int)(num + 4294967293U);
				num += 1754982845U;
				object[] array14 = new object[num36];
				num &= 1101719838U;
				object[] array15 = array14;
				num >>= 15;
				int num37 = (int)(num ^ 33045U);
				num <<= 4;
				object obj11 = obj5;
				num %= 4137431732U;
				array15[num37] = obj11;
				num *= 10666809U;
				int num38 = (int)(num ^ 463194832U);
				num = 1455347590U * num;
				int num39 = num38;
				if (2510851968U / num != 0U)
				{
					goto IL_BE9;
				}
				for (;;)
				{
					num -= 3719068071U;
					int num40 = num39;
					num &= 2603924379U;
					int num41 = array.Length;
					num = 3047852471U * num;
					if (num40 >= num41)
					{
						break;
					}
					object[] array16 = array14;
					num = 1251602737U;
					int num42 = num39 + (int)(num ^ 1251602736U);
					object[] array17 = array7;
					num <<= 30;
					object obj12 = array17[num39];
					num = (4237670032U & num);
					array16[num42] = obj12;
					num >>= 8;
					if ((2417725966U ^ num) == 0U)
					{
						goto IL_BE9;
					}
					int num43 = num39 + (int)(num + 4290772993U);
					num |= 151038623U;
					num39 = num43;
					num ^= 3087037055U;
				}
				Dictionary<object, DynamicMethod> a2896C2E3 = 11AE0F91.A2896C2E;
				num = 3120733621U + num;
				dictionary4 = a2896C2E3;
				num = 2223927218U >> (int)num;
				flag13 = (num - 2120U != 0U);
				DynamicMethod dynamicMethod3;
				try
				{
					do
					{
						IL_DB4:
						Monitor.Enter(dictionary4, ref flag13);
						num *= 2619920047U;
						if ((4053818005U & num) != 0U)
						{
							goto IL_DD4;
						}
						Type[] array19;
						for (;;)
						{
							IL_E25:
							Type[] array18 = array19;
							num -= 2811147815U;
							int num44 = (int)(num + 3037619398U);
							num = (976923423U ^ num);
							array18[num44] = methodBase2.DeclaringType;
							int num45 = (int)(num + 2402602971U);
							for (;;)
							{
								num = 3239927472U - num;
								if (num + 3766944059U == 0U)
								{
									goto IL_DB4;
								}
								int num46 = num45;
								num = 2226172843U * num;
								int num47 = array.Length;
								num *= 143124373U;
								if (num46 >= num47)
								{
									break;
								}
								num = 3322379821U;
								if (num << 11 == 0U)
								{
									goto IL_DB4;
								}
								Type[] array20 = array19;
								int num48 = num45;
								num = 1848264093U * num;
								int num49 = (int)(num ^ 2164032152U);
								num <<= 2;
								int num50 = num48 + num49;
								Type[] array21 = array;
								num = 2626211880U / num;
								object obj13 = array21[num45];
								num = 1259035673U % num;
								array20[num50] = obj13;
								num &= 1528650020U;
								int num51 = num45;
								num >>= 1;
								num45 = num51 + (int)(num ^ 19U);
								num ^= 1892364343U;
							}
							if (num > 775691315U)
							{
								string name3 = "";
								num = 1480494605U + num;
								MethodInfo left3 = methodInfo2;
								num = 3365662991U - num;
								bool flag16 = left3 != null;
								num %= 2259331076U;
								if (!flag16)
								{
									goto IL_F89;
								}
								Type returnType3 = methodInfo2.ReturnType;
								num = 2586771994U / num;
								RuntimeTypeHandle handle3 = typeof(void).TypeHandle;
								num |= 3224100513U;
								bool flag17 = returnType3 != Type.GetTypeFromHandle(handle3);
								num = (134463531U ^ num);
								if (!flag17)
								{
									num += 941423649U;
									goto IL_F89;
								}
								MethodInfo methodInfo5 = methodInfo2;
								num %= 849362350U;
								Type returnType4 = methodInfo5.ReturnType;
								num += 3489510699U;
								IL_FAA:
								num = 605548431U >> (int)num;
								Type[] parameterTypes2 = array19;
								Type typeFromHandle2 = typeof(11AE0F91);
								num = 2198488455U << (int)num;
								Module module2 = typeFromHandle2.Module;
								num = (730167075U & num);
								bool skipVisibility = (num ^ 33828865U) != 0U;
								num = 1520439047U + num;
								DynamicMethod dynamicMethod2 = new DynamicMethod(name3, returnType4, parameterTypes2, module2, skipVisibility);
								num = 421666874U * num;
								dynamicMethod3 = dynamicMethod2;
								ILGenerator ilgenerator4 = dynamicMethod3.GetILGenerator();
								num = 4164515490U << (int)num;
								ILGenerator ilgenerator5 = ilgenerator4;
								int num52 = (int)(num ^ 2826960896U);
								if ((num ^ 244572606U) == 0U)
								{
									goto IL_DD4;
								}
								for (;;)
								{
									num = 71034155U * num;
									int num53 = num52;
									Type[] array22 = array19;
									num = 983391803U - num;
									if (num53 >= array22.Length)
									{
										break;
									}
									num = 2695264044U;
									if (num / 305480066U != 0U)
									{
										if (num52 != 0)
										{
											goto IL_10DE;
										}
										num = (4214566695U & num);
										Type declaringType = methodBase2.DeclaringType;
										num ^= 621871526U;
										bool isValueType = declaringType.IsValueType;
										num %= 732080176U;
										num += 2656651578U;
										if (!isValueType)
										{
											goto IL_10DE;
										}
										num = 1094631968U - num;
										ILGenerator ilgenerator6 = ilgenerator5;
										num = 3836725176U + num;
										OpCode ldarga = OpCodes.Ldarga;
										num += 1832115104U;
										int arg2 = num52;
										num = 884580504U << (int)num;
										ilgenerator6.Emit(ldarga, arg2);
										if (num == 3945284240U)
										{
											goto IL_DD4;
										}
										IL_1100:
										int num54 = num52;
										int num55 = (int)(num + 1710653441U);
										num >>= 2;
										num52 = num54 + num55;
										num ^= 2382520320U;
										continue;
										IL_10DE:
										ILGenerator ilgenerator7 = ilgenerator5;
										num = (1286666771U & num);
										ilgenerator7.Emit(OpCodes.Ldarg, num52);
										num ^= 2594828800U;
										goto IL_1100;
									}
									goto IL_DD4;
								}
								num -= 2427020169U;
								ILGenerator ilgenerator8 = ilgenerator5;
								OpCode call2 = OpCodes.Call;
								MethodInfo meth = methodInfo2;
								num <<= 14;
								ilgenerator8.Emit(call2, meth);
								if (715543433U >= num)
								{
									goto IL_DD4;
								}
								ILGenerator ilgenerator9 = ilgenerator5;
								num &= 2586658701U;
								ilgenerator9.Emit(OpCodes.Ret);
								num %= 195167105U;
								if ((num ^ 2661840544U) != 0U)
								{
									break;
								}
								continue;
								IL_F89:
								returnType4 = null;
								goto IL_FAA;
							}
							goto IL_DFD;
						}
						Dictionary<object, DynamicMethod> a2896C2E4 = 11AE0F91.A2896C2E;
						object key2 = methodBase2;
						num = (2232650905U & num);
						a2896C2E4.Add(key2, dynamicMethod3);
						num += 836639015U;
						goto IL_11BD;
						IL_DD4:
						if (11AE0F91.A2896C2E.TryGetValue(methodBase2, out dynamicMethod3))
						{
							goto IL_11BD;
						}
						num %= 3509636912U;
						if (num == 2669743930U)
						{
							continue;
						}
						IL_DFD:
						object[] array23 = array14;
						num |= 3350966680U;
						int num56 = array23.Length;
						num = 2005698615U + num;
						Type[] array24 = new Type[num56];
						num *= 1032303023U;
						array19 = array24;
						goto IL_E25;
						IL_11BD:;
					}
					while (1035170450U == num);
				}
				finally
				{
					bool flag18 = flag13;
					num = 2082982300U;
					if (flag18)
					{
						Monitor.Exit(dictionary4);
						num += 0U;
					}
				}
				do
				{
					MethodBase methodBase10 = dynamicMethod3;
					num = 2209019703U;
					object obj14 = null;
					BindingFlags invokeAttr2 = bindingFlags2;
					Binder binder3 = null;
					num -= 352522047U;
					object[] parameters3 = array14;
					CultureInfo culture2 = null;
					num = 3560272543U << (int)num;
					obj7 = methodBase10.Invoke(obj14, invokeAttr2, binder3, parameters3, culture2);
				}
				while ((2769295260U ^ num) == 0U);
				Dictionary<int, 11AE0F91.80068AA5> dictionary5 = dictionary2;
				num /= 1067910022U;
				Dictionary<int, 11AE0F91.80068AA5>.Enumerator enumerator = dictionary5.GetEnumerator();
				num = (2785636756U | num);
				using (Dictionary<int, 11AE0F91.80068AA5>.Enumerator enumerator2 = enumerator)
				{
					for (;;)
					{
						num ^= 2475409343U;
						if ((num ^ 2871213824U) == 0U)
						{
							break;
						}
						num = (2568552198U ^ num);
						bool flag19 = enumerator2.MoveNext();
						num /= 730861718U;
						if (!flag19)
						{
							break;
						}
						num = 220162590U;
						KeyValuePair<int, 11AE0F91.80068AA5> keyValuePair;
						if (num != 3322952590U)
						{
							keyValuePair = enumerator2.Current;
						}
						num = (580413985U | num);
						11AE0F91.80068AA5 value2 = keyValuePair.Value;
						object[] array25 = array14;
						num %= 1930761661U;
						int key3 = keyValuePair.Key;
						num += 1914466705U;
						value2.7E869424(array25[key3 + (int)(num + 1581524017U)]);
						num ^= 129149510U;
					}
				}
				IL_1300:
				num = 2349401642U;
				if (num << 5 == 0U)
				{
					goto IL_1393;
				}
				Dictionary<int, 11AE0F91.80068AA5> dictionary6 = dictionary2;
				num /= 933456408U;
				dictionary6.Clear();
				if (num / 539699094U == 0U)
				{
					num += 4119636355U;
					goto IL_1517;
				}
				goto IL_13C1;
				IL_1341:
				num = 3834870691U / num;
				if (!methodBase2.IsConstructor)
				{
					goto IL_1404;
				}
				num = (1745588616U | num);
				IL_1361:
				bool isValueType2 = methodBase2.DeclaringType.IsValueType;
				num += 2549378680U;
				if (!isValueType2)
				{
					goto IL_1404;
				}
				num *= 1857426228U;
				if ((1803812234U ^ num) == 0U)
				{
					goto IL_1341;
				}
				IL_1393:
				bool flag20 = Nullable.GetUnderlyingType(methodBase2.DeclaringType) != null;
				num += 0U;
				if (!flag20)
				{
					goto IL_1404;
				}
				if (num - 4095920000U == 0U)
				{
					goto IL_1300;
				}
				IL_13C1:
				ConstructorInfo constructorInfo = (ConstructorInfo)methodBase2;
				BindingFlags invokeAttr3 = bindingFlags2;
				Binder binder4 = null;
				num = 3190789426U - num;
				object[] parameters4 = array7;
				CultureInfo culture3 = null;
				num ^= 3884638121U;
				object obj15 = constructorInfo.Invoke(invokeAttr3, binder4, parameters4, culture3);
				num %= 3879011596U;
				obj5 = obj15;
				if (num != 1023533362U)
				{
					goto IL_143D;
				}
				goto IL_1361;
				IL_1404:
				MethodBase methodBase11 = methodBase2;
				object obj16 = obj5;
				num *= 293642912U;
				BindingFlags invokeAttr4 = bindingFlags2;
				Binder binder5 = null;
				num = (2341025817U ^ num);
				object obj17 = methodBase11.Invoke(obj16, invokeAttr4, binder5, array7, null);
				num >>= 17;
				obj7 = obj17;
				num ^= 1503989599U;
				IL_143D:
				num = (2243573397U | num);
				bool flag21 = 80068AA3 != null;
				num += 399321830U;
				if (flag21)
				{
					num = 2703373759U >> (int)num;
					if (num * 1194681652U == 0U)
					{
						goto IL_1300;
					}
					11AE0F91.80068AA5 80068AA8 = 80068AA3;
					num <<= 2;
					bool flag22 = 80068AA8.FC990F28();
					num *= 3053766961U;
					num += 2353515793U;
					if (flag22)
					{
						MemberInfo memberInfo = methodBase2;
						num += 1521641379U;
						Type declaringType2 = memberInfo.DeclaringType;
						num = 3853280040U >> (int)num;
						bool isValueType3 = declaringType2.IsValueType;
						num += 4104584482U;
						if (isValueType3)
						{
							num = 1326150046U << (int)num;
							if (1487231022U == num)
							{
								goto IL_1300;
							}
							11AE0F91.80068AA5 80068AA9 = 80068AA3;
							num += 723918977U;
							object 9590F = obj5;
							num += 3098195095U;
							80068AA9.7E869424(9590F);
							num ^= 817078621U;
						}
					}
				}
				IL_1517:
				num *= 112721942U;
				if (3171452567U + num == 0U)
				{
					goto IL_1300;
				}
				Dictionary<int, 11AE0F91.80068AA5> dictionary7 = dictionary2;
				num += 2483203211U;
				using (Dictionary<int, 11AE0F91.80068AA5>.Enumerator enumerator2 = dictionary7.GetEnumerator())
				{
					for (;;)
					{
						IL_1541:
						for (;;)
						{
							num = 2251482511U << (int)num;
							if (num / 3725258301U == 0U)
							{
								num = 3868445824U + num;
								if (!enumerator2.MoveNext())
								{
									goto Block_104;
								}
								KeyValuePair<int, 11AE0F91.80068AA5> keyValuePair2;
								do
								{
									num = 178636032U;
									if (46107793U > num)
									{
										goto IL_1541;
									}
									keyValuePair2 = enumerator2.Current;
									num += 1880146991U;
								}
								while ((num ^ 76959520U) == 0U);
								num = 2041863812U * num;
								11AE0F91.80068AA5 value3 = keyValuePair2.Value;
								num = 3970936837U + num;
								object[] array26 = array7;
								num ^= 4053393824U;
								int key4 = keyValuePair2.Key;
								num = (3139211670U ^ num);
								object 9590F2 = array26[key4];
								num = 153269669U >> (int)num;
								value3.7E869424(9590F2);
								num ^= 2746301931U;
							}
						}
					}
					Block_104:;
				}
				do
				{
					MethodInfo left4 = methodInfo2;
					MethodInfo right = null;
					num = 1939117086U;
					if (!(left4 != right))
					{
						goto IL_16B9;
					}
				}
				while (4254438560U - num == 0U);
				bool flag23 = methodInfo2.ReturnType != typeof(void);
				num <<= 18;
				num += 589075486U;
				if (!flag23)
				{
					goto IL_16B9;
				}
				IL_166E:
				11AE0F91.5F355D3D 5F355D3D3 = this.16011CAB;
				object 9730DA = obj7;
				num = 178124209U / num;
				MethodInfo methodInfo6 = methodInfo2;
				num = 3291926307U + num;
				Type returnType5 = methodInfo6.ReturnType;
				num -= 1206442U;
				11AE0F91.80068AA5 268B972E = 11AE0F91.80068AA5.872D5EA9(9730DA, returnType5);
				num = 2151083068U + num;
				5F355D3D3.07A52495(268B972E);
				num += 792281449U;
				IL_16B9:
				if (2839402644U <= num)
				{
					goto IL_166E;
				}
			}
			else
			{
				Type[] array;
				Type type4 = array[num16];
				num = 4128598691U;
				type3 = type4;
				num = 1444346138U - num;
				if (1771030970U >= num)
				{
					goto IL_4E4;
				}
				goto IL_408;
			}
		}
		finally
		{
			b59F.Dispose();
		}
	}

	// Token: 0x0600031A RID: 794 RVA: 0x0005B804 File Offset: 0x00059404
	private void 702E7607()
	{
		uint num;
		Array array;
		for (;;)
		{
			num = 781877562U;
			11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
			num = 914679456U % num;
			11AE0F91.80068AA5 80068AA = 5F355D3D.F3AC8C0D();
			num = 3325675834U + num;
			object obj = 80068AA.D697DB31();
			num += 604734482U;
			array = (obj as Array);
			num ^= 4171222820U;
			if (2300208305U >= num)
			{
				if (array == null)
				{
					break;
				}
				num &= 2074386474U;
				if (num <= 1848418072U)
				{
					goto Block_2;
				}
			}
		}
		num = 1267470226U / num;
		throw new ArgumentException();
		Block_2:
		11AE0F91.5F355D3D 5F355D3D2 = this.16011CAB;
		Array array2 = array;
		num %= 867751102U;
		int length = array2.Length;
		num = 303726651U % num;
		11AE0F91.80068AA5 268B972E = new 11AE0F91.CB943E91(length);
		num = (2425297331U & num);
		5F355D3D2.07A52495(268B972E);
	}

	// Token: 0x0600031B RID: 795 RVA: 0x0005C484 File Offset: 0x0005A084
	private void 8F0B263F()
	{
		uint num = 1662079030U;
		Type type2;
		do
		{
			num ^= 506119577U;
			int 9BA5622C = this.4FA4D617.99BB76A6();
			num *= 1896565692U;
			Type type = this.50932DAD(9BA5622C);
			num = 1186935862U << (int)num;
			type2 = type;
			num &= 2961657522U;
		}
		while (num >= 4146086543U);
		for (;;)
		{
			11AE0F91.80068AA5 80068AA = this.16011CAB.F3AC8C0D();
			num = (2584843568U | num);
			if (830558268U != num)
			{
				11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
				11AE0F91.80068AA5 6D8E093B = 80068AA;
				Type 74105C = type2;
				num = (3759421972U ^ num);
				5F355D3D.07A52495(11AE0F91.80068AA5.90BC983A(6D8E093B, 74105C));
				if (num % 2189503394U != 0U)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600031C RID: 796 RVA: 0x0005863C File Offset: 0x0005623C
	private void 61814CA6()
	{
		uint num = 1672410511U;
		num *= 1887453204U;
		FieldInfo fieldInfo = this.37923CB5(this.4FA4D617.99BB76A6());
		num = (4162128824U & num);
		FieldInfo fieldInfo2 = fieldInfo;
		num /= 1501975579U;
		11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
		FieldInfo 4A2E = fieldInfo2;
		num ^= 2534087838U;
		11AE0F91.80068AA5 268B972E = new 11AE0F91.060D1790(4A2E, this);
		num = 2592570765U - num;
		5F355D3D.07A52495(268B972E);
	}

	// Token: 0x0600031D RID: 797 RVA: 0x000584AC File Offset: 0x000560AC
	private void BC828E8C()
	{
		uint num = 1233573020U;
		if (num >= 2852912023U)
		{
			goto IL_48;
		}
		IL_11:
		num = (4044631593U ^ num);
		11AE0F91.833BF530 833BF = this.4FA4D617;
		num >>= 2;
		int num2 = (int)833BF.50AB0933();
		num *= 278331187U;
		int num3 = num2;
		num <<= 13;
		if (num < 790832810U)
		{
			goto IL_5F;
		}
		IL_48:
		11AE0F91.80068AA5 80068AA = this.16011CAB.F3AC8C0D();
		if (num == 1396308263U)
		{
			goto IL_11;
		}
		IL_5F:
		uint num4 = (uint)num3;
		num ^= 2184199821U;
		if (num4 < (num ^ 1272897165U))
		{
			num = 3895885575U / num;
			if (num >= 1981347225U)
			{
				goto IL_11;
			}
		}
		else
		{
			num = (1175946283U & num);
			11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
			num /= 196111147U;
			int 24058B = num3;
			num &= 673680917U;
			11AE0F91.80068AA5 80068AA2 = 5F355D3D.252E6C8E(24058B);
			num |= 2695541813U;
			bool flag = 80068AA2 != null;
			num /= 4236280227U;
			if (!flag)
			{
				if (814953236U - num != 0U)
				{
					11AE0F91.80068AA5 80068AA3 = 80068AA;
					num = 4113355067U - num;
					bool flag2 = 80068AA3.FC990F28();
					num = (757537024U ^ num);
					if (!flag2)
					{
						throw new ArgumentException();
					}
					this.16011CAB.5C817C1A(num3, 80068AA);
					num &= 2936619959U;
					return;
				}
			}
			else
			{
				11AE0F91.80068AA5 80068AA4 = 80068AA2;
				num -= 405432327U;
				11AE0F91.80068AA5 80068AA5 = 80068AA;
				num = (4281137798U | num);
				80068AA4.7E869424(80068AA5.01245B13(80068AA2.20129380()).D697DB31());
				if (num + 1947058476U != 0U)
				{
					return;
				}
				goto IL_11;
			}
		}
		11AE0F91.5F355D3D 5F355D3D2 = this.16011CAB;
		int num5 = num3;
		num &= 3551492887U;
		num += 3022819217U;
		11AE0F91.1280CA96 1280CA = this.16011CAB;
		num = 2611230774U % num;
		int num6 = 1280CA.B395DB29();
		num >>= 1;
		5F355D3D2.5C817C1A(num5 + num6, 80068AA);
		if ((872876675U ^ num) != 0U)
		{
			return;
		}
		goto IL_11;
	}

	// Token: 0x0600031E RID: 798 RVA: 0x00056418 File Offset: 0x00054018
	private void A0AF2E0D()
	{
		uint num = 78641706U;
		11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
		num -= 4127905542U;
		num |= 2257289734U;
		11AE0F91.833BF530 833BF = this.4FA4D617;
		num = 690638086U * num;
		long d1A1852C = 833BF.8B9CB93A();
		num = 572187028U << (int)num;
		11AE0F91.80068AA5 268B972E = new 11AE0F91.6A9A2996(d1A1852C);
		num += 3476392600U;
		5F355D3D.07A52495(268B972E);
	}

	// Token: 0x0600031F RID: 799 RVA: 0x00056F5C File Offset: 0x00054B5C
	private void 41A6CA0C()
	{
		uint num = 3089300872U;
		for (;;)
		{
			num += 2298616325U;
			11AE0F91.80068AA5 80068AA = this.16011CAB.F3AC8C0D();
			num = 85936785U / num;
			11AE0F91.80068AA5 80068AA2 = 80068AA;
			num = (1941799956U ^ num);
			11AE0F91.80068AA5 80068AA3 = this.16011CAB.F3AC8C0D();
			num /= 655289105U;
			if (num < 1135244575U)
			{
				num >>= 2;
				11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
				11AE0F91.80068AA5 d029432B = 80068AA3;
				11AE0F91.80068AA5 251F = 80068AA2;
				num &= 2763904552U;
				11AE0F91.80068AA5 268B972E = 11AE0F91.6A9A2996.8232AF01(d029432B, 251F);
				num -= 3047519668U;
				5F355D3D.07A52495(268B972E);
				if (1144103553U <= num)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000320 RID: 800 RVA: 0x00058118 File Offset: 0x00055D18
	private void 9CBD9706()
	{
		uint num = 430787354U;
		num <<= 1;
		num <<= 4;
		int 230EA6AB = this.4FA4D617.99BB76A6();
		num = 2033139091U - num;
		FieldInfo fieldInfo = this.37923CB5(230EA6AB);
		num = (1812185136U ^ num);
		FieldInfo fieldInfo2 = fieldInfo;
		num = 2292840624U % num;
		11AE0F91.80068AA5 80068AA;
		if (num >> 1 != 0U)
		{
			11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
			num = 1638217619U / num;
			80068AA = 5F355D3D.F3AC8C0D();
			num = 4231236131U * num;
		}
		do
		{
			num = 3769914158U % num;
			11AE0F91.5F355D3D 5F355D3D2 = this.16011CAB;
			FieldInfo d0BD6B9A = fieldInfo2;
			11AE0F91.80068AA5 38BE = 80068AA;
			num = 1250530463U >> (int)num;
			5F355D3D2.07A52495(new 11AE0F91.6B246EA5(d0BD6B9A, 38BE));
		}
		while (num + 688923170U == 0U);
	}

	// Token: 0x06000321 RID: 801 RVA: 0x0005C860 File Offset: 0x0005A460
	// Note: this type is marked as 'beforefieldinit'.
	static 11AE0F91()
	{
		RuntimeTypeHandle handle = typeof(11AE0F91).TypeHandle;
		uint num = 1428606631U;
		Type typeFromHandle = Type.GetTypeFromHandle(handle);
		num /= 1321068707U;
		11AE0F91.08BC110D = typeFromHandle.Module;
		if (470884905U <= num)
		{
			goto IL_47;
		}
		IL_2D:
		Dictionary<uint, object> a314EB = new Dictionary<uint, object>();
		num = 301995033U + num;
		11AE0F91.A314EB83 = a314EB;
		num += 514626946U;
		IL_47:
		11AE0F91.A2896C2E = new Dictionary<object, DynamicMethod>();
		if (2830827422U + num != 0U)
		{
			return;
		}
		goto IL_2D;
	}

	// Token: 0x06000322 RID: 802 RVA: 0x00057560 File Offset: 0x00055160
	private void 5DADD105()
	{
		uint num = 51503794U;
		11AE0F91.80068AA5 e42FF0BD;
		11AE0F91.80068AA5 80068AA;
		do
		{
			num = (263918610U ^ num);
			e42FF0BD = this.16011CAB.F3AC8C0D();
			if ((num & 3078709944U) == 0U)
			{
				return;
			}
			11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
			num = (1023549242U ^ num);
			80068AA = 5F355D3D.F3AC8C0D();
			num += 3728264485U;
		}
		while (2050754190U - num == 0U);
		num *= 1623146505U;
		11AE0F91.5F355D3D 5F355D3D2 = this.16011CAB;
		num >>= 22;
		11AE0F91.80068AA5 4FAC339C = 80068AA;
		num /= 2516928176U;
		5F355D3D2.07A52495(11AE0F91.CB943E91.15917E88(4FAC339C, e42FF0BD));
	}

	// Token: 0x06000323 RID: 803 RVA: 0x00055960 File Offset: 0x00053560
	private MethodBase 613B5197(int 16BDA8B3)
	{
		uint num = 1191713034U;
		num ^= 2953401395U;
		MemberInfo memberInfo = this.68B43D97(16BDA8B3);
		num = 1023487108U + num;
		bool flag = memberInfo is MethodBase;
		num ^= 2602575787U;
		if (flag)
		{
			num = 4211179582U >> (int)num;
			if (num - 2880244792U != 0U)
			{
				return (MethodBase)memberInfo;
			}
		}
		throw new InvalidOperationException();
	}

	// Token: 0x06000324 RID: 804 RVA: 0x00056ED4 File Offset: 0x00054AD4
	private void C90E4819()
	{
		uint num = 2953420724U;
		for (;;)
		{
			11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
			num -= 1017118103U;
			11AE0F91.80068AA5 c82775BD = 5F355D3D.F3AC8C0D();
			num |= 687868567U;
			if (3666782744U != num)
			{
				11AE0F91.80068AA5 80068AA = this.16011CAB.F3AC8C0D();
				num = 783595419U % num;
				11AE0F91.80068AA5 1DBE = 80068AA;
				num <<= 2;
				if (num * 1279215400U != 0U)
				{
					11AE0F91.5F355D3D 5F355D3D2 = this.16011CAB;
					num <<= 0;
					5F355D3D2.07A52495(11AE0F91.CB943E91.823F3018(1DBE, c82775BD));
					if (num > 1855437703U)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000325 RID: 805 RVA: 0x000559C4 File Offset: 0x000535C4
	private FieldInfo 37923CB5(int 230EA6AB)
	{
		MemberInfo memberInfo = this.68B43D97(230EA6AB);
		uint num = 723617726U;
		for (;;)
		{
			MemberInfo memberInfo2 = memberInfo;
			num += 2998773921U;
			if (memberInfo2 is FieldInfo)
			{
				num = 3240543496U / num;
				if ((num ^ 1469466291U) != 0U)
				{
					break;
				}
			}
			else
			{
				num %= 1354038561U;
				if ((num ^ 3105827770U) != 0U)
				{
					goto Block_3;
				}
			}
		}
		return (FieldInfo)memberInfo;
		Block_3:
		throw new InvalidOperationException();
	}

	// Token: 0x06000326 RID: 806 RVA: 0x0005B2F0 File Offset: 0x00058EF0
	private void 662F9C1D()
	{
		uint num;
		do
		{
			num = 2560474634U;
			11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
			num &= 328562850U;
			11AE0F91.80068AA5 80068AA = 5F355D3D.F3AC8C0D();
			num = 2810704822U % num;
			11AE0F91.80068AA5 80068AA2 = 80068AA;
			num = 2258893829U - num;
			11AE0F91.80068AA5 80068AA4;
			if (num != 4113299607U)
			{
				11AE0F91.5F355D3D 5F355D3D2 = this.16011CAB;
				num += 447327547U;
				11AE0F91.80068AA5 80068AA3 = 5F355D3D2.F3AC8C0D();
				num = 691584036U + num;
				80068AA4 = 80068AA3;
				if (4043894422U <= num)
				{
					break;
				}
			}
			num = (4086802721U | num);
			11AE0F91.5F355D3D 5F355D3D3 = this.16011CAB;
			11AE0F91.80068AA5 dd913F9F = 80068AA4;
			num = (3207265824U ^ num);
			11AE0F91.80068AA5 f530AE2E = 80068AA2;
			num -= 515094030U;
			11AE0F91.80068AA5 268B972E = 11AE0F91.8A270C3B.16932F8C(dd913F9F, f530AE2E);
			num = 4179864351U + num;
			5F355D3D3.07A52495(268B972E);
		}
		while (num + 2158007344U == 0U);
	}

	// Token: 0x06000327 RID: 807 RVA: 0x0005869C File Offset: 0x0005629C
	private void E90838A9()
	{
		11AE0F91.80068AA5 80068AA = this.16011CAB.F3AC8C0D();
		uint num = 3801302785U;
		11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
		num %= 1058585476U;
		11AE0F91.80068AA5 80068AA2 = 5F355D3D.F3AC8C0D();
		num &= 3978760995U;
		11AE0F91.80068AA5 80068AA3 = 80068AA2;
		num += 3198856464U;
		11AE0F91.80068AA5 80068AA4 = 80068AA;
		num >>= 31;
		11AE0F91.80068AA5 80068AA5 = 80068AA3;
		Type 31130EB = 80068AA.20129380();
		num = (3004452746U | num);
		80068AA4.7E869424(80068AA5.01245B13(31130EB).D697DB31());
	}

	// Token: 0x06000328 RID: 808 RVA: 0x0005C01C File Offset: 0x00059C1C
	private void 95023AB5()
	{
		uint num;
		for (;;)
		{
			bool flag = this.16011CAB.F3AC8C0D().30B7A98C() != 0;
			num = 3198247687U;
			if (flag)
			{
				break;
			}
			if (num + 1065967493U != 0U)
			{
				goto Block_1;
			}
		}
		num -= 4127875752U;
		do
		{
			this.620F8223.181C1CA4();
			11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
			num &= 4231929247U;
			num -= 1379505185U;
			11AE0F91.80068AA5 268B972E = new 11AE0F91.1C16CD2C(this.70BBF99F);
			num = (722026376U ^ num);
			5F355D3D.07A52495(268B972E);
			11AE0F91.1280CA96 1280CA = this.4FA4D617;
			num = 2058544401U << (int)num;
			num /= 4263120151U;
			11AE0F91.628F1DA3 fe3CF = this.FE3CF238;
			num = 4096989229U - num;
			1280CA.37242F0A(fe3CF.1393F713());
		}
		while ((num ^ 3308521019U) == 0U);
		IL_9D:
		num = (168113548U | num);
		11AE0F91.628F1DA3 fe3CF2 = null;
		num <<= 4;
		this.FE3CF238 = fe3CF2;
		return;
		Block_1:
		this.5F16AE85();
		if (num * 3590866571U != 0U)
		{
			return;
		}
		goto IL_9D;
	}

	// Token: 0x06000329 RID: 809 RVA: 0x0005BCC8 File Offset: 0x000598C8
	private void 9F292EBD()
	{
		uint num;
		for (;;)
		{
			IL_00:
			num = 582157759U;
			11AE0F91.833BF530 833BF = this.4FA4D617;
			num = 3937521672U * num;
			int num2 = 833BF.99BB76A6();
			num *= 497648657U;
			int num3 = num2;
			for (;;)
			{
				IL_23:
				11AE0F91.833BF530 833BF2 = this.4FA4D617;
				11AE0F91.80068AA5 80068AA = this.16011CAB.F3AC8C0D();
				num = 2293424274U + num;
				int 1C850D8A = 80068AA.30B7A98C();
				num |= 1940360198U;
				833BF2.F43AFA0C(1C850D8A);
				List<int> list;
				for (;;)
				{
					IL_4E:
					list = new List<int>();
					for (;;)
					{
						IL_54:
						for (;;)
						{
							IL_163:
							num = (764542997U & num);
							num = 2526372363U * num;
							11AE0F91.6B1722AF 6B1722AF = this.620F8223;
							num %= 3191653638U;
							if (6B1722AF.21AF50A3() == 0)
							{
								goto IL_1C5;
							}
							num %= 1226874283U;
							if (2986968106U <= num)
							{
								goto IL_00;
							}
							int num4 = num3;
							num = 3490637089U * num;
							if (num4 <= this.620F8223.0E82BAB5().BD34EE0E())
							{
								goto Block_8;
							}
							num = 649655871U;
							11AE0F91.6B1722AF 6B1722AF2 = this.620F8223;
							num += 4019333128U;
							List<11AE0F91.628F1DA3> list2 = 6B1722AF2.181C1CA4().3B1EF53A();
							num <<= 13;
							List<11AE0F91.628F1DA3> list3 = list2;
							int num5 = (int)(num + 2620858368U);
							num %= 313291049U;
							int num6 = num5;
							if (1546782082U % num != 0U)
							{
								while (num <= 3174511537U)
								{
									if (num6 >= list3.Count)
									{
										num += 3985462235U;
										goto IL_163;
									}
									num = 4018833955U;
									List<11AE0F91.628F1DA3> list4 = list3;
									num <<= 27;
									int index = num6;
									num = 3263845818U % num;
									11AE0F91.628F1DA3 628F1DA = list4[index];
									num = (3096561431U & num);
									11AE0F91.628F1DA3 628F1DA2 = 628F1DA;
									byte b = 628F1DA2.DB0E7732();
									num >>= 7;
									uint num7 = num + 4294901624U;
									num = 318934442U % num;
									if (b == num7)
									{
										num /= 2836399286U;
										if (825561376U + num == 0U)
										{
											goto IL_23;
										}
										List<int> list5 = list;
										num >>= 10;
										list5.Add(628F1DA2.1393F713());
										num ^= 21498U;
									}
									if (num % 4256942476U == 0U)
									{
										goto IL_54;
									}
									int num8 = num6 + (int)(num - 21497U);
									num >>= 0;
									num6 = num8;
									num ^= 107674057U;
								}
								goto IL_4E;
							}
							goto IL_23;
						}
					}
				}
				IL_1C5:
				num = (1739883300U | num);
				int num9 = list.Count;
				while ((2953215166U & num) != 0U)
				{
					int num10 = num9;
					uint num11 = num ^ 4022307628U;
					num %= 1921774115U;
					if (num10 <= num11)
					{
						if ((num & 3248675118U) == 0U)
						{
							break;
						}
						Exception ex = null;
						num = 3416293803U << (int)num;
						this.70BBF99F = ex;
						num ^= 1368658064U;
						if (369765250U >> (int)num == 0U)
						{
							break;
						}
						this.16011CAB.0D034593();
						num = 1203757490U * num;
						if (60070331U + num != 0U)
						{
							goto Block_14;
						}
						goto IL_23;
					}
					else
					{
						num = 3903078035U;
						11AE0F91.833BF530 833BF3 = this.4FA4D617;
						num = 898913061U - num;
						List<int> list6 = list;
						int num12 = num9;
						num += 1815225904U;
						int num13 = (int)(num - 3106028225U);
						num = (2425038517U & num);
						int index2 = num12 - num13;
						num <<= 10;
						int 1C850D8A2 = list6[index2];
						num = 2923127591U % num;
						833BF3.F43AFA0C(1C850D8A2);
						if (3977788825U < num)
						{
							goto IL_23;
						}
						num9 -= (int)(num - 57893670U);
						num ^= 3972851723U;
					}
				}
				break;
				Block_8:
				num += 210252438U;
				goto IL_1C5;
			}
		}
		Block_14:
		num %= 3426612905U;
		this.4FA4D617.73A4C02F();
	}

	// Token: 0x0600032A RID: 810 RVA: 0x000567EC File Offset: 0x000543EC
	private void 2309EC22()
	{
		uint num = 1142335748U;
		11AE0F91.80068AA5 80068AA2;
		11AE0F91.80068AA5 80068AA3;
		for (;;)
		{
			11AE0F91.80068AA5 80068AA = this.16011CAB.F3AC8C0D();
			num <<= 24;
			80068AA2 = 80068AA;
			num &= 909808561U;
			if ((num ^ 4245788058U) != 0U)
			{
				num = 1711484708U << (int)num;
				80068AA3 = this.16011CAB.F3AC8C0D();
				if (num - 162806668U != 0U)
				{
					break;
				}
			}
		}
		num /= 1184009132U;
		11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
		11AE0F91.80068AA5 d3AF13BE = 80068AA3;
		num >>= 16;
		11AE0F91.80068AA5 b7B = 80068AA2;
		num |= 3509633593U;
		11AE0F91.80068AA5 268B972E = 11AE0F91.122C9D2C.ABBDD91C(d3AF13BE, b7B);
		num *= 2208597271U;
		5F355D3D.07A52495(268B972E);
	}

	// Token: 0x0600032B RID: 811 RVA: 0x00055700 File Offset: 0x00053300
	private MemberInfo 68B43D97(int E58000BA)
	{
		uint num = 1278170380U;
		Dictionary<uint, object> a314EB = 11AE0F91.A314EB83;
		bool flag = (num ^ 1278170380U) != 0U;
		num = 423376910U * num;
		bool flag2 = flag;
		MemberInfo result;
		try
		{
			num = 2166820912U * num;
			if (4211478570U == num)
			{
				goto IL_D7;
			}
			do
			{
				IL_37:
				object obj = a314EB;
				num |= 833515265U;
				num &= 2646099770U;
				Monitor.Enter(obj, ref flag2);
				num <<= 3;
			}
			while (num << 12 == 0U);
			object obj2;
			do
			{
				num &= 3171864337U;
				num *= 3131987102U;
				if ((num ^ 4104217122U) == 0U)
				{
					goto IL_D2;
				}
				Dictionary<uint, object> a314EB2 = 11AE0F91.A314EB83;
				num = 3710128256U - num;
				bool flag3 = a314EB2.TryGetValue((uint)E58000BA, out obj2);
				num = 2627187005U + num;
				if (!flag3)
				{
					goto IL_D7;
				}
			}
			while ((num ^ 1361261998U) == 0U);
			MemberInfo memberInfo = (MemberInfo)obj2;
			num += 1352798854U;
			result = memberInfo;
			IL_D2:
			return result;
			IL_D7:
			num = 3980351140U << (int)num;
			Module module = 11AE0F91.08BC110D;
			num = (2704822U & num);
			MemberInfo memberInfo2 = module.ResolveMember(E58000BA);
			num = (731275312U & num);
			MemberInfo memberInfo3 = memberInfo2;
			num = 3182487072U << (int)num;
			if (num == 3666643984U)
			{
				goto IL_37;
			}
			Dictionary<uint, object> a314EB3 = 11AE0F91.A314EB83;
			num = 4035921330U % num;
			a314EB3.Add((uint)E58000BA, memberInfo3);
			if (num << 2 == 0U)
			{
				goto IL_37;
			}
			MemberInfo memberInfo4 = memberInfo3;
			num = (1392956675U ^ num);
			result = memberInfo4;
			if (1595744798U > num)
			{
				goto IL_37;
			}
		}
		finally
		{
			bool flag4 = flag2;
			num = 1242853807U;
			if (flag4)
			{
				num -= 2813584933U;
				object obj3 = a314EB;
				num = 975088437U >> (int)num;
				Monitor.Exit(obj3);
				num ^= 1243280901U;
			}
		}
		return result;
	}

	// Token: 0x0600032C RID: 812 RVA: 0x00056A38 File Offset: 0x00054638
	private void DF044EB1()
	{
		uint num = 2285500061U;
		11AE0F91.80068AA5 80068AA;
		11AE0F91.80068AA5 80068AA2;
		if (3039109950U > num)
		{
			for (;;)
			{
				80068AA = this.16011CAB.F3AC8C0D();
				num %= 3290427670U;
				if (1604146959U >> (int)num != 0U)
				{
					80068AA2 = this.16011CAB.F3AC8C0D();
					num += 1999063992U;
					if ((num ^ 2593007910U) != 0U)
					{
						break;
					}
				}
			}
		}
		11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
		11AE0F91.80068AA5 3896021B = 80068AA2;
		num = 254645784U + num;
		11AE0F91.80068AA5 9B1CB49F = 80068AA;
		num = 2258252722U / num;
		5F355D3D.07A52495(11AE0F91.8A270C3B.5E02AC2A(3896021B, 9B1CB49F));
	}

	// Token: 0x0600032D RID: 813 RVA: 0x0005C0FC File Offset: 0x00059CFC
	private void 590600A6()
	{
		uint num = 1991324213U;
		Type type = this.50932DAD(this.4FA4D617.99BB76A6());
		num = 641319199U * num;
		Type 31130EB = type;
		11AE0F91.80068AA5 80068AA2;
		if (3255596086U > num)
		{
			num %= 372916866U;
			11AE0F91.80068AA5 80068AA = this.16011CAB.F3AC8C0D();
			num = (3517216165U ^ num);
			80068AA2 = 80068AA;
			num = (1669549969U ^ num);
		}
		num = 489381764U * num;
		11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
		num >>= 10;
		object 8237D7A = 80068AA2.01245B13(31130EB).D697DB31();
		num = 2503839879U / num;
		5F355D3D.07A52495(new 11AE0F91.1C16CD2C(8237D7A));
	}

	// Token: 0x0600032E RID: 814 RVA: 0x0005832C File Offset: 0x00055F2C
	private void CA356E84()
	{
		uint num = 3064994196U;
		for (;;)
		{
			11AE0F91.80068AA5 80068AA = this.16011CAB.F3AC8C0D();
			num /= 1958061319U;
			11AE0F91.80068AA5 3C9294A = 80068AA;
			if (4022300989U > num)
			{
				11AE0F91.5F355D3D 5F355D3D = this.16011CAB;
				num -= 3417654170U;
				5F355D3D.07A52495(new 11AE0F91.B7939DAF(3C9294A));
				if ((3230124204U ^ num) != 0U)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600032F RID: 815 RVA: 0x00050FF8 File Offset: 0x0004EBF8
	public 11AE0F91()
	{
		uint num = 909671188U;
		do
		{
			IL_06:
			num %= 3952456891U;
			Dictionary<uint, 11AE0F91.E489CC87> dictionary = new Dictionary<uint, 11AE0F91.E489CC87>();
			num = (3708639935U | num);
			this.891D0FB6 = dictionary;
			num = 1795578375U * num;
			for (;;)
			{
				IL_29:
				11AE0F91.833BF530 833BF = new 11AE0F91.833BF530();
				num = 2661145110U + num;
				this.4FA4D617 = 833BF;
				for (;;)
				{
					IL_3C:
					num = (371830458U & num);
					this.16011CAB = new 11AE0F91.5F355D3D();
					num = 3506509722U + num;
					if ((931163169U ^ num) == 0U)
					{
						goto IL_06;
					}
					for (;;)
					{
						IL_63:
						this.620F8223 = new 11AE0F91.6B1722AF();
						for (;;)
						{
							IL_6E:
							num = (3775507722U ^ num);
							this.93160723 = new List<IntPtr>();
							num ^= 3577567289U;
							for (;;)
							{
								num = 1705099782U - num;
								base..ctor();
								if ((num ^ 3124012187U) == 0U)
								{
									goto IL_29;
								}
								for (;;)
								{
									Dictionary<uint, 11AE0F91.E489CC87> dictionary2 = this.891D0FB6;
									uint key = num - 2389374319U;
									num = (2788947107U & num);
									dictionary2[key] = new 11AE0F91.E489CC87(this.DFB9313F);
									num = 1991484436U % num;
									if (3837720708U + num == 0U)
									{
										goto IL_29;
									}
									do
									{
										num ^= 649399315U;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary3 = this.891D0FB6;
										uint key2 = num ^ 1342613510U;
										num %= 2830808596U;
										IntPtr 09069C1A = ldftn(C535480E);
										num = 723339912U + num;
										dictionary3[key2] = new 11AE0F91.E489CC87(this, 09069C1A);
										num %= 2235489027U;
										if (num == 2545661744U)
										{
											goto IL_3C;
										}
										num = 1847799204U - num;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary4 = this.891D0FB6;
										uint key3 = num ^ 4076813079U;
										num <<= 24;
										IntPtr 09069C1A2 = ldftn(712AC49C);
										num = 1059864123U + num;
										11AE0F91.E489CC87 value = new 11AE0F91.E489CC87(this, 09069C1A2);
										num = 3417828276U % num;
										dictionary4[key3] = value;
										if (2567544985U == num)
										{
											goto IL_06;
										}
										num /= 4004739974U;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary5 = this.891D0FB6;
										num -= 3006079384U;
										uint key4 = num - 1288887909U;
										IntPtr 09069C1A3 = ldftn(FCA67381);
										num = 3568333323U << (int)num;
										11AE0F91.E489CC87 value2 = new 11AE0F91.E489CC87(this, 09069C1A3);
										num = 1841137575U % num;
										dictionary5[key4] = value2;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary6 = this.891D0FB6;
										num = (1848675893U ^ num);
										uint key5 = num + 4235392626U;
										num <<= 12;
										IntPtr 09069C1A4 = ldftn(95023AB5);
										num |= 2947086361U;
										11AE0F91.E489CC87 value3 = new 11AE0F91.E489CC87(this, 09069C1A4);
										num %= 1779859460U;
										dictionary6[key5] = value3;
										num = (1581107356U | num);
										if (num >= 2703067547U)
										{
											goto IL_06;
										}
										num = 1748206872U * num;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary7 = this.891D0FB6;
										num = (2326035357U ^ num);
										uint key6 = num ^ 1906025504U;
										num = (1015284496U ^ num);
										IntPtr 09069C1A5 = ldftn(5DADD105);
										num = (3650177720U & num);
										11AE0F91.E489CC87 value4 = new 11AE0F91.E489CC87(this, 09069C1A5);
										num = (833597102U ^ num);
										dictionary7[key6] = value4;
										num = (700422544U & num);
										Dictionary<uint, 11AE0F91.E489CC87> dictionary8 = this.891D0FB6;
										uint key7 = num + 3611391862U;
										num += 1018528037U;
										IntPtr 09069C1A6 = ldftn(452387B5);
										num %= 1606270901U;
										11AE0F91.E489CC87 value5 = new 11AE0F91.E489CC87(this, 09069C1A6);
										num = 2142339218U - num;
										dictionary8[key7] = value5;
										num = 3266115977U >> (int)num;
										if (num == 3367788350U)
										{
											goto IL_06;
										}
										Dictionary<uint, 11AE0F91.E489CC87> dictionary9 = this.891D0FB6;
										uint key8 = num ^ 12460U;
										IntPtr 09069C1A7 = ldftn(CA3A9E35);
										num = 2713031689U - num;
										dictionary9[key8] = new 11AE0F91.E489CC87(this, 09069C1A7);
										if (num < 168626742U)
										{
											goto IL_06;
										}
										num = (2293456256U | num);
										Dictionary<uint, 11AE0F91.E489CC87> dictionary10 = this.891D0FB6;
										uint key9 = num + 1447591978U;
										num = 3565289363U + num;
										IntPtr 09069C1A8 = ldftn(22843BA6);
										num <<= 22;
										11AE0F91.E489CC87 value6 = new 11AE0F91.E489CC87(this, 09069C1A8);
										num = 4219549983U / num;
										dictionary10[key9] = value6;
										num <<= 10;
										if (num % 3777292460U == 0U)
										{
											goto IL_63;
										}
										num *= 445933747U;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary11 = this.891D0FB6;
										num = 2601928324U * num;
										uint key10 = num + 3695628297U;
										IntPtr 09069C1A9 = ldftn(772BCFA3);
										num = 892731172U / num;
										dictionary11[key10] = new 11AE0F91.E489CC87(this, 09069C1A9);
										num = 3901141636U >> (int)num;
										if (num > 2939173010U)
										{
											goto IL_06;
										}
										Dictionary<uint, 11AE0F91.E489CC87> dictionary12 = this.891D0FB6;
										num = 3263464631U << (int)num;
										uint key11 = num - 168956626U;
										num = (385957419U | num);
										IntPtr 09069C1A10 = ldftn(7D1F7D2C);
										num = (4195894962U & num);
										11AE0F91.E489CC87 value7 = new 11AE0F91.E489CC87(this, 09069C1A10);
										num /= 387684795U;
										dictionary12[key11] = value7;
										if (3367110962U <= num)
										{
											goto IL_06;
										}
										Dictionary<uint, 11AE0F91.E489CC87> dictionary13 = this.891D0FB6;
										num /= 3055188256U;
										uint key12 = num ^ 11U;
										num -= 455107850U;
										dictionary13[key12] = new 11AE0F91.E489CC87(this.2309EC22);
										num |= 713327648U;
										if ((2947856303U & num) == 0U)
										{
											goto IL_29;
										}
										num *= 2132654995U;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary14 = this.891D0FB6;
										num >>= 9;
										uint key13 = num - 4698608U;
										num <<= 26;
										num = 3667676336U + num;
										dictionary14[key13] = new 11AE0F91.E489CC87(this.BC828E8C);
										num = (1343853481U | num);
										if (1765695274U == num)
										{
											goto IL_63;
										}
										Dictionary<uint, 11AE0F91.E489CC87> dictionary15 = this.891D0FB6;
										uint key14 = num ^ 3667779508U;
										IntPtr 09069C1A11 = ldftn(CA356E84);
										num = 1589419453U - num;
										dictionary15[key14] = new 11AE0F91.E489CC87(this, 09069C1A11);
										if ((522534155U ^ num) == 0U)
										{
											goto IL_29;
										}
										Dictionary<uint, 11AE0F91.E489CC87> dictionary16 = this.891D0FB6;
										uint key15 = num ^ 2216607242U;
										num = (1488945208U & num);
										num %= 4206011434U;
										11AE0F91.E489CC87 value8 = new 11AE0F91.E489CC87(this.17110522);
										num = 2385669306U % num;
										dictionary16[key15] = value8;
										if (1713449777U - num == 0U)
										{
											goto IL_06;
										}
										Dictionary<uint, 11AE0F91.E489CC87> dictionary17 = this.891D0FB6;
										num = 3770128768U + num;
										uint key16 = num ^ 3771172405U;
										num = 1174929973U % num;
										IntPtr 09069C1A12 = ldftn(78B2EE3B);
										num = 2844171672U - num;
										11AE0F91.E489CC87 value9 = new 11AE0F91.E489CC87(this, 09069C1A12);
										num = 1631097776U + num;
										dictionary17[key16] = value9;
										num = (2426609466U | num);
										if (1300778815U >= num)
										{
											goto IL_06;
										}
										Dictionary<uint, 11AE0F91.E489CC87> dictionary18 = this.891D0FB6;
										uint key17 = num - 3568779051U;
										num %= 1283864194U;
										num = 790671884U / num;
										dictionary18[key17] = new 11AE0F91.E489CC87(this.58150F83);
										if ((2694099389U ^ num) == 0U)
										{
											goto IL_06;
										}
										Dictionary<uint, 11AE0F91.E489CC87> dictionary19 = this.891D0FB6;
										uint key18 = num ^ 17U;
										num = 673502093U - num;
										IntPtr 09069C1A13 = ldftn(AABE0611);
										num <<= 18;
										11AE0F91.E489CC87 value10 = new 11AE0F91.E489CC87(this, 09069C1A13);
										num = 1689453230U - num;
										dictionary19[key18] = value10;
										if (1134694420U == num)
										{
											goto IL_29;
										}
										Dictionary<uint, 11AE0F91.E489CC87> dictionary20 = this.891D0FB6;
										uint key19 = num - 377422492U;
										num = 154697663U / num;
										IntPtr 09069C1A14 = ldftn(9C38BD9E);
										num = 2760767166U + num;
										dictionary20[key19] = new 11AE0F91.E489CC87(this, 09069C1A14);
										num &= 3401378563U;
										num ^= 547902107U;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary21 = this.891D0FB6;
										num &= 4229408184U;
										uint key20 = num ^ 2684657803U;
										11AE0F91.E489CC87 value11 = new 11AE0F91.E489CC87(this.21BF3795);
										num /= 2483272238U;
										dictionary21[key20] = value11;
										num = (4223345677U | num);
										if (1159766817U == num)
										{
											goto IL_06;
										}
										num += 3256782130U;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary22 = this.891D0FB6;
										num ^= 773966641U;
										uint key21 = num ^ 2482534938U;
										num &= 1404014721U;
										num *= 2777490216U;
										dictionary22[key21] = new 11AE0F91.E489CC87(this.2B984BB5);
										num >>= 31;
										num |= 2250541060U;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary23 = this.891D0FB6;
										uint key22 = num + 2044426256U;
										num = (2349704212U & num);
										IntPtr 09069C1A15 = ldftn(C8089F07);
										num &= 1696783616U;
										11AE0F91.E489CC87 value12 = new 11AE0F91.E489CC87(this, 09069C1A15);
										num = (4030032807U | num);
										dictionary23[key22] = value12;
										if (num / 732926132U == 0U)
										{
											goto IL_29;
										}
										num = 212460043U << (int)num;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary24 = this.891D0FB6;
										num &= 2425570347U;
										uint key23 = num ^ 277939222U;
										num = (4265393185U & num);
										11AE0F91.E489CC87 value13 = new 11AE0F91.E489CC87(this.07B2F3A6);
										num = (20382866U | num);
										dictionary24[key23] = value13;
										if (1343424805U * num == 0U)
										{
											goto IL_29;
										}
										num = 1099285666U * num;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary25 = this.891D0FB6;
										num = 3021227393U / num;
										dictionary25[num + 22U] = new 11AE0F91.E489CC87(this.0C0392BB);
										num <<= 28;
										if (num > 415119410U)
										{
											goto IL_29;
										}
										Dictionary<uint, 11AE0F91.E489CC87> dictionary26 = this.891D0FB6;
										num = 1058841143U / num;
										uint key24 = num ^ 27U;
										num = 850910498U + num;
										11AE0F91.E489CC87 value14 = new 11AE0F91.E489CC87(this.CB96929A);
										num = 134280600U >> (int)num;
										dictionary26[key24] = value14;
										num &= 3649657405U;
										if ((num ^ 4136013857U) == 0U)
										{
											goto IL_63;
										}
										Dictionary<uint, 11AE0F91.E489CC87> dictionary27 = this.891D0FB6;
										uint key25 = num ^ 565U;
										num |= 2032604729U;
										num ^= 3919829639U;
										11AE0F91.E489CC87 value15 = new 11AE0F91.E489CC87(this.8220A112);
										num *= 1822217862U;
										dictionary27[key25] = value15;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary28 = this.891D0FB6;
										num = 2518308628U + num;
										uint key26 = num ^ 2014903402U;
										num = (179756972U | num);
										num /= 2074271631U;
										11AE0F91.E489CC87 value16 = new 11AE0F91.E489CC87(this.62AE5307);
										num *= 1327668736U;
										dictionary28[key26] = value16;
										if (num > 2971579393U)
										{
											goto IL_29;
										}
										num |= 2175992242U;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary29 = this.891D0FB6;
										uint key27 = num + 2118975081U;
										IntPtr 09069C1A16 = ldftn(B0337393);
										num = 3232268041U % num;
										dictionary29[key27] = new 11AE0F91.E489CC87(this, 09069C1A16);
										num = 296646441U - num;
										if (num == 657851421U)
										{
											goto IL_06;
										}
										num &= 1577115U;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary30 = this.891D0FB6;
										uint key28 = num - 1577078U;
										num *= 2198606239U;
										11AE0F91.E489CC87 value17 = new 11AE0F91.E489CC87(this.7305983E);
										num = 3994710786U << (int)num;
										dictionary30[key28] = value17;
										num |= 1630122175U;
										num >>= 15;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary31 = this.891D0FB6;
										uint key29 = num ^ 129998U;
										IntPtr 09069C1A17 = ldftn(662F9C1D);
										num /= 1470483464U;
										dictionary31[key29] = new 11AE0F91.E489CC87(this, 09069C1A17);
										num *= 1737844654U;
										if (num % 1267074454U != 0U)
										{
											goto IL_06;
										}
										Dictionary<uint, 11AE0F91.E489CC87> dictionary32 = this.891D0FB6;
										num = (2669404800U | num);
										uint key30 = num ^ 2669404830U;
										IntPtr 09069C1A18 = ldftn(199380B8);
										num += 4127531957U;
										11AE0F91.E489CC87 value18 = new 11AE0F91.E489CC87(this, 09069C1A18);
										num *= 4205774124U;
										dictionary32[key30] = value18;
										num >>= 6;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary33 = this.891D0FB6;
										num = 3414929431U << (int)num;
										uint key31 = num - 2343573217U;
										num = 704684057U - num;
										IntPtr 09069C1A19 = ldftn(DC901D88);
										num = 725511702U << (int)num;
										11AE0F91.E489CC87 value19 = new 11AE0F91.E489CC87(this, 09069C1A19);
										num += 671450541U;
										dictionary33[key31] = value19;
										num = 2082310443U + num;
										num &= 1646164387U;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary34 = this.891D0FB6;
										uint key32 = num ^ 1073875104U;
										num = 1134069302U + num;
										dictionary34[key32] = new 11AE0F91.E489CC87(this.AA3ACF94);
										Dictionary<uint, 11AE0F91.E489CC87> dictionary35 = this.891D0FB6;
										uint key33 = num - 2207944341U;
										IntPtr 09069C1A20 = ldftn(DF044EB1);
										num >>= 15;
										dictionary35[key33] = new 11AE0F91.E489CC87(this, 09069C1A20);
										num = 893307927U >> (int)num;
										num = 145495094U + num;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary36 = this.891D0FB6;
										uint key34 = num - 145495485U;
										num &= 1286299273U;
										IntPtr 09069C1A21 = ldftn(8F0B263F);
										num >>= 18;
										11AE0F91.E489CC87 value20 = new 11AE0F91.E489CC87(this, 09069C1A21);
										num = (916833462U ^ num);
										dictionary36[key34] = value20;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary37 = this.891D0FB6;
										uint key35 = num - 916833913U;
										num = 2443499651U % num;
										IntPtr 09069C1A22 = ldftn(BB89E48C);
										num = (1253932827U & num);
										11AE0F91.E489CC87 value21 = new 11AE0F91.E489CC87(this, 09069C1A22);
										num /= 873134373U;
										dictionary37[key35] = value21;
										if (num - 4012228107U == 0U)
										{
											goto IL_29;
										}
										num = 3057560870U << (int)num;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary38 = this.891D0FB6;
										uint key36 = num ^ 3057560834U;
										IntPtr 09069C1A23 = ldftn(FA2F4684);
										num = 3552344990U + num;
										11AE0F91.E489CC87 value22 = new 11AE0F91.E489CC87(this, 09069C1A23);
										num -= 3364230310U;
										dictionary38[key36] = value22;
										num = (1653617964U ^ num);
										Dictionary<uint, 11AE0F91.E489CC87> dictionary39 = this.891D0FB6;
										uint key37 = num ^ 2749702423U;
										num = (1914856212U | num);
										num = 3657929608U + num;
										IntPtr 09069C1A24 = ldftn(0DAF2509);
										num = 2444458668U * num;
										11AE0F91.E489CC87 value23 = new 11AE0F91.E489CC87(this, 09069C1A24);
										num -= 1686890647U;
										dictionary39[key37] = value23;
										num = 2712698280U / num;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary40 = this.891D0FB6;
										uint key38 = num ^ 38U;
										IntPtr 09069C1A25 = ldftn(772BCFA3);
										num %= 2813353090U;
										dictionary40[key38] = new 11AE0F91.E489CC87(this, 09069C1A25);
										num = 3944601485U - num;
										num = 2720298402U / num;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary41 = this.891D0FB6;
										uint key39 = num ^ 39U;
										num = 76643984U >> (int)num;
										num = (2483913492U | num);
										dictionary41[key39] = new 11AE0F91.E489CC87(this.7F0E3C35);
										num = 574279066U * num;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary42 = this.891D0FB6;
										uint key40 = num ^ 2084389664U;
										num = 2216439055U - num;
										dictionary42[key40] = new 11AE0F91.E489CC87(this.4F3336A2);
										num /= 2097233852U;
										if (num << 8 != 0U)
										{
											goto IL_06;
										}
										Dictionary<uint, 11AE0F91.E489CC87> dictionary43 = this.891D0FB6;
										uint key41 = num ^ 41U;
										11AE0F91.E489CC87 value24 = new 11AE0F91.E489CC87(this.AABEDF2C);
										num = (1412853544U | num);
										dictionary43[key41] = value24;
										if (2761081479U <= num)
										{
											goto IL_06;
										}
										num = 3844581542U * num;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary44 = this.891D0FB6;
										num &= 1426495247U;
										uint key42 = num ^ 17175338U;
										num = 1955379474U * num;
										num &= 2627820578U;
										dictionary44[key42] = new 11AE0F91.E489CC87(this.3F1DE48B);
										if (num < 514775077U)
										{
											goto IL_29;
										}
										Dictionary<uint, 11AE0F91.E489CC87> dictionary45 = this.891D0FB6;
										num = 3309184266U + num;
										uint key43 = num ^ 1566472481U;
										num = 2830170773U / num;
										IntPtr 09069C1A26 = ldftn(AF3315A2);
										num <<= 17;
										dictionary45[key43] = new 11AE0F91.E489CC87(this, 09069C1A26);
										num = 92733479U / num;
										if (num == 497394620U)
										{
											goto IL_29;
										}
										Dictionary<uint, 11AE0F91.E489CC87> dictionary46 = this.891D0FB6;
										uint key44 = num ^ 751U;
										num = 1696282123U - num;
										num %= 1235420823U;
										IntPtr 09069C1A27 = ldftn(E91AE9BE);
										num = 1538480791U - num;
										dictionary46[key44] = new 11AE0F91.E489CC87(this, 09069C1A27);
										num = 948394882U + num;
										if (3641698970U * num == 0U)
										{
											goto IL_63;
										}
										Dictionary<uint, 11AE0F91.E489CC87> dictionary47 = this.891D0FB6;
										uint key45 = num - 2026015035U;
										num = 277390083U / num;
										IntPtr 09069C1A28 = ldftn(BE1E5493);
										num = 2234415260U << (int)num;
										11AE0F91.E489CC87 value25 = new 11AE0F91.E489CC87(this, 09069C1A28);
										num = (4044791588U ^ num);
										dictionary47[key45] = value25;
										if (488438415U >= num)
										{
											goto IL_06;
										}
										num += 3624818620U;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary48 = this.891D0FB6;
										uint key46 = num ^ 1279737690U;
										num = 2869686296U / num;
										IntPtr 09069C1A29 = ldftn(9E8D6895);
										num |= 1847540356U;
										11AE0F91.E489CC87 value26 = new 11AE0F91.E489CC87(this, 09069C1A29);
										num = (4127689619U & num);
										dictionary48[key46] = value26;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary49 = this.891D0FB6;
										num ^= 1663414963U;
										uint key47 = num - 86161410U;
										num ^= 3072609050U;
										num |= 1434603059U;
										IntPtr 09069C1A30 = ldftn(089A8488);
										num %= 3802503867U;
										dictionary49[key47] = new 11AE0F91.E489CC87(this, 09069C1A30);
										num >>= 19;
										num = 4044466962U % num;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary50 = this.891D0FB6;
										num &= 1913189408U;
										uint key48 = num - 4294967280U;
										num %= 3381102090U;
										IntPtr 09069C1A31 = ldftn(E90838A9);
										num = 949072392U % num;
										11AE0F91.E489CC87 value27 = new 11AE0F91.E489CC87(this, 09069C1A31);
										num /= 1704796851U;
										dictionary50[key48] = value27;
										num ^= 530298759U;
										num |= 2576839947U;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary51 = this.891D0FB6;
										uint key49 = num ^ 2678060990U;
										11AE0F91.E489CC87 value28 = new 11AE0F91.E489CC87(this.41A6CA0C);
										num ^= 3542381204U;
										dictionary51[key49] = value28;
										num = 1285162677U + num;
										if (3569202206U + num == 0U)
										{
											goto IL_06;
										}
										num <<= 22;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary52 = this.891D0FB6;
										uint key50 = num - 4093640654U;
										num &= 2358152751U;
										IntPtr 09069C1A32 = ldftn(FDBC0105);
										num = 2265343522U + num;
										dictionary52[key50] = new 11AE0F91.E489CC87(this, 09069C1A32);
										num &= 3759135246U;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary53 = this.891D0FB6;
										uint key51 = num + 4294557233U;
										11AE0F91.E489CC87 value29 = new 11AE0F91.E489CC87(this.9009AF06);
										num *= 1839412112U;
										dictionary53[key51] = value29;
										num = 430377775U * num;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary54 = this.891D0FB6;
										num ^= 3442173368U;
										uint key52 = num ^ 2368555884U;
										num = 3708913560U * num;
										num = 1732148369U / num;
										IntPtr 09069C1A33 = ldftn(8FB9EF9F);
										num = (3819647280U ^ num);
										11AE0F91.E489CC87 value30 = new 11AE0F91.E489CC87(this, 09069C1A33);
										num *= 1680061588U;
										dictionary54[key52] = value30;
										if (873558568U * num == 0U)
										{
											goto IL_06;
										}
										num = 118111500U * num;
										this.891D0FB6[num ^ 3830119733U] = new 11AE0F91.E489CC87(this.FC8F3F05);
										if ((3223824673U & num) == 0U)
										{
											goto IL_06;
										}
										num &= 2553316396U;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary55 = this.891D0FB6;
										num = 1999709577U >> (int)num;
										uint key53 = num ^ 1999709631U;
										num = 1839626147U << (int)num;
										dictionary55[key53] = new 11AE0F91.E489CC87(this.61814CA6);
										num *= 138324364U;
										num |= 2529010840U;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary56 = this.891D0FB6;
										num = 992276118U / num;
										dictionary56[num ^ 55U] = new 11AE0F91.E489CC87(this.590600A6);
										num -= 1881837072U;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary57 = this.891D0FB6;
										num = 2721054628U - num;
										uint key54 = num - 307924348U;
										num += 102350890U;
										IntPtr 09069C1A34 = ldftn(B7A5FF1A);
										num >>= 26;
										11AE0F91.E489CC87 value31 = new 11AE0F91.E489CC87(this, 09069C1A34);
										num ^= 4189875861U;
										dictionary57[key54] = value31;
										if (2433625396U + num == 0U)
										{
											goto IL_29;
										}
										num ^= 3432988716U;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary58 = this.891D0FB6;
										num -= 159729185U;
										uint key55 = num ^ 731768999U;
										IntPtr 09069C1A35 = ldftn(ED399CB1);
										num &= 3121992343U;
										dictionary58[key55] = new 11AE0F91.E489CC87(this, 09069C1A35);
										Dictionary<uint, 11AE0F91.E489CC87> dictionary59 = this.891D0FB6;
										num = (3778708105U | num);
										dictionary59[num + 348143003U] = new 11AE0F91.E489CC87(this.6F91C53F);
										num ^= 363054116U;
										if (2753255211U / num != 0U)
										{
											goto IL_06;
										}
										num = 3316407960U % num;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary60 = this.891D0FB6;
										num |= 2234981823U;
										uint key56 = num + 977313916U;
										num /= 3466770184U;
										IntPtr 09069C1A36 = ldftn(39A40BB7);
										num %= 1032453274U;
										dictionary60[key56] = new 11AE0F91.E489CC87(this, 09069C1A36);
										num %= 1285534390U;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary61 = this.891D0FB6;
										uint key57 = num ^ 60U;
										11AE0F91.E489CC87 value32 = new 11AE0F91.E489CC87(this.DBA82680);
										num = (3558794882U ^ num);
										dictionary61[key57] = value32;
									}
									while (1806843452U - num == 0U);
									num -= 3430998194U;
									Dictionary<uint, 11AE0F91.E489CC87> dictionary62 = this.891D0FB6;
									uint key58 = num + 4167170669U;
									IntPtr 09069C1A37 = ldftn(5701C228);
									num = (3816929046U & num);
									dictionary62[key58] = new 11AE0F91.E489CC87(this, 09069C1A37);
									num = 3677036559U * num;
									num += 186492963U;
									Dictionary<uint, 11AE0F91.E489CC87> dictionary63 = this.891D0FB6;
									uint key59 = num - 3387945941U;
									11AE0F91.E489CC87 value33 = new 11AE0F91.E489CC87(this.0717C01B);
									num %= 708167317U;
									dictionary63[key59] = value33;
									num -= 33792931U;
									Dictionary<uint, 11AE0F91.E489CC87> dictionary64 = this.891D0FB6;
									num += 3214084774U;
									uint key60 = num + 559398781U;
									11AE0F91.E489CC87 value34 = new 11AE0F91.E489CC87(this.51AF9930);
									num = (4288718392U ^ num);
									dictionary64[key60] = value34;
									num >>= 15;
									if (num >> 27 != 0U)
									{
										goto IL_63;
									}
									Dictionary<uint, 11AE0F91.E489CC87> dictionary65 = this.891D0FB6;
									uint key61 = num ^ 16977U;
									num = (1027260455U ^ num);
									num *= 2720568220U;
									IntPtr 09069C1A38 = ldftn(5C22D991);
									num = 4062334117U + num;
									dictionary65[key61] = new 11AE0F91.E489CC87(this, 09069C1A38);
									num ^= 297611683U;
									Dictionary<uint, 11AE0F91.E489CC87> dictionary66 = this.891D0FB6;
									num %= 504638264U;
									uint key62 = num - 320552829U;
									num = (898883464U & num);
									num += 1855720501U;
									IntPtr 09069C1A39 = ldftn(AEBF8284);
									num = 1688922133U << (int)num;
									dictionary66[key62] = new 11AE0F91.E489CC87(this, 09069C1A39);
									Dictionary<uint, 11AE0F91.E489CC87> dictionary67 = this.891D0FB6;
									uint key63 = num + 1610612802U;
									IntPtr 09069C1A40 = ldftn(F61F83A8);
									num <<= 30;
									11AE0F91.E489CC87 value35 = new 11AE0F91.E489CC87(this, 09069C1A40);
									num += 1100774193U;
									dictionary67[key63] = value35;
									num -= 3266055606U;
									Dictionary<uint, 11AE0F91.E489CC87> dictionary68 = this.891D0FB6;
									num %= 2308458636U;
									uint key64 = num - 2129685816U;
									num = 3652058514U + num;
									IntPtr 09069C1A41 = ldftn(C90E4819);
									num = 3223605660U % num;
									dictionary68[key64] = new 11AE0F91.E489CC87(this, 09069C1A41);
									num = 767036545U / num;
									Dictionary<uint, 11AE0F91.E489CC87> dictionary69 = this.891D0FB6;
									num = 3651834146U + num;
									uint key65 = num ^ 3651834209U;
									11AE0F91.E489CC87 value36 = new 11AE0F91.E489CC87(this.30382632);
									num <<= 8;
									dictionary69[key65] = value36;
									num = (1595980559U & num);
									Dictionary<uint, 11AE0F91.E489CC87> dictionary70 = this.891D0FB6;
									num %= 1234725311U;
									uint key66 = num ^ 167780677U;
									num |= 755649687U;
									dictionary70[key66] = new 11AE0F91.E489CC87(this.002924BC);
									num |= 2190576659U;
									num = 2014146870U << (int)num;
									Dictionary<uint, 11AE0F91.E489CC87> dictionary71 = this.891D0FB6;
									uint key67 = num + 1694498886U;
									IntPtr 09069C1A42 = ldftn(1F26AF94);
									num = 439116582U + num;
									dictionary71[key67] = new 11AE0F91.E489CC87(this, 09069C1A42);
									num -= 867990433U;
									if (num == 68089279U)
									{
										goto IL_06;
									}
									Dictionary<uint, 11AE0F91.E489CC87> dictionary72 = this.891D0FB6;
									num = (2822316298U ^ num);
									uint key68 = num + 3601414584U;
									num |= 3265650742U;
									num /= 2483638332U;
									IntPtr 09069C1A43 = ldftn(E0194BA5);
									num /= 1108572708U;
									11AE0F91.E489CC87 value37 = new 11AE0F91.E489CC87(this, 09069C1A43);
									num /= 1116119335U;
									dictionary72[key68] = value37;
									num = 2659549701U >> (int)num;
									num = (831100067U | num);
									Dictionary<uint, 11AE0F91.E489CC87> dictionary73 = this.891D0FB6;
									num ^= 3884009772U;
									uint key69 = num ^ 1477238723U;
									num -= 4288039685U;
									11AE0F91.E489CC87 value38 = new 11AE0F91.E489CC87(this.2227AD16);
									num -= 2461188994U;
									dictionary73[key69] = value38;
									num &= 3390984721U;
									if (2719052583U == num)
									{
										goto IL_29;
									}
									num = 1077855360U + num;
									Dictionary<uint, 11AE0F91.E489CC87> dictionary74 = this.891D0FB6;
									num += 2600963857U;
									uint key70 = num + 1689738424U;
									num = 3490457255U + num;
									num &= 2797013278U;
									IntPtr 09069C1A44 = ldftn(DE89C0B1);
									num = 246195884U - num;
									11AE0F91.E489CC87 value39 = new 11AE0F91.E489CC87(this, 09069C1A44);
									num = (1654956180U & num);
									dictionary74[key70] = value39;
									if (3837718949U < num)
									{
										goto IL_06;
									}
									Dictionary<uint, 11AE0F91.E489CC87> dictionary75 = this.891D0FB6;
									num = (2184679811U ^ num);
									uint key71 = num ^ 3803648349U;
									num = 2702804794U - num;
									11AE0F91.E489CC87 value40 = new 11AE0F91.E489CC87(this.D2008D07);
									num &= 1261165712U;
									dictionary75[key71] = value40;
									num ^= 3791880070U;
									Dictionary<uint, 11AE0F91.E489CC87> dictionary76 = this.891D0FB6;
									uint key72 = num ^ 3894488013U;
									num |= 1393148933U;
									num *= 4069026573U;
									IntPtr 09069C1A45 = ldftn(A0AF2E0D);
									num %= 3449847444U;
									11AE0F91.E489CC87 value41 = new 11AE0F91.E489CC87(this, 09069C1A45);
									num = 1301235493U / num;
									dictionary76[key72] = value41;
									Dictionary<uint, 11AE0F91.E489CC87> dictionary77 = this.891D0FB6;
									num -= 599546427U;
									uint key73 = num + 599546501U;
									num = 3591339549U >> (int)num;
									IntPtr 09069C1A46 = ldftn(52A1932E);
									num = 2998313251U >> (int)num;
									11AE0F91.E489CC87 value42 = new 11AE0F91.E489CC87(this, 09069C1A46);
									num += 2410198299U;
									dictionary77[key73] = value42;
									num &= 1704323105U;
									Dictionary<uint, 11AE0F91.E489CC87> dictionary78 = this.891D0FB6;
									uint key74 = num + 4202651693U;
									num >>= 21;
									11AE0F91.E489CC87 value43 = new 11AE0F91.E489CC87(this.9F292EBD);
									num -= 3163430687U;
									dictionary78[key74] = value43;
									num -= 2459843880U;
									if ((2862078509U & num) == 0U)
									{
										goto IL_29;
									}
									Dictionary<uint, 11AE0F91.E489CC87> dictionary79 = this.891D0FB6;
									uint key75 = num ^ 2966660011U;
									IntPtr 09069C1A47 = ldftn(9CBD9706);
									num = (3919263029U ^ num);
									dictionary79[key75] = new 11AE0F91.E489CC87(this, 09069C1A47);
									num = 2478352558U << (int)num;
									num = 766616849U * num;
									Dictionary<uint, 11AE0F91.E489CC87> dictionary80 = this.891D0FB6;
									num += 3599512839U;
									uint key76 = num - 807023800U;
									11AE0F91.E489CC87 value44 = new 11AE0F91.E489CC87(this.458B70A4);
									num ^= 1052547855U;
									dictionary80[key76] = value44;
									Dictionary<uint, 11AE0F91.E489CC87> dictionary81 = this.891D0FB6;
									num = 899032340U * num;
									uint key77 = num ^ 3705454832U;
									num += 2561351464U;
									IntPtr 09069C1A48 = ldftn(A430E9BA);
									num += 2216164375U;
									11AE0F91.E489CC87 value45 = new 11AE0F91.E489CC87(this, 09069C1A48);
									num = 1814963001U % num;
									dictionary81[key77] = value45;
									Dictionary<uint, 11AE0F91.E489CC87> dictionary82 = this.891D0FB6;
									uint key78 = num ^ 1814963048U;
									num %= 2662471434U;
									num = 2074616713U + num;
									IntPtr 09069C1A49 = ldftn(F5BDCEB1);
									num = (2726706432U & num);
									11AE0F91.E489CC87 value46 = new 11AE0F91.E489CC87(this, 09069C1A49);
									num = 2266365372U - num;
									dictionary82[key78] = value46;
									num = (3081478193U ^ num);
									num -= 463290903U;
									Dictionary<uint, 11AE0F91.E489CC87> dictionary83 = this.891D0FB6;
									uint key79 = num ^ 931600164U;
									num %= 3960121761U;
									dictionary83[key79] = new 11AE0F91.E489CC87(this.5787FF07);
									num /= 1747402909U;
									if (num == 3359195011U)
									{
										goto IL_29;
									}
									num -= 3876400668U;
									Dictionary<uint, 11AE0F91.E489CC87> dictionary84 = this.891D0FB6;
									uint key80 = num ^ 418566583U;
									num %= 2098461840U;
									11AE0F91.E489CC87 value47 = new 11AE0F91.E489CC87(this.7B214F82);
									num %= 1812433588U;
									dictionary84[key80] = value47;
									num = (1520153999U ^ num);
									Dictionary<uint, 11AE0F91.E489CC87> dictionary85 = this.891D0FB6;
									uint key81 = num + 3180764137U;
									num = 1755391628U * num;
									num = 1052558501U % num;
									11AE0F91.E489CC87 value48 = new 11AE0F91.E489CC87(this.E514B901);
									num *= 1017869707U;
									dictionary85[key81] = value48;
									num |= 640296505U;
									if (num << 15 == 0U)
									{
										goto IL_06;
									}
									Dictionary<uint, 11AE0F91.E489CC87> dictionary86 = this.891D0FB6;
									num = 4088177215U - num;
									uint key82 = num ^ 1961718741U;
									num %= 2762750096U;
									IntPtr 09069C1A50 = ldftn(1214FC83);
									num = 4077752456U * num;
									dictionary86[key82] = new 11AE0F91.E489CC87(this, 09069C1A50);
									num = 572651553U + num;
									Dictionary<uint, 11AE0F91.E489CC87> dictionary87 = this.891D0FB6;
									uint key83 = num - 784290763U;
									IntPtr 09069C1A51 = ldftn(D78EBE0B);
									num = (1144130854U | num);
									dictionary87[key83] = new 11AE0F91.E489CC87(this, 09069C1A51);
									Dictionary<uint, 11AE0F91.E489CC87> dictionary88 = this.891D0FB6;
									num >>= 7;
									uint key84 = num ^ 14515949U;
									IntPtr 09069C1A52 = ldftn(F980998C);
									num *= 227927332U;
									11AE0F91.E489CC87 value49 = new 11AE0F91.E489CC87(this, 09069C1A52);
									num >>= 29;
									dictionary88[key84] = value49;
									num %= 817817732U;
									Dictionary<uint, 11AE0F91.E489CC87> dictionary89 = this.891D0FB6;
									num += 3567838777U;
									uint key85 = num ^ 3567838820U;
									11AE0F91.E489CC87 value50 = new 11AE0F91.E489CC87(this.702E7607);
									num &= 288760583U;
									dictionary89[key85] = value50;
									if (2720377101U < num)
									{
										goto IL_63;
									}
									num -= 2718788500U;
									Dictionary<uint, 11AE0F91.E489CC87> dictionary90 = this.891D0FB6;
									num = (2559023033U | num);
									uint key86 = num - 4271355808U;
									IntPtr 09069C1A53 = ldftn(EDA983B7);
									num ^= 3208145293U;
									dictionary90[key86] = new 11AE0F91.E489CC87(this, 09069C1A53);
									if (4222709786U + num == 0U)
									{
										goto IL_6E;
									}
									num = 990502926U % num;
									Dictionary<uint, 11AE0F91.E489CC87> dictionary91 = this.891D0FB6;
									num = (621221272U & num);
									uint key87 = num ^ 553713746U;
									num = 1613574918U >> (int)num;
									num = 3951534998U + num;
									IntPtr 09069C1A54 = ldftn(049343B2);
									num = 1470319787U * num;
									dictionary91[key87] = new 11AE0F91.E489CC87(this, 09069C1A54);
									num = 1287323138U + num;
									if (3794571280U > num)
									{
										goto IL_3C;
									}
									Dictionary<uint, 11AE0F91.E489CC87> dictionary92 = this.891D0FB6;
									num = 968261816U + num;
									uint key88 = num ^ 725655718U;
									num %= 3022385821U;
									11AE0F91.E489CC87 value51 = new 11AE0F91.E489CC87(this.44982030);
									num <<= 29;
									dictionary92[key88] = value51;
									num ^= 447297419U;
									if (1948058928U > num)
									{
										goto IL_29;
									}
									num = 2366285210U * num;
									Dictionary<uint, 11AE0F91.E489CC87> dictionary93 = this.891D0FB6;
									num |= 1268847421U;
									uint key89 = num ^ 1604785123U;
									num = 3091024794U << (int)num;
									11AE0F91.E489CC87 value52 = new 11AE0F91.E489CC87(this.201A9D35);
									num = (3299288834U & num);
									dictionary93[key89] = value52;
									if (num >> 20 != 0U)
									{
										goto IL_29;
									}
									Dictionary<uint, 11AE0F91.E489CC87> dictionary94 = this.891D0FB6;
									num = 1479521934U >> (int)num;
									uint key90 = num ^ 1479522003U;
									num &= 2626484237U;
									11AE0F91.E489CC87 value53 = new 11AE0F91.E489CC87(this.A530FA28);
									num -= 1193058562U;
									dictionary94[key90] = value53;
									num %= 422050719U;
									num <<= 5;
									Dictionary<uint, 11AE0F91.E489CC87> dictionary95 = this.891D0FB6;
									uint key91 = num ^ 4127605278U;
									IntPtr 09069C1A55 = ldftn(3FABA399);
									num /= 1644714891U;
									dictionary95[key91] = new 11AE0F91.E489CC87(this, 09069C1A55);
									num = 3592636204U << (int)num;
									if (num > 3401055151U)
									{
										goto IL_29;
									}
									Dictionary<uint, 11AE0F91.E489CC87> dictionary96 = this.891D0FB6;
									num ^= 758434323U;
									uint key92 = num + 2319854012U;
									num >>= 25;
									IntPtr 09069C1A56 = ldftn(B3B7E81E);
									num = 1563404343U + num;
									11AE0F91.E489CC87 value54 = new 11AE0F91.E489CC87(this, 09069C1A56);
									num = 1429600658U / num;
									dictionary96[key92] = value54;
									num = 430933901U - num;
									if (1518881676U % num == 0U)
									{
										goto IL_29;
									}
									Dictionary<uint, 11AE0F91.E489CC87> dictionary97 = this.891D0FB6;
									uint key93 = num - 430933805U;
									11AE0F91.E489CC87 value55 = new 11AE0F91.E489CC87(this.1F80B42F);
									num /= 2846560173U;
									dictionary97[key93] = value55;
									num &= 1593941801U;
									Dictionary<uint, 11AE0F91.E489CC87> dictionary98 = this.891D0FB6;
									uint key94 = num - 4294967199U;
									num = (487637428U | num);
									IntPtr 09069C1A57 = ldftn(093ADD14);
									num = 1698510511U * num;
									dictionary98[key94] = new 11AE0F91.E489CC87(this, 09069C1A57);
									num ^= 3542945322U;
									num *= 3954462000U;
									Dictionary<uint, 11AE0F91.E489CC87> dictionary99 = this.891D0FB6;
									uint key95 = num ^ 2533602626U;
									num = 2881141533U << (int)num;
									num = 3415197241U / num;
									IntPtr 09069C1A58 = ldftn(C90E4819);
									num = (104468893U | num);
									dictionary99[key95] = new 11AE0F91.E489CC87(this, 09069C1A58);
									num = 2073659669U * num;
									if (num == 1344951720U)
									{
										goto IL_63;
									}
									Dictionary<uint, 11AE0F91.E489CC87> dictionary100 = this.891D0FB6;
									uint key96 = num ^ 2349168258U;
									IntPtr 09069C1A59 = ldftn(30382632);
									num = 924911408U / num;
									dictionary100[key96] = new 11AE0F91.E489CC87(this, 09069C1A59);
									num = 2310393248U << (int)num;
									num /= 1610993214U;
									Dictionary<uint, 11AE0F91.E489CC87> dictionary101 = this.891D0FB6;
									num = 1980065030U >> (int)num;
									uint key97 = num ^ 990032615U;
									num = 1201700232U << (int)num;
									num *= 991934085U;
									dictionary101[key97] = new 11AE0F91.E489CC87(this.C90E4819);
									num = 3802287760U + num;
									if ((num ^ 3650943410U) == 0U)
									{
										goto IL_3C;
									}
									num <<= 29;
									Dictionary<uint, 11AE0F91.E489CC87> dictionary102 = this.891D0FB6;
									uint key98 = num + 101U;
									num <<= 25;
									num *= 3658176283U;
									dictionary102[key98] = new 11AE0F91.E489CC87(this.17110522);
									num = (1789501747U ^ num);
									if (4215274004U * num == 0U)
									{
										goto IL_06;
									}
									num = 3232530319U >> (int)num;
									Dictionary<uint, 11AE0F91.E489CC87> dictionary103 = this.891D0FB6;
									num = 3366829205U << (int)num;
									uint key99 = num + 1835008102U;
									num = 361518516U * num;
									num /= 2772350601U;
									11AE0F91.E489CC87 value56 = new 11AE0F91.E489CC87(this.AA3ACF94);
									num += 1505493013U;
									dictionary103[key99] = value56;
									Dictionary<uint, 11AE0F91.E489CC87> dictionary104 = this.891D0FB6;
									uint key100 = num - 1505492910U;
									IntPtr 09069C1A60 = ldftn(AA3ACF94);
									num += 4238489607U;
									11AE0F91.E489CC87 value57 = new 11AE0F91.E489CC87(this, 09069C1A60);
									num = 3342323980U - num;
									dictionary104[key100] = value57;
									num ^= 1570954406U;
									Dictionary<uint, 11AE0F91.E489CC87> dictionary105 = this.891D0FB6;
									uint key101 = num ^ 763053118U;
									num *= 2277189813U;
									num = 1571334798U >> (int)num;
									IntPtr 09069C1A61 = ldftn(30382632);
									num %= 3912060418U;
									dictionary105[key101] = new 11AE0F91.E489CC87(this, 09069C1A61);
									num = 1931086099U * num;
									if (num * 2343522698U == 0U)
									{
										goto IL_29;
									}
									num *= 3036961545U;
									Dictionary<uint, 11AE0F91.E489CC87> dictionary106 = this.891D0FB6;
									num = (1041571094U & num);
									uint key102 = num - 34668461U;
									11AE0F91.E489CC87 value58 = new 11AE0F91.E489CC87(this.30382632);
									num = 1176495235U + num;
									dictionary106[key102] = value58;
									if ((1337849278U ^ num) == 0U)
									{
										goto IL_29;
									}
									Dictionary<uint, 11AE0F91.E489CC87> dictionary107 = this.891D0FB6;
									num = 2670792378U * num;
									uint key103 = num ^ 3897521472U;
									num = 1913991463U + num;
									num /= 4245795844U;
									IntPtr 09069C1A62 = ldftn(DF044EB1);
									num = 3911786429U + num;
									11AE0F91.E489CC87 value59 = new 11AE0F91.E489CC87(this, 09069C1A62);
									num = 2175386753U - num;
									dictionary107[key103] = value59;
									num = 4094033722U - num;
									Dictionary<uint, 11AE0F91.E489CC87> dictionary108 = this.891D0FB6;
									uint key104 = num ^ 1535466013U;
									num = (3609921073U | num);
									IntPtr 09069C1A63 = ldftn(9009AF06);
									num &= 3666127368U;
									dictionary108[key104] = new 11AE0F91.E489CC87(this, 09069C1A63);
									num = 4289642683U + num;
									if (1346333960U > num)
									{
										goto IL_29;
									}
									Dictionary<uint, 11AE0F91.E489CC87> dictionary109 = this.891D0FB6;
									uint key105 = num ^ 3660761815U;
									num >>= 5;
									dictionary109[key105] = new 11AE0F91.E489CC87(this.DE89C0B1);
									num = 797221431U + num;
									num &= 339686077U;
									Dictionary<uint, 11AE0F91.E489CC87> dictionary110 = this.891D0FB6;
									num = (1594229930U ^ num);
									uint key106 = num - 1259353017U;
									11AE0F91.E489CC87 value60 = new 11AE0F91.E489CC87(this.0717C01B);
									num = 1871059714U - num;
									dictionary110[key106] = value60;
									num %= 3962879360U;
									Dictionary<uint, 11AE0F91.E489CC87> dictionary111 = this.891D0FB6;
									num >>= 18;
									dictionary111[num ^ 2419U] = new 11AE0F91.E489CC87(this.CA3A9E35);
									if ((num & 378222372U) == 0U)
									{
										goto IL_06;
									}
									Dictionary<uint, 11AE0F91.E489CC87> dictionary112 = this.891D0FB6;
									uint key107 = num - 2222U;
									IntPtr 09069C1A64 = ldftn(E0194BA5);
									num %= 2500812163U;
									11AE0F91.E489CC87 value61 = new 11AE0F91.E489CC87(this, 09069C1A64);
									num = 3003439004U >> (int)num;
									dictionary112[key107] = value61;
									num >>= 1;
									Dictionary<uint, 11AE0F91.E489CC87> dictionary113 = this.891D0FB6;
									num = 1572656917U * num;
									dictionary113[num ^ 3145313882U] = new 11AE0F91.E489CC87(this.199380B8);
									num &= 3289338534U;
									Dictionary<uint, 11AE0F91.E489CC87> dictionary114 = this.891D0FB6;
									uint key108 = num ^ 2148074067U;
									num %= 1260985641U;
									IntPtr 09069C1A65 = ldftn(C90E4819);
									num = 2702458423U + num;
									11AE0F91.E489CC87 value62 = new 11AE0F91.E489CC87(this, 09069C1A65);
									num = 2033415579U * num;
									dictionary114[key108] = value62;
									Dictionary<uint, 11AE0F91.E489CC87> dictionary115 = this.891D0FB6;
									num = 1412281122U + num;
									uint key109 = num + 3663466304U;
									IntPtr 09069C1A66 = ldftn(8F0B263F);
									num = 2391729592U - num;
									dictionary115[key109] = new 11AE0F91.E489CC87(this, 09069C1A66);
									num = 1820933043U % num;
									Dictionary<uint, 11AE0F91.E489CC87> dictionary116 = this.891D0FB6;
									uint key110 = num ^ 60704606U;
									num <<= 19;
									IntPtr 09069C1A67 = ldftn(0717C01B);
									num *= 2166599168U;
									11AE0F91.E489CC87 value63 = new 11AE0F91.E489CC87(this, 09069C1A67);
									num -= 1267595918U;
									dictionary116[key110] = value63;
									num = 932710171U - num;
									if (75824813U == num)
									{
										goto IL_06;
									}
									num %= 1653950266U;
									Dictionary<uint, 11AE0F91.E489CC87> dictionary117 = this.891D0FB6;
									num = (3575034149U ^ num);
									uint key111 = num - 3639460252U;
									11AE0F91.E489CC87 value64 = new 11AE0F91.E489CC87(this.BB89E48C);
									num ^= 411753511U;
									dictionary117[key111] = value64;
									num = 1286922274U >> (int)num;
									Dictionary<uint, 11AE0F91.E489CC87> dictionary118 = this.891D0FB6;
									num = 3349509385U % num;
									uint key112 = num ^ 106U;
									num = (1451883040U | num);
									11AE0F91.E489CC87 value65 = new 11AE0F91.E489CC87(this.9009AF06);
									num = (3551356579U | num);
									dictionary118[key112] = value65;
									num = (3936876219U & num);
									if ((4087218458U ^ num) == 0U)
									{
										goto IL_3C;
									}
									Dictionary<uint, 11AE0F91.E489CC87> dictionary119 = this.891D0FB6;
									num /= 2376573999U;
									uint key113 = num + 117U;
									num = 763489337U >> (int)num;
									IntPtr 09069C1A68 = ldftn(458B70A4);
									num = 414066097U * num;
									11AE0F91.E489CC87 value66 = new 11AE0F91.E489CC87(this, 09069C1A68);
									num = 2852843179U >> (int)num;
									dictionary119[key113] = value66;
									num = 3173383457U >> (int)num;
									if (748559788U <= num)
									{
										goto IL_06;
									}
									Dictionary<uint, 11AE0F91.E489CC87> dictionary120 = this.891D0FB6;
									uint key114 = num ^ 3098888U;
									num = 4011822851U >> (int)num;
									num &= 4021417487U;
									dictionary120[key114] = new 11AE0F91.E489CC87(this.662F9C1D);
									num = 2872767141U >> (int)num;
									if (2349696657U >> (int)num == 0U)
									{
										goto IL_3C;
									}
									Dictionary<uint, 11AE0F91.E489CC87> dictionary121 = this.891D0FB6;
									uint key115 = num ^ 1436383530U;
									num = 1446485776U + num;
									IntPtr 09069C1A69 = ldftn(662F9C1D);
									num = 3315302051U >> (int)num;
									dictionary121[key115] = new 11AE0F91.E489CC87(this, 09069C1A69);
									num ^= 3323395104U;
									Dictionary<uint, 11AE0F91.E489CC87> dictionary122 = this.891D0FB6;
									num = (2192059295U ^ num);
									uint key116 = num ^ 1977092206U;
									IntPtr 09069C1A70 = ldftn(F980998C);
									num = 1788911142U >> (int)num;
									11AE0F91.E489CC87 value67 = new 11AE0F91.E489CC87(this, 09069C1A70);
									num &= 2955884350U;
									dictionary122[key116] = value67;
									num += 4029954834U;
									if ((num ^ 378892192U) == 0U)
									{
										goto IL_06;
									}
									Dictionary<uint, 11AE0F91.E489CC87> dictionary123 = this.891D0FB6;
									uint key117 = num + 265012564U;
									num >>= 29;
									IntPtr 09069C1A71 = ldftn(0DAF2509);
									num = (3967968261U | num);
									dictionary123[key117] = new 11AE0F91.E489CC87(this, 09069C1A71);
									if (num <= 2359928611U)
									{
										goto IL_06;
									}
									Dictionary<uint, 11AE0F91.E489CC87> dictionary124 = this.891D0FB6;
									num = 3416194619U + num;
									uint key118 = num ^ 3089195577U;
									num /= 4138035128U;
									num %= 847982134U;
									11AE0F91.E489CC87 value68 = new 11AE0F91.E489CC87(this.3F1DE48B);
									num = 1981525822U - num;
									dictionary124[key118] = value68;
									num /= 2777487020U;
									Dictionary<uint, 11AE0F91.E489CC87> dictionary125 = this.891D0FB6;
									num >>= 28;
									uint key119 = num ^ 124U;
									num |= 336642948U;
									num += 1704894881U;
									IntPtr 09069C1A72 = ldftn(199380B8);
									num = 2635283509U >> (int)num;
									11AE0F91.E489CC87 value69 = new 11AE0F91.E489CC87(this, 09069C1A72);
									num = 3190225809U % num;
									dictionary125[key119] = value69;
									if (3239262128U % num == 0U)
									{
										goto IL_06;
									}
									Dictionary<uint, 11AE0F91.E489CC87> dictionary126 = this.891D0FB6;
									uint key120 = num - 60826542U;
									num = 1376061984U >> (int)num;
									num >>= 21;
									11AE0F91.E489CC87 value70 = new 11AE0F91.E489CC87(this.8F0B263F);
									num >>= 26;
									dictionary126[key120] = value70;
									if ((num & 25740582U) != 0U)
									{
										goto IL_29;
									}
									num |= 1032309801U;
									Dictionary<uint, 11AE0F91.E489CC87> dictionary127 = this.891D0FB6;
									num *= 3284032556U;
									dictionary127[num ^ 572773234U] = new 11AE0F91.E489CC87(this.DE89C0B1);
									Dictionary<uint, 11AE0F91.E489CC87> dictionary128 = this.891D0FB6;
									num = 3642605466U - num;
									uint key121 = num ^ 3069832433U;
									num %= 3619668355U;
									num = 167895221U / num;
									IntPtr 09069C1A73 = ldftn(58150F83);
									num = 462005134U * num;
									dictionary128[key121] = new 11AE0F91.E489CC87(this, 09069C1A73);
									if (2921791015U >> (int)num == 0U)
									{
										goto IL_06;
									}
									num = (1487057334U | num);
									Dictionary<uint, 11AE0F91.E489CC87> dictionary129 = this.891D0FB6;
									uint key122 = num ^ 1487057206U;
									num ^= 239018551U;
									dictionary129[key122] = new 11AE0F91.E489CC87(this.0717C01B);
									num = 2310453263U >> (int)num;
									Dictionary<uint, 11AE0F91.E489CC87> dictionary130 = this.891D0FB6;
									uint key123 = num + 3139740794U;
									IntPtr 09069C1A74 = ldftn(DFB9313F);
									num = 2258023100U % num;
									dictionary130[key123] = new 11AE0F91.E489CC87(this, 09069C1A74);
									num |= 2008087597U;
									if (num % 296231098U == 0U)
									{
										goto IL_29;
									}
									Dictionary<uint, 11AE0F91.E489CC87> dictionary131 = this.891D0FB6;
									uint key124 = num + 2286158277U;
									num = 419943808U * num;
									dictionary131[key124] = new 11AE0F91.E489CC87(this.F61F83A8);
									Dictionary<uint, 11AE0F91.E489CC87> dictionary132 = this.891D0FB6;
									uint key125 = num - 3038617341U;
									num *= 1410444341U;
									dictionary132[key125] = new 11AE0F91.E489CC87(this.A0AF2E0D);
									num = 328682663U * num;
									if (num <= 311438988U)
									{
										goto IL_3C;
									}
									num ^= 1286646793U;
									Dictionary<uint, 11AE0F91.E489CC87> dictionary133 = this.891D0FB6;
									num = 2576815255U << (int)num;
									uint key126 = num - 774450556U;
									num = 3149676463U << (int)num;
									11AE0F91.E489CC87 value71 = new 11AE0F91.E489CC87(this.41A6CA0C);
									num = (3208119838U & num);
									dictionary133[key126] = value71;
									Dictionary<uint, 11AE0F91.E489CC87> dictionary134 = this.891D0FB6;
									num = (2760782848U ^ num);
									uint key127 = num + 3762933367U;
									num += 4262863288U;
									num = (574615952U | num);
									dictionary134[key127] = new 11AE0F91.E489CC87(this.0717C01B);
									Dictionary<uint, 11AE0F91.E489CC87> dictionary135 = this.891D0FB6;
									num <<= 8;
									uint key128 = num + 797318U;
									num = 3844316330U + num;
									num |= 1848701723U;
									IntPtr 09069C1A75 = ldftn(C90E4819);
									num %= 3724875793U;
									dictionary135[key128] = new 11AE0F91.E489CC87(this, 09069C1A75);
									num = (1880021527U | num);
									if (num == 2082802443U)
									{
										goto IL_29;
									}
									Dictionary<uint, 11AE0F91.E489CC87> dictionary136 = this.891D0FB6;
									uint key129 = num - 1899944760U;
									num = 3809497251U * num;
									IntPtr 09069C1A76 = ldftn(30382632);
									num /= 2159409298U;
									dictionary136[key129] = new 11AE0F91.E489CC87(this, 09069C1A76);
									num = 3423606197U * num;
									Dictionary<uint, 11AE0F91.E489CC87> dictionary137 = this.891D0FB6;
									uint key130 = num + 871361235U;
									num = 2450602026U >> (int)num;
									11AE0F91.E489CC87 value72 = new 11AE0F91.E489CC87(this.9F292EBD);
									num ^= 3784812183U;
									dictionary137[key130] = value72;
									num <<= 10;
									Dictionary<uint, 11AE0F91.E489CC87> dictionary138 = this.891D0FB6;
									num -= 3214896417U;
									uint key131 = num - 2666049110U;
									num *= 345212701U;
									num &= 461916438U;
									11AE0F91.E489CC87 value73 = new 11AE0F91.E489CC87(this.BB89E48C);
									num = 4147788087U / num;
									dictionary138[key131] = value73;
									num = 1161104952U / num;
									Dictionary<uint, 11AE0F91.E489CC87> dictionary139 = this.891D0FB6;
									num *= 1904614196U;
									uint key132 = num ^ 4260383530U;
									num = (1905126048U | num);
									IntPtr 09069C1A77 = ldftn(662F9C1D);
									num = 3953797505U * num;
									11AE0F91.E489CC87 value74 = new 11AE0F91.E489CC87(this, 09069C1A77);
									num >>= 14;
									dictionary139[key132] = value74;
									num ^= 1428879127U;
									if (4186451853U == num)
									{
										goto IL_63;
									}
									num = (4021516553U & num);
									Dictionary<uint, 11AE0F91.E489CC87> dictionary140 = this.891D0FB6;
									uint key133 = num ^ 1159792779U;
									num *= 78107166U;
									num -= 641051315U;
									dictionary140[key133] = new 11AE0F91.E489CC87(this.51AF9930);
									num = 2887577357U % num;
									if (891950374U / num == 0U)
									{
										goto IL_3C;
									}
									Dictionary<uint, 11AE0F91.E489CC87> dictionary141 = this.891D0FB6;
									num += 380200210U;
									uint key134 = num ^ 978569481U;
									num = 3896222355U % num;
									11AE0F91.E489CC87 value75 = new 11AE0F91.E489CC87(this.F980998C);
									num ^= 4027657110U;
									dictionary141[key134] = value75;
									num -= 1010493482U;
									Dictionary<uint, 11AE0F91.E489CC87> dictionary142 = this.891D0FB6;
									num = 3986804027U / num;
									uint key135 = num ^ 140U;
									num = (369567918U | num);
									num |= 2416960417U;
									11AE0F91.E489CC87 value76 = new 11AE0F91.E489CC87(this.95023AB5);
									num <<= 9;
									dictionary142[key135] = value76;
									this.891D0FB6[num ^ 534208142U] = new 11AE0F91.E489CC87(this.E0194BA5);
									if (num - 3903534909U == 0U)
									{
										goto IL_29;
									}
									Dictionary<uint, 11AE0F91.E489CC87> dictionary143 = this.891D0FB6;
									num *= 792291597U;
									uint key136 = num - 3783116145U;
									IntPtr 09069C1A78 = ldftn(51AF9930);
									num = (3623892746U ^ num);
									dictionary143[key136] = new 11AE0F91.E489CC87(this, 09069C1A78);
									if (num + 50523067U == 0U)
									{
										goto IL_29;
									}
									Dictionary<uint, 11AE0F91.E489CC87> dictionary144 = this.891D0FB6;
									num |= 1587780147U;
									uint key137 = num + 2147485013U;
									num = (2445179956U | num);
									num >>= 14;
									dictionary144[key137] = new 11AE0F91.E489CC87(this.F5BDCEB1);
									if (num - 92965522U != 0U)
									{
										num /= 2593924031U;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary145 = this.891D0FB6;
										num -= 1169843510U;
										uint key138 = num - 3125123641U;
										num = (2671152909U ^ num);
										IntPtr 09069C1A79 = ldftn(BE1E5493);
										num >>= 13;
										dictionary145[key138] = new 11AE0F91.E489CC87(this, 09069C1A79);
										if (num >= 2073692073U)
										{
											goto IL_06;
										}
										Dictionary<uint, 11AE0F91.E489CC87> dictionary146 = this.891D0FB6;
										num %= 1024224669U;
										uint key139 = num + 4294890746U;
										num = 1974835328U - num;
										dictionary146[key139] = new 11AE0F91.E489CC87(this.ED399CB1);
										num <<= 3;
										if (917148163U >= num)
										{
											goto IL_06;
										}
										num >>= 10;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary147 = this.891D0FB6;
										num *= 1084939427U;
										uint key140 = num ^ 1238908600U;
										num *= 2450296578U;
										IntPtr 09069C1A80 = ldftn(662F9C1D);
										num = 2366559521U >> (int)num;
										dictionary147[key140] = new 11AE0F91.E489CC87(this, 09069C1A80);
										if (num % 3397687817U == 0U)
										{
											goto IL_3C;
										}
										this.891D0FB6[num + 4294966880U] = new 11AE0F91.E489CC87(this.BB89E48C);
										num = (1135423267U ^ num);
										if ((260231863U ^ num) == 0U)
										{
											goto IL_06;
										}
										Dictionary<uint, 11AE0F91.E489CC87> dictionary148 = this.891D0FB6;
										num = 629682710U - num;
										uint key141 = num + 505740182U;
										num &= 580835380U;
										num >>= 23;
										11AE0F91.E489CC87 value77 = new 11AE0F91.E489CC87(this.AF3315A2);
										num += 3732966927U;
										dictionary148[key141] = value77;
										num &= 1865032763U;
										num = 2006824859U / num;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary149 = this.891D0FB6;
										num <<= 19;
										uint key142 = num ^ 524438U;
										num ^= 464592955U;
										num += 1287056819U;
										IntPtr 09069C1A81 = ldftn(AA3ACF94);
										num = 2726898349U % num;
										11AE0F91.E489CC87 value78 = new 11AE0F91.E489CC87(this, 09069C1A81);
										num = (143804340U & num);
										dictionary149[key142] = value78;
										num = (3819110039U | num);
										Dictionary<uint, 11AE0F91.E489CC87> dictionary150 = this.891D0FB6;
										uint key143 = num - 3954376224U;
										num = 673111177U % num;
										11AE0F91.E489CC87 value79 = new 11AE0F91.E489CC87(this.62AE5307);
										num = 2997984005U << (int)num;
										dictionary150[key143] = value79;
										num >>= 13;
										num = 4005150233U >> (int)num;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary151 = this.891D0FB6;
										uint key144 = num - 60961U;
										num -= 1790126366U;
										IntPtr 09069C1A82 = ldftn(8F0B263F);
										num = 982939779U + num;
										dictionary151[key144] = new 11AE0F91.E489CC87(this, 09069C1A82);
										if (num % 2386293909U == 0U)
										{
											goto IL_06;
										}
										Dictionary<uint, 11AE0F91.E489CC87> dictionary152 = this.891D0FB6;
										uint key145 = num ^ 3487841927U;
										num <<= 21;
										IntPtr 09069C1A83 = ldftn(662F9C1D);
										num /= 3994313016U;
										dictionary152[key145] = new 11AE0F91.E489CC87(this, 09069C1A83);
										num = (2117146547U | num);
										if ((num & 1000971444U) == 0U)
										{
											goto IL_06;
										}
										num >>= 4;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary153 = this.891D0FB6;
										uint key146 = num ^ 132321761U;
										num = 674221365U / num;
										num -= 4061400383U;
										11AE0F91.E489CC87 value80 = new 11AE0F91.E489CC87(this.5C22D991);
										num = 1488733842U - num;
										dictionary153[key146] = value80;
										if (num > 1664660650U)
										{
											goto IL_06;
										}
										Dictionary<uint, 11AE0F91.E489CC87> dictionary154 = this.891D0FB6;
										uint key147 = num + 3039800527U;
										IntPtr 09069C1A84 = ldftn(1F26AF94);
										num = 4146270654U % num;
										dictionary154[key147] = new 11AE0F91.E489CC87(this, 09069C1A84);
										if (3533555975U == num)
										{
											goto IL_06;
										}
										num = (4122349848U ^ num);
										Dictionary<uint, 11AE0F91.E489CC87> dictionary155 = this.891D0FB6;
										uint key148 = num - 3808691878U;
										num = (2327382824U ^ num);
										IntPtr 09069C1A85 = ldftn(E514B901);
										num = (2318054057U | num);
										11AE0F91.E489CC87 value81 = new 11AE0F91.E489CC87(this, 09069C1A85);
										num ^= 297644085U;
										dictionary155[key148] = value81;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary156 = this.891D0FB6;
										uint key149 = num + 100528575U;
										num /= 2358391868U;
										num = (2660432655U ^ num);
										dictionary156[key149] = new 11AE0F91.E489CC87(this.DFB9313F);
										num += 3827095229U;
										if (415113740U >> (int)num == 0U)
										{
											goto IL_06;
										}
										Dictionary<uint, 11AE0F91.E489CC87> dictionary157 = this.891D0FB6;
										uint key150 = num - 2192560429U;
										num = 345247890U % num;
										IntPtr 09069C1A86 = ldftn(199380B8);
										num = 3501305985U % num;
										dictionary157[key150] = new 11AE0F91.E489CC87(this, 09069C1A86);
										num = 304437307U - num;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary158 = this.891D0FB6;
										num -= 3911346742U;
										uint key151 = num + 3655736679U;
										num = 2210124435U >> (int)num;
										11AE0F91.E489CC87 value82 = new 11AE0F91.E489CC87(this.61814CA6);
										num = (4228256133U ^ num);
										dictionary158[key151] = value82;
										num >>= 6;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary159 = this.891D0FB6;
										num = 1862746014U >> (int)num;
										uint key152 = num ^ 116421465U;
										num = 4129593004U << (int)num;
										num %= 1999575857U;
										IntPtr 09069C1A87 = ldftn(0DAF2509);
										num = 2978434349U / num;
										11AE0F91.E489CC87 value83 = new 11AE0F91.E489CC87(this, 09069C1A87);
										num = 3510296099U / num;
										dictionary159[key152] = value83;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary160 = this.891D0FB6;
										num = 3501612472U + num;
										uint key153 = num + 3333174232U;
										num = 2410064819U * num;
										11AE0F91.E489CC87 value84 = new 11AE0F91.E489CC87(this.8F0B263F);
										num = (859348243U & num);
										dictionary160[key153] = value84;
										num = 3011746217U >> (int)num;
										if (966762301U <= num)
										{
											goto IL_06;
										}
										num = 1797020547U + num;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary161 = this.891D0FB6;
										uint key154 = num + 2121478634U;
										IntPtr 09069C1A88 = ldftn(199380B8);
										num = (1286393999U | num);
										dictionary161[key154] = new 11AE0F91.E489CC87(this, 09069C1A88);
										num = 1310402995U >> (int)num;
										if (num >= 4265024788U)
										{
											goto IL_06;
										}
										Dictionary<uint, 11AE0F91.E489CC87> dictionary162 = this.891D0FB6;
										num = (2291729201U | num);
										uint key155 = num + 2003238258U;
										num = (2602754718U & num);
										IntPtr 09069C1A89 = ldftn(8F0B263F);
										num -= 1200353683U;
										dictionary162[key155] = new 11AE0F91.E489CC87(this, 09069C1A89);
										Dictionary<uint, 11AE0F91.E489CC87> dictionary163 = this.891D0FB6;
										num /= 2310711476U;
										uint key156 = num ^ 164U;
										IntPtr 09069C1A90 = ldftn(ED399CB1);
										num <<= 23;
										dictionary163[key156] = new 11AE0F91.E489CC87(this, 09069C1A90);
										num = (2403251495U ^ num);
										Dictionary<uint, 11AE0F91.E489CC87> dictionary164 = this.891D0FB6;
										num = 3601920677U - num;
										uint key157 = num + 3096298279U;
										11AE0F91.E489CC87 value85 = new 11AE0F91.E489CC87(this.662F9C1D);
										num /= 3717564971U;
										dictionary164[key157] = value85;
										num <<= 23;
										num -= 723831041U;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary165 = this.891D0FB6;
										num >>= 13;
										uint key158 = num ^ 435839U;
										num <<= 7;
										IntPtr 09069C1A91 = ldftn(07B2F3A6);
										num >>= 23;
										dictionary165[key158] = new 11AE0F91.E489CC87(this, 09069C1A91);
										if ((1135636494U & num) == 0U)
										{
											goto IL_06;
										}
										Dictionary<uint, 11AE0F91.E489CC87> dictionary166 = this.891D0FB6;
										num = 1396543143U >> (int)num;
										uint key159 = num - 21820819U;
										num &= 3769212439U;
										IntPtr 09069C1A92 = ldftn(9E8D6895);
										num = (404541871U | num);
										dictionary166[key159] = new 11AE0F91.E489CC87(this, 09069C1A92);
										Dictionary<uint, 11AE0F91.E489CC87> dictionary167 = this.891D0FB6;
										uint key160 = num ^ 404543255U;
										num &= 2234879673U;
										11AE0F91.E489CC87 value86 = new 11AE0F91.E489CC87(this.B0337393);
										num = 3196722226U / num;
										dictionary167[key160] = value86;
										if (1478995748U >> (int)num == 0U)
										{
											break;
										}
										num = (1613971719U ^ num);
										Dictionary<uint, 11AE0F91.E489CC87> dictionary168 = this.891D0FB6;
										uint key161 = num + 2680993882U;
										num <<= 7;
										11AE0F91.E489CC87 value87 = new 11AE0F91.E489CC87(this.199380B8);
										num /= 2402066329U;
										dictionary168[key161] = value87;
										num = 2203413U >> (int)num;
										if (num == 4053934384U)
										{
											goto IL_63;
										}
										num = (1082700033U & num);
										Dictionary<uint, 11AE0F91.E489CC87> dictionary169 = this.891D0FB6;
										num = (2207924104U ^ num);
										uint key162 = num ^ 2207952419U;
										num = 3859752576U + num;
										11AE0F91.E489CC87 value88 = new 11AE0F91.E489CC87(this.22843BA6);
										num &= 2309909270U;
										dictionary169[key162] = value88;
										num = 1252783910U - num;
										if (num == 9654330U)
										{
											goto IL_06;
										}
										this.891D0FB6[num ^ 1090762381U] = new 11AE0F91.E489CC87(this.5DADD105);
										if (2972859803U <= num)
										{
											goto IL_06;
										}
										Dictionary<uint, 11AE0F91.E489CC87> dictionary170 = this.891D0FB6;
										uint key163 = num ^ 1090762378U;
										num &= 1394966938U;
										IntPtr 09069C1A93 = ldftn(7D1F7D2C);
										num = 1981216037U >> (int)num;
										dictionary170[key163] = new 11AE0F91.E489CC87(this, 09069C1A93);
										Dictionary<uint, 11AE0F91.E489CC87> dictionary171 = this.891D0FB6;
										num += 841338369U;
										uint key164 = num - 1336642205U;
										IntPtr 09069C1A94 = ldftn(BB89E48C);
										num = 2946229647U % num;
										11AE0F91.E489CC87 value89 = new 11AE0F91.E489CC87(this, 09069C1A94);
										num -= 1915351466U;
										dictionary171[key164] = value89;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary172 = this.891D0FB6;
										num = 3761083176U >> (int)num;
										uint key165 = num ^ 28856U;
										num += 2595630469U;
										IntPtr 09069C1A95 = ldftn(DFB9313F);
										num /= 3434327823U;
										dictionary172[key165] = new 11AE0F91.E489CC87(this, 09069C1A95);
										if (3123555107U <= num)
										{
											goto IL_06;
										}
										Dictionary<uint, 11AE0F91.E489CC87> dictionary173 = this.891D0FB6;
										uint key166 = num + 175U;
										num = 2041868708U << (int)num;
										IntPtr 09069C1A96 = ldftn(9C38BD9E);
										num = 3114096295U + num;
										11AE0F91.E489CC87 value90 = new 11AE0F91.E489CC87(this, 09069C1A96);
										num <<= 23;
										dictionary173[key166] = value90;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary174 = this.891D0FB6;
										num &= 3750626584U;
										uint key167 = num ^ 92274864U;
										num /= 3668739383U;
										IntPtr 09069C1A97 = ldftn(39A40BB7);
										num <<= 10;
										dictionary174[key167] = new 11AE0F91.E489CC87(this, 09069C1A97);
										if ((3878252220U ^ num) == 0U)
										{
											goto IL_63;
										}
										Dictionary<uint, 11AE0F91.E489CC87> dictionary175 = this.891D0FB6;
										num = 371566527U * num;
										uint key168 = num ^ 177U;
										num <<= 14;
										num = 35197704U << (int)num;
										dictionary175[key168] = new 11AE0F91.E489CC87(this.3F1DE48B);
										if (num > 1923684131U)
										{
											goto IL_29;
										}
										Dictionary<uint, 11AE0F91.E489CC87> dictionary176 = this.891D0FB6;
										uint key169 = num + 4259769770U;
										num |= 2099405093U;
										IntPtr 09069C1A98 = ldftn(A0AF2E0D);
										num = 2122396079U / num;
										dictionary176[key169] = new 11AE0F91.E489CC87(this, 09069C1A98);
										if (1923786027U == num)
										{
											goto IL_3C;
										}
										Dictionary<uint, 11AE0F91.E489CC87> dictionary177 = this.891D0FB6;
										num = (1035197960U | num);
										uint key170 = num + 3259769515U;
										num &= 1854067775U;
										IntPtr 09069C1A99 = ldftn(CA3A9E35);
										num <<= 15;
										11AE0F91.E489CC87 value91 = new 11AE0F91.E489CC87(this, 09069C1A99);
										num ^= 11727769U;
										dictionary177[key170] = value91;
										num = (2544469257U | num);
										Dictionary<uint, 11AE0F91.E489CC87> dictionary178 = this.891D0FB6;
										uint key171 = num - 4290770661U;
										num -= 1463330979U;
										IntPtr 09069C1A100 = ldftn(5C22D991);
										num = (4035544112U | num);
										dictionary178[key171] = new 11AE0F91.E489CC87(this, 09069C1A100);
										num ^= 1932698897U;
										num = 1993504U << (int)num;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary179 = this.891D0FB6;
										num = 1237267106U + num;
										uint key172 = num + 2802531859U;
										num &= 2324168106U;
										IntPtr 09069C1A101 = ldftn(DF044EB1);
										num = (2663193748U & num);
										11AE0F91.E489CC87 value92 = new 11AE0F91.E489CC87(this, 09069C1A101);
										num = 3258256823U % num;
										dictionary179[key172] = value92;
										if (3810412427U == num)
										{
											goto IL_63;
										}
										num = 2535376298U * num;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary180 = this.891D0FB6;
										uint key173 = num ^ 3830226992U;
										IntPtr 09069C1A102 = ldftn(458B70A4);
										num += 101387421U;
										dictionary180[key173] = new 11AE0F91.E489CC87(this, 09069C1A102);
										num += 2561419052U;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary181 = this.891D0FB6;
										uint key174 = num + 2096901224U;
										num = 2350518799U - num;
										dictionary181[key174] = new 11AE0F91.E489CC87(this.DFB9313F);
										num = (2894974490U ^ num);
										if (1586726830 << (int)num == 0)
										{
											goto IL_06;
										}
										Dictionary<uint, 11AE0F91.E489CC87> dictionary182 = this.891D0FB6;
										uint key175 = num - 2778460962U;
										num |= 1269519518U;
										num = 3376385048U * num;
										11AE0F91.E489CC87 value93 = new 11AE0F91.E489CC87(this.FC8F3F05);
										num ^= 842704446U;
										dictionary182[key175] = value93;
										num = (3300372252U | num);
										Dictionary<uint, 11AE0F91.E489CC87> dictionary183 = this.891D0FB6;
										num >>= 12;
										uint key176 = num - 937665U;
										IntPtr 09069C1A103 = ldftn(BB89E48C);
										num ^= 1712850049U;
										11AE0F91.E489CC87 value94 = new 11AE0F91.E489CC87(this, 09069C1A103);
										num = 2529053244U % num;
										dictionary183[key176] = value94;
										num = 4272079635U - num;
										if (1635893945U > num)
										{
											goto IL_63;
										}
										Dictionary<uint, 11AE0F91.E489CC87> dictionary184 = this.891D0FB6;
										num ^= 3551122598U;
										uint key177 = num + 3786207302U;
										num -= 1317498555U;
										IntPtr 09069C1A104 = ldftn(8F0B263F);
										num = 4128698770U + num;
										dictionary184[key177] = new 11AE0F91.E489CC87(this, 09069C1A104);
										if (num * 1158521346U == 0U)
										{
											goto IL_29;
										}
										num = 2737533191U * num;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary185 = this.891D0FB6;
										num = 2340633224U / num;
										uint key178 = num - 4294967109U;
										num = 2996010001U + num;
										dictionary185[key178] = new 11AE0F91.E489CC87(this.662F9C1D);
										num += 3726493739U;
										num = 1242639785U + num;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary186 = this.891D0FB6;
										uint key179 = num + 624791255U;
										num ^= 2894294061U;
										num /= 3265687573U;
										IntPtr 09069C1A105 = ldftn(39A40BB7);
										num = 813734915U * num;
										dictionary186[key179] = new 11AE0F91.E489CC87(this, 09069C1A105);
										num = 825167253U * num;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary187 = this.891D0FB6;
										uint key180 = num ^ 189U;
										IntPtr 09069C1A106 = ldftn(22843BA6);
										num = 117873712U + num;
										11AE0F91.E489CC87 value95 = new 11AE0F91.E489CC87(this, 09069C1A106);
										num = 179079974U << (int)num;
										dictionary187[key180] = value95;
										num = 2528709279U >> (int)num;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary188 = this.891D0FB6;
										uint key181 = num ^ 2528709153U;
										IntPtr 09069C1A107 = ldftn(E90838A9);
										num -= 2904035996U;
										11AE0F91.E489CC87 value96 = new 11AE0F91.E489CC87(this, 09069C1A107);
										num = 546042034U + num;
										dictionary188[key181] = value96;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary189 = this.891D0FB6;
										num = (3081135257U ^ num);
										uint key182 = num ^ 3179973779U;
										num = 3616438682U >> (int)num;
										num ^= 2023859973U;
										11AE0F91.E489CC87 value97 = new 11AE0F91.E489CC87(this.8FB9EF9F);
										num /= 2919673360U;
										dictionary189[key182] = value97;
										if (3515608593U < num)
										{
											goto IL_06;
										}
										Dictionary<uint, 11AE0F91.E489CC87> dictionary190 = this.891D0FB6;
										num = 2310610731U >> (int)num;
										uint key183 = num ^ 2310610923U;
										num %= 3080096923U;
										IntPtr 09069C1A108 = ldftn(1F80B42F);
										num = 3716376618U >> (int)num;
										11AE0F91.E489CC87 value98 = new 11AE0F91.E489CC87(this, 09069C1A108);
										num >>= 4;
										dictionary190[key183] = value98;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary191 = this.891D0FB6;
										uint key184 = num ^ 113607U;
										num = 4052119327U / num;
										num = 956696609U / num;
										dictionary191[key184] = new 11AE0F91.E489CC87(this.199380B8);
										if ((num & 2965143311U) == 0U)
										{
											goto IL_06;
										}
										Dictionary<uint, 11AE0F91.E489CC87> dictionary192 = this.891D0FB6;
										uint key185 = num ^ 26715U;
										IntPtr 09069C1A109 = ldftn(BB89E48C);
										num = (3502116489U | num);
										dictionary192[key185] = new 11AE0F91.E489CC87(this, 09069C1A109);
										num &= 205216661U;
										if ((num ^ 1513224504U) == 0U)
										{
											goto IL_3C;
										}
										num = 3867430069U - num;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary193 = this.891D0FB6;
										num = 916518016U >> (int)num;
										uint key186 = num ^ 57282443U;
										num |= 261159737U;
										IntPtr 09069C1A110 = ldftn(C90E4819);
										num = (1897457178U ^ num);
										11AE0F91.E489CC87 value99 = new 11AE0F91.E489CC87(this, 09069C1A110);
										num = 3550518030U / num;
										dictionary193[key186] = value99;
										num <<= 11;
										this.891D0FB6[num ^ 2244U] = new 11AE0F91.E489CC87(this.9E8D6895);
										if (637534342U % num == 0U)
										{
											goto IL_63;
										}
										num <<= 19;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary194 = this.891D0FB6;
										uint key187 = num ^ 1073742021U;
										IntPtr 09069C1A111 = ldftn(F980998C);
										num = 3473406084U * num;
										11AE0F91.E489CC87 value100 = new 11AE0F91.E489CC87(this, 09069C1A111);
										num = 3778735117U - num;
										dictionary194[key187] = value100;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary195 = this.891D0FB6;
										num = (1747776933U | num);
										uint key188 = num + 381747993U;
										num = 2241676215U / num;
										11AE0F91.E489CC87 value101 = new 11AE0F91.E489CC87(this.8F0B263F);
										num >>= 12;
										dictionary195[key188] = value101;
										num /= 783136918U;
										if ((1588666638U ^ num) == 0U)
										{
											goto IL_3C;
										}
										this.891D0FB6[num + 199U] = new 11AE0F91.E489CC87(this.22843BA6);
										if (num - 2645521940U == 0U)
										{
											goto IL_29;
										}
										Dictionary<uint, 11AE0F91.E489CC87> dictionary196 = this.891D0FB6;
										num <<= 3;
										dictionary196[num - 4294967096U] = new 11AE0F91.E489CC87(this.07B2F3A6);
										num = 4120086438U >> (int)num;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary197 = this.891D0FB6;
										num -= 1897289363U;
										uint key189 = num ^ 2222797274U;
										num -= 3347526312U;
										dictionary197[key189] = new 11AE0F91.E489CC87(this.8F0B263F);
										Dictionary<uint, 11AE0F91.E489CC87> dictionary198 = this.891D0FB6;
										num = 2736748309U + num;
										uint key190 = num ^ 1612019018U;
										num = 3164833172U + num;
										num -= 3248089235U;
										IntPtr 09069C1A112 = ldftn(089A8488);
										num |= 680824457U;
										11AE0F91.E489CC87 value102 = new 11AE0F91.E489CC87(this, 09069C1A112);
										num = 1495514904U - num;
										dictionary198[key190] = value102;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary199 = this.891D0FB6;
										num &= 2165846821U;
										uint key191 = num + 2130698438U;
										IntPtr 09069C1A113 = ldftn(CB96929A);
										num = 3650946819U % num;
										11AE0F91.E489CC87 value103 = new 11AE0F91.E489CC87(this, 09069C1A113);
										num = 1107425056U + num;
										dictionary199[key191] = value103;
										if (1446302645U / num != 0U)
										{
											goto IL_06;
										}
										Dictionary<uint, 11AE0F91.E489CC87> dictionary200 = this.891D0FB6;
										num >>= 18;
										uint key192 = num ^ 9835U;
										num -= 3524826680U;
										num -= 302453908U;
										dictionary200[key192] = new 11AE0F91.E489CC87(this.712AC49C);
										Dictionary<uint, 11AE0F91.E489CC87> dictionary201 = this.891D0FB6;
										uint key193 = num + 3827270898U;
										num /= 2894250140U;
										11AE0F91.E489CC87 value104 = new 11AE0F91.E489CC87(this.9E8D6895);
										num -= 2669296293U;
										dictionary201[key193] = value104;
										num = 3736832562U << (int)num;
										num += 252111293U;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary202 = this.891D0FB6;
										num &= 2242138771U;
										uint key194 = num + 2063319101U;
										IntPtr 09069C1A114 = ldftn(5701C228);
										num = 3300908713U + num;
										11AE0F91.E489CC87 value105 = new 11AE0F91.E489CC87(this, 09069C1A114);
										num /= 1149685535U;
										dictionary202[key194] = value105;
										num %= 313125785U;
										num = 3173106738U / num;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary203 = this.891D0FB6;
										num = 3456822051U << (int)num;
										dictionary203[num ^ 2894856399U] = new 11AE0F91.E489CC87(this.62AE5307);
										num = (444605826U ^ num);
										num -= 2863461657U;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary204 = this.891D0FB6;
										num = 3273757187U >> (int)num;
										uint key195 = num ^ 6393881U;
										num = 1226639369U + num;
										11AE0F91.E489CC87 value106 = new 11AE0F91.E489CC87(this.7B214F82);
										num <<= 6;
										dictionary204[key195] = value106;
										num = (168391336U ^ num);
										Dictionary<uint, 11AE0F91.E489CC87> dictionary205 = this.891D0FB6;
										uint key196 = num ^ 1437550329U;
										11AE0F91.E489CC87 value107 = new 11AE0F91.E489CC87(this.9E8D6895);
										num = 4239408059U + num;
										dictionary205[key196] = value107;
										num = 2778238728U * num;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary206 = this.891D0FB6;
										num &= 3441489666U;
										uint key197 = num - 1208013614U;
										num /= 2797542428U;
										11AE0F91.E489CC87 value108 = new 11AE0F91.E489CC87(this.22843BA6);
										num = (1941768969U | num);
										dictionary206[key197] = value108;
										num = 3582508860U / num;
										if (num > 992143509U)
										{
											goto IL_06;
										}
										num = (2705179694U & num);
										Dictionary<uint, 11AE0F91.E489CC87> dictionary207 = this.891D0FB6;
										uint key198 = num - 4294967085U;
										num = (3560249134U | num);
										11AE0F91.E489CC87 value109 = new 11AE0F91.E489CC87(this.C535480E);
										num -= 1109603217U;
										dictionary207[key198] = value109;
										num = 218483507U - num;
										if (num <= 1000839683U)
										{
											goto IL_06;
										}
										Dictionary<uint, 11AE0F91.E489CC87> dictionary208 = this.891D0FB6;
										uint key199 = num ^ 2062804802U;
										num *= 4188756024U;
										IntPtr 09069C1A115 = ldftn(BB89E48C);
										num = (4111824820U ^ num);
										11AE0F91.E489CC87 value110 = new 11AE0F91.E489CC87(this, 09069C1A115);
										num = 2761964705U * num;
										dictionary208[key199] = value110;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary209 = this.891D0FB6;
										uint key200 = num - 1957321999U;
										num *= 3860891956U;
										num = 2084217495U >> (int)num;
										IntPtr 09069C1A116 = ldftn(8F0B263F);
										num = 2754143115U + num;
										11AE0F91.E489CC87 value111 = new 11AE0F91.E489CC87(this, 09069C1A116);
										num <<= 2;
										dictionary209[key200] = value111;
										num &= 397304844U;
										if ((3339671475U ^ num) == 0U)
										{
											goto IL_06;
										}
										num = 706337837U * num;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary210 = this.891D0FB6;
										uint key201 = num + 1623391266U;
										num = 2618628904U - num;
										IntPtr 09069C1A117 = ldftn(8F0B263F);
										num /= 4122252295U;
										11AE0F91.E489CC87 value112 = new 11AE0F91.E489CC87(this, 09069C1A117);
										num = 1865852326U << (int)num;
										dictionary210[key201] = value112;
										num = (4064176787U & num);
										Dictionary<uint, 11AE0F91.E489CC87> dictionary211 = this.891D0FB6;
										uint key202 = num ^ 3526118103U;
										num = 4018466224U / num;
										IntPtr 09069C1A118 = ldftn(9009AF06);
										num = (673478207U | num);
										dictionary211[key202] = new 11AE0F91.E489CC87(this, 09069C1A118);
										num = 1059068943U + num;
										if (2643649580U == num)
										{
											goto IL_06;
										}
										num &= 4044768129U;
										this.891D0FB6[num - 1627652392U] = new 11AE0F91.E489CC87(this.BB89E48C);
										Dictionary<uint, 11AE0F91.E489CC87> dictionary212 = this.891D0FB6;
										uint key203 = num - 1627652391U;
										num ^= 4111170199U;
										dictionary212[key203] = new 11AE0F91.E489CC87(this.07B2F3A6);
										num = 3023107646U - num;
										if (num >= 3283087749U)
										{
											goto IL_3C;
										}
										num ^= 1604308910U;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary213 = this.891D0FB6;
										num <<= 14;
										uint key204 = num - 2894216998U;
										num -= 723192710U;
										IntPtr 09069C1A119 = ldftn(C90E4819);
										num = 563372707U / num;
										11AE0F91.E489CC87 value113 = new 11AE0F91.E489CC87(this, 09069C1A119);
										num = 3163713671U >> (int)num;
										dictionary213[key204] = value113;
										num = (1460597390U | num);
										if (num <= 2520521602U)
										{
											goto IL_06;
										}
										num ^= 363178509U;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary214 = this.891D0FB6;
										uint key205 = num - 3929757607U;
										num %= 4001399041U;
										11AE0F91.E489CC87 value114 = new 11AE0F91.E489CC87(this.D2008D07);
										num ^= 2889077275U;
										dictionary214[key205] = value114;
										if ((num & 3464866366U) == 0U)
										{
											goto IL_06;
										}
										Dictionary<uint, 11AE0F91.E489CC87> dictionary215 = this.891D0FB6;
										uint key206 = num + 3120002627U;
										num >>= 16;
										IntPtr 09069C1A120 = ldftn(C90E4819);
										num >>= 26;
										dictionary215[key206] = new 11AE0F91.E489CC87(this, 09069C1A120);
										num <<= 1;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary216 = this.891D0FB6;
										uint key207 = num ^ 221U;
										num = (473384246U & num);
										num /= 915302273U;
										IntPtr 09069C1A121 = ldftn(1F80B42F);
										num = (3264781598U ^ num);
										dictionary216[key207] = new 11AE0F91.E489CC87(this, 09069C1A121);
										num %= 2743996324U;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary217 = this.891D0FB6;
										uint key208 = num + 3774182244U;
										num |= 3048259331U;
										dictionary217[key208] = new 11AE0F91.E489CC87(this.22843BA6);
										num = 1334310450U / num;
										num <<= 27;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary218 = this.891D0FB6;
										num = 1840356756U * num;
										uint key209 = num - 4294967073U;
										num = 2585918387U - num;
										IntPtr 09069C1A122 = ldftn(9E8D6895);
										num = (3056615078U & num);
										dictionary218[key209] = new 11AE0F91.E489CC87(this, 09069C1A122);
										num = 2551431228U * num;
										if (698511636U / num != 0U)
										{
											goto IL_06;
										}
										num /= 1655342623U;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary219 = this.891D0FB6;
										uint key210 = num ^ 226U;
										IntPtr 09069C1A123 = ldftn(DFB9313F);
										num = 3693480196U % num;
										dictionary219[key210] = new 11AE0F91.E489CC87(this, 09069C1A123);
										if (4013479183U <= num)
										{
											goto IL_06;
										}
										num = (3802386080U | num);
										Dictionary<uint, 11AE0F91.E489CC87> dictionary220 = this.891D0FB6;
										uint key211 = num ^ 3802385985U;
										num = 1185710510U << (int)num;
										num += 1161502247U;
										IntPtr 09069C1A124 = ldftn(1214FC83);
										num &= 588675390U;
										dictionary220[key211] = new 11AE0F91.E489CC87(this, 09069C1A124);
										num /= 1797036191U;
										if ((2106318775U ^ num) == 0U)
										{
											goto IL_06;
										}
										Dictionary<uint, 11AE0F91.E489CC87> dictionary221 = this.891D0FB6;
										num &= 1812214668U;
										uint key212 = num ^ 226U;
										num = 3040107027U >> (int)num;
										num = 67806892U * num;
										dictionary221[key212] = new 11AE0F91.E489CC87(this.9C38BD9E);
										Dictionary<uint, 11AE0F91.E489CC87> dictionary222 = this.891D0FB6;
										num = 671317808U << (int)num;
										uint key213 = num ^ 2151150563U;
										num = 1285542022U >> (int)num;
										IntPtr 09069C1A125 = ldftn(662F9C1D);
										num = (3667412142U ^ num);
										11AE0F91.E489CC87 value115 = new 11AE0F91.E489CC87(this, 09069C1A125);
										num /= 3099064501U;
										dictionary222[key213] = value115;
										num = 1136422056U >> (int)num;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary223 = this.891D0FB6;
										num = 2897795257U * num;
										uint key214 = num ^ 3885516172U;
										IntPtr 09069C1A126 = ldftn(17110522);
										num = 2626937110U % num;
										11AE0F91.E489CC87 value116 = new 11AE0F91.E489CC87(this, 09069C1A126);
										num = 2025231244U * num;
										dictionary223[key214] = value116;
										num -= 3406055199U;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary224 = this.891D0FB6;
										num = 2955086727U * num;
										uint key215 = num ^ 2352585530U;
										num -= 2637215269U;
										dictionary224[key215] = new 11AE0F91.E489CC87(this.17110522);
										num += 3063167670U;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary225 = this.891D0FB6;
										uint key216 = num + 1516429430U;
										11AE0F91.E489CC87 value117 = new 11AE0F91.E489CC87(this.F61F83A8);
										num = 2442091430U * num;
										dictionary225[key216] = value117;
										num = 354525117U / num;
										if (num / 654759101U != 0U)
										{
											goto IL_06;
										}
										num <<= 9;
										Dictionary<uint, 11AE0F91.E489CC87> dictionary226 = this.891D0FB6;
										num = 1092027064U * num;
										uint key217 = num - 4294967065U;
										11AE0F91.E489CC87 value118 = new 11AE0F91.E489CC87(this.D2008D07);
										num >>= 10;
										dictionary226[key217] = value118;
										num = (1891487156U & num);
										Dictionary<uint, 11AE0F91.E489CC87> dictionary227 = this.891D0FB6;
										num = 4205463224U - num;
										uint key218 = num + 89504304U;
										num %= 1594234884U;
										11AE0F91.E489CC87 value119 = new 11AE0F91.E489CC87(this.712AC49C);
										num >>= 29;
										dictionary227[key218] = value119;
										if (num < 579753615U)
										{
											goto Block_117;
										}
									}
								}
							}
						}
						Block_117:
						Dictionary<uint, 11AE0F91.E489CC87> dictionary228 = this.891D0FB6;
						num |= 344009638U;
						dictionary228[num ^ 344009550U] = new 11AE0F91.E489CC87(this.0C0392BB);
						if (num >> 19 == 0U)
						{
							goto IL_06;
						}
						num /= 3876945161U;
						Dictionary<uint, 11AE0F91.E489CC87> dictionary229 = this.891D0FB6;
						num *= 3071568686U;
						uint key219 = num ^ 234U;
						num = 2081775494U >> (int)num;
						dictionary229[key219] = new 11AE0F91.E489CC87(this.9E8D6895);
						num = 3249124887U << (int)num;
						num %= 630046096U;
						Dictionary<uint, 11AE0F91.E489CC87> dictionary230 = this.891D0FB6;
						uint key220 = num - 525470133U;
						num = 3441380143U << (int)num;
						IntPtr 09069C1A127 = ldftn(C90E4819);
						num = 4038301725U + num;
						11AE0F91.E489CC87 value120 = new 11AE0F91.E489CC87(this, 09069C1A127);
						num = (3121132416U & num);
						dictionary230[key220] = value120;
						num &= 3140933820U;
						if ((3189670565U ^ num) == 0U)
						{
							goto IL_06;
						}
						num = (3543809854U & num);
						Dictionary<uint, 11AE0F91.E489CC87> dictionary231 = this.891D0FB6;
						uint key221 = num - 2415918868U;
						IntPtr 09069C1A128 = ldftn(7D1F7D2C);
						num ^= 2561548067U;
						dictionary231[key221] = new 11AE0F91.E489CC87(this, 09069C1A128);
						num = (1738617366U ^ num);
						if (523251111U / num != 0U)
						{
							break;
						}
						Dictionary<uint, 11AE0F91.E489CC87> dictionary232 = this.891D0FB6;
						uint key222 = num ^ 1863265752U;
						num = 1110088612U - num;
						11AE0F91.E489CC87 value121 = new 11AE0F91.E489CC87(this.DF044EB1);
						num += 3434229638U;
						dictionary232[key222] = value121;
						num = (4221987746U ^ num);
						num ^= 3366226106U;
						Dictionary<uint, 11AE0F91.E489CC87> dictionary233 = this.891D0FB6;
						uint key223 = num + 1395687937U;
						num %= 354521788U;
						11AE0F91.E489CC87 value122 = new 11AE0F91.E489CC87(this.A530FA28);
						num = 4198401564U * num;
						dictionary233[key223] = value122;
						num = (1715383323U ^ num);
						Dictionary<uint, 11AE0F91.E489CC87> dictionary234 = this.891D0FB6;
						num /= 2661798160U;
						uint key224 = num ^ 238U;
						num = 1185040035U / num;
						num = 1963356345U % num;
						dictionary234[key224] = new 11AE0F91.E489CC87(this.A0AF2E0D);
						Dictionary<uint, 11AE0F91.E489CC87> dictionary235 = this.891D0FB6;
						num = (1770292768U & num);
						uint key225 = num ^ 671351536U;
						num = 2324807586U << (int)num;
						IntPtr 09069C1A129 = ldftn(A430E9BA);
						num = 926383281U / num;
						11AE0F91.E489CC87 value123 = new 11AE0F91.E489CC87(this, 09069C1A129);
						num = (572996995U ^ num);
						dictionary235[key225] = value123;
						if (num < 489963071U)
						{
							goto IL_06;
						}
						Dictionary<uint, 11AE0F91.E489CC87> dictionary236 = this.891D0FB6;
						uint key226 = num ^ 572996978U;
						num = 2343477518U / num;
						11AE0F91.E489CC87 value124 = new 11AE0F91.E489CC87(this.39A40BB7);
						num = (1360499080U & num);
						dictionary236[key226] = value124;
						if (1638828461U == num)
						{
							goto IL_06;
						}
						num -= 4095111481U;
						Dictionary<uint, 11AE0F91.E489CC87> dictionary237 = this.891D0FB6;
						uint key227 = num - 199855573U;
						IntPtr 09069C1A130 = ldftn(199380B8);
						num *= 2795392640U;
						11AE0F91.E489CC87 value125 = new 11AE0F91.E489CC87(this, 09069C1A130);
						num %= 3593576495U;
						dictionary237[key227] = value125;
						if (num >= 2105624328U)
						{
							goto IL_06;
						}
						Dictionary<uint, 11AE0F91.E489CC87> dictionary238 = this.891D0FB6;
						num |= 2911488018U;
						uint key228 = num ^ 4019965281U;
						num &= 3196362649U;
						dictionary238[key228] = new 11AE0F91.E489CC87(this.E90838A9);
						if (num >> 23 == 0U)
						{
							goto IL_06;
						}
						Dictionary<uint, 11AE0F91.E489CC87> dictionary239 = this.891D0FB6;
						uint key229 = num ^ 2927660388U;
						num /= 3691780279U;
						IntPtr 09069C1A131 = ldftn(199380B8);
						num = 3802842917U + num;
						dictionary239[key229] = new 11AE0F91.E489CC87(this, 09069C1A131);
						if (4171533220U >> (int)num == 0U)
						{
							goto IL_29;
						}
						Dictionary<uint, 11AE0F91.E489CC87> dictionary240 = this.891D0FB6;
						num = (3424310819U & num);
						uint key230 = num ^ 3221931732U;
						num ^= 2628565415U;
						IntPtr 09069C1A132 = ldftn(95023AB5);
						num ^= 2701688353U;
						11AE0F91.E489CC87 value126 = new 11AE0F91.E489CC87(this, 09069C1A132);
						num = (3884351241U & num);
						dictionary240[key230] = value126;
						num -= 2469834024U;
						Dictionary<uint, 11AE0F91.E489CC87> dictionary241 = this.891D0FB6;
						num = 3869918227U / num;
						uint key231 = num - 4294967052U;
						num = (3290596238U | num);
						dictionary241[key231] = new 11AE0F91.E489CC87(this.E91AE9BE);
						Dictionary<uint, 11AE0F91.E489CC87> dictionary242 = this.891D0FB6;
						uint key232 = num ^ 3290596217U;
						num &= 151443249U;
						dictionary242[key232] = new 11AE0F91.E489CC87(this.ED399CB1);
						num = 3305559186U % num;
						Dictionary<uint, 11AE0F91.E489CC87> dictionary243 = this.891D0FB6;
						num = 161349939U + num;
						uint key233 = num - 161415629U;
						IntPtr 09069C1A133 = ldftn(7305983E);
						num >>= 19;
						11AE0F91.E489CC87 value127 = new 11AE0F91.E489CC87(this, 09069C1A133);
						num = (126042893U & num);
						dictionary243[key233] = value127;
						num = 2803577883U - num;
						num /= 2109352992U;
						Dictionary<uint, 11AE0F91.E489CC87> dictionary244 = this.891D0FB6;
						uint key234 = num + 248U;
						IntPtr 09069C1A134 = ldftn(5701C228);
						num = 3853346080U - num;
						11AE0F91.E489CC87 value128 = new 11AE0F91.E489CC87(this, 09069C1A134);
						num /= 3641904690U;
						dictionary244[key234] = value128;
						Dictionary<uint, 11AE0F91.E489CC87> dictionary245 = this.891D0FB6;
						num = 121140U >> (int)num;
						uint key235 = num - 60320U;
						num %= 1982344070U;
						IntPtr 09069C1A135 = ldftn(D2008D07);
						num = 238732183U << (int)num;
						11AE0F91.E489CC87 value129 = new 11AE0F91.E489CC87(this, 09069C1A135);
						num = 1027431743U - num;
						dictionary245[key235] = value129;
						num = (161985698U | num);
						if (num <= 462413209U)
						{
							goto IL_29;
						}
						num = 2292201892U * num;
						Dictionary<uint, 11AE0F91.E489CC87> dictionary246 = this.891D0FB6;
						num %= 831349041U;
						uint key236 = num - 717443583U;
						num = 621863096U / num;
						IntPtr 09069C1A136 = ldftn(1F80B42F);
						num ^= 438320148U;
						11AE0F91.E489CC87 value130 = new 11AE0F91.E489CC87(this, 09069C1A136);
						num &= 2511785372U;
						dictionary246[key236] = value130;
						num *= 3072521754U;
						if (3508186760U < num)
						{
							goto IL_06;
						}
						Dictionary<uint, 11AE0F91.E489CC87> dictionary247 = this.891D0FB6;
						num = 741582647U - num;
						uint key237 = num ^ 3601806803U;
						num *= 1277406863U;
						11AE0F91.E489CC87 value131 = new 11AE0F91.E489CC87(this.C535480E);
						num = 3491066540U % num;
						dictionary247[key237] = value131;
						num *= 2434223295U;
						Dictionary<uint, 11AE0F91.E489CC87> dictionary248 = this.891D0FB6;
						num = 2291428644U % num;
						uint key238 = num + 2003538905U;
						num = 546955303U >> (int)num;
						dictionary248[key238] = new 11AE0F91.E489CC87(this.458B70A4);
						Dictionary<uint, 11AE0F91.E489CC87> dictionary249 = this.891D0FB6;
						num = 2424804741U >> (int)num;
						uint key239 = num ^ 606201247U;
						num = 3046607906U << (int)num;
						IntPtr 09069C1A137 = ldftn(DFB9313F);
						num <<= 7;
						dictionary249[key239] = new 11AE0F91.E489CC87(this, 09069C1A137);
						num = (3643056401U ^ num);
						if (3784590495U + num != 0U)
						{
							goto Block_128;
						}
					}
				}
			}
			Block_128:
			num = 178507416U * num;
			Dictionary<uint, 11AE0F91.E489CC87> dictionary250 = this.891D0FB6;
			num = 92651535U * num;
			uint key240 = num - 2931392617U;
			IntPtr 09069C1A138 = ldftn(30382632);
			num *= 3065559985U;
			dictionary250[key240] = new 11AE0F91.E489CC87(this, 09069C1A138);
		}
		while (330178470U % num == 0U);
	}

	// Token: 0x04000149 RID: 329
	private static readonly Dictionary<object, DynamicMethod> A2896C2E;

	// Token: 0x0400014A RID: 330
	private static readonly Module 08BC110D;

	// Token: 0x0400014B RID: 331
	private 11AE0F91.628F1DA3 FE3CF238;

	// Token: 0x0400014C RID: 332
	private 11AE0F91.833BF530 4FA4D617;

	// Token: 0x0400014D RID: 333
	private Exception 70BBF99F;

	// Token: 0x0400014E RID: 334
	private 11AE0F91.6B1722AF 620F8223;

	// Token: 0x0400014F RID: 335
	private 11AE0F91.5F355D3D 16011CAB;

	// Token: 0x04000150 RID: 336
	private List<IntPtr> 93160723;

	// Token: 0x04000151 RID: 337
	private static readonly Dictionary<uint, object> A314EB83;

	// Token: 0x04000152 RID: 338
	private readonly Dictionary<uint, 11AE0F91.E489CC87> 891D0FB6;

	// Token: 0x02000013 RID: 19
	private sealed class 6B1722AF : 11AE0F91.1280CA96
	{
		// Token: 0x06000074 RID: 116 RVA: 0x0006720C File Offset: 0x00064E0C
		public override int B395DB29()
		{
			return 0;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000671F4 File Offset: 0x00064DF4
		public int 21AF50A3()
		{
			return this.80189688.Count;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0006721C File Offset: 0x00064E1C
		public override void 37242F0A(int C087F490)
		{
			for (;;)
			{
				uint num = 3037905587U;
				int num2 = (int)(num ^ 3037905587U);
				num = (263931915U & num);
				int num3 = num2;
				if (num >= 2787279778U)
				{
					goto IL_61;
				}
				IL_A2:
				num ^= 1528399629U;
				if (num >= 2336061441U)
				{
					continue;
				}
				int num4 = num3;
				num = (1444678543U ^ num);
				num += 3215747250U;
				List<11AE0F91.5F827F8F> e92E51B = this.E92E51B4;
				num |= 882662686U;
				int count = e92E51B.Count;
				num ^= 876030389U;
				if (num4 >= count)
				{
					break;
				}
				goto IL_26;
				IL_7D:
				if (num != 3901605032U)
				{
					int num5 = num3 + (int)(num - 523894714U);
					num ^= 2710359199U;
					num3 = num5;
					num += 1180503263U;
					goto IL_A2;
				}
				goto IL_26;
				IL_61:
				Stack<int> stack = this.80189688;
				int item = num3;
				num -= 909270293U;
				stack.Push(item);
				num += 909270293U;
				goto IL_7D;
				IL_26:
				num = 336006201U;
				num += 372416138U;
				List<11AE0F91.5F827F8F> e92E51B2 = this.E92E51B4;
				int index = num3;
				num = 831506835U >> (int)num;
				int num6 = e92E51B2[index].0110ADB4();
				num |= 423120779U;
				if (num6 == C087F490)
				{
					goto IL_61;
				}
				goto IL_7D;
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00067370 File Offset: 0x00064F70
		public 6B1722AF()
		{
			uint num;
			do
			{
				this.E92E51B4 = new List<11AE0F91.5F827F8F>();
				num = 431758101U;
			}
			while (num == 2897491764U);
			do
			{
				Stack<int> stack = new Stack<int>();
				num &= 2638061312U;
				this.80189688 = stack;
				num = 555311621U / num;
				if (1554439073U <= num)
				{
					break;
				}
				num &= 1606395154U;
				base..ctor();
			}
			while (num >= 463561007U);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00067310 File Offset: 0x00064F10
		public 11AE0F91.5F827F8F 181C1CA4()
		{
			uint num = 20451586U;
			List<11AE0F91.5F827F8F> e92E51B = this.E92E51B4;
			Stack<int> stack = this.80189688;
			num %= 3206046994U;
			return e92E51B[stack.Pop()];
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00067344 File Offset: 0x00064F44
		public 11AE0F91.5F827F8F 0E82BAB5()
		{
			return this.E92E51B4[this.80189688.Peek()];
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00066E60 File Offset: 0x00064A60
		public void C3BD7807(int A399EF8E, int EB2EDC25, byte 4CA16EB5, int E50D0FB7, int F73C5FAD)
		{
			uint num = 1337714485U;
			for (;;)
			{
				IL_07:
				11AE0F91.5F827F8F 5F827F8F = null;
				for (;;)
				{
					IL_09:
					num = (3097584897U & num);
					int num2 = (int)(num + 4150172415U);
					if (num == 3861351187U)
					{
						break;
					}
					for (;;)
					{
						bool flag3;
						int num6;
						for (;;)
						{
							int num3 = num2;
							num |= 4177837612U;
							int count = this.E92E51B4.Count;
							num = 3886389121U % num;
							if (num3 >= count)
							{
								num += 2350404939U;
								goto IL_119;
							}
							num = 765047696U;
							num /= 713127040U;
							List<11AE0F91.5F827F8F> e92E51B = this.E92E51B4;
							int index = num2;
							num = (1988783499U & num);
							11AE0F91.5F827F8F 5F827F8F2 = e92E51B[index];
							num = 1234915347U - num;
							if (1905930686U - num == 0U)
							{
								goto IL_09;
							}
							IL_6C:
							11AE0F91.5F827F8F 5F827F8F3 = 5F827F8F2;
							num >>= 14;
							if (5F827F8F3.0110ADB4() == A399EF8E)
							{
								int num4 = 5F827F8F2.BD34EE0E();
								num = 204244522U * num;
								num ^= 1359510927U;
								if (num4 == EB2EDC25)
								{
									num ^= 1941752481U;
									if (3374149935U != num)
									{
										5F827F8F = 5F827F8F2;
										goto IL_119;
									}
									goto IL_07;
								}
							}
							num = 3995937310U * num;
							if (num != 1237081349U)
							{
								num2 += (int)(num - 1201234629U);
								num += 3238527547U;
								continue;
							}
							goto IL_07;
							IL_119:
							num &= 480780801U;
							if (2024176903U <= num)
							{
								goto IL_07;
							}
							bool flag = 5F827F8F != null;
							num ^= 958396448U;
							if (flag)
							{
								break;
							}
							num &= 1950022308U;
							bool flag2 = (num ^ 540203040U) != 0U;
							num = 2963587225U << (int)num;
							flag3 = flag2;
							if (2810787507U + num != 0U)
							{
								num = 1476789255U * num;
								num <<= 15;
								5F827F8F = new 11AE0F91.5F827F8F(A399EF8E, EB2EDC25);
								int num5 = (int)(num ^ 3558309888U);
								num ^= 2508316675U;
								num6 = num5;
								while (2486701714U >> (int)num != 0U)
								{
									int num7 = num6;
									num = 4045188227U >> (int)num;
									List<11AE0F91.5F827F8F> e92E51B2 = this.E92E51B4;
									num = 1602407829U << (int)num;
									int count2 = e92E51B2.Count;
									num = 319238304U / num;
									if (num7 >= count2)
									{
										goto Block_12;
									}
									num = 2637289489U;
									List<11AE0F91.5F827F8F> e92E51B3 = this.E92E51B4;
									num += 3667572358U;
									int index2 = num6;
									num -= 1957425450U;
									11AE0F91.5F827F8F 5F827F8F4 = e92E51B3[index2];
									num = (3675118383U & num);
									11AE0F91.5F827F8F 2B840A = 5F827F8F4;
									if (3835421969U % num == 0U)
									{
										goto IL_6C;
									}
									11AE0F91.5F827F8F 5F827F8F5 = 5F827F8F;
									num %= 447397804U;
									if (5F827F8F5.67B53191(2B840A) < (int)(num + 4244596435U))
									{
										goto Block_10;
									}
									num /= 3149921690U;
									int num8 = num6;
									num = 3726534570U >> (int)num;
									int num9 = (int)(num + 568432727U);
									num = 2452437396U >> (int)num;
									num6 = num8 + num9;
									num ^= 1102244685U;
								}
								goto IL_07;
							}
							goto IL_07;
						}
						IL_339:
						num = 1956540448U - num;
						if (num > 1503052854U)
						{
							continue;
						}
						11AE0F91.5F827F8F 5F827F8F6 = 5F827F8F;
						num *= 111089418U;
						num /= 380966956U;
						num %= 2996954011U;
						5F827F8F6.95AC6191(4CA16EB5, E50D0FB7, F73C5FAD);
						if (num <= 3489984169U)
						{
							return;
						}
						continue;
						IL_2F2:
						num = 1857876777U + num;
						bool flag4 = flag3;
						num ^= 489180857U;
						if (flag4)
						{
							goto IL_339;
						}
						num = (3031885574U & num);
						if (num % 967137696U != 0U)
						{
							this.E92E51B4.Add(5F827F8F);
							num += 151066656U;
							goto IL_339;
						}
						goto IL_07;
						Block_12:
						num ^= 3319964528U;
						goto IL_2F2;
						Block_10:
						num = (1797513103U & num);
						num = 2174406322U >> (int)num;
						List<11AE0F91.5F827F8F> e92E51B4 = this.E92E51B4;
						num += 381485493U;
						int index3 = num6;
						11AE0F91.5F827F8F item = 5F827F8F;
						num >>= 6;
						e92E51B4.Insert(index3, item);
						num *= 3968297752U;
						flag3 = (num + 975002769U != 0U);
						goto IL_2F2;
					}
				}
			}
		}

		// Token: 0x04000049 RID: 73
		private Stack<int> 80189688;

		// Token: 0x0400004A RID: 74
		private List<11AE0F91.5F827F8F> E92E51B4;
	}

	// Token: 0x02000024 RID: 36
	private sealed class 4E9D35B2 : 11AE0F91.FCB842B2
	{
		// Token: 0x06000114 RID: 276 RVA: 0x0006469C File Offset: 0x0006229C
		public override object D697DB31()
		{
			uint num = 1781286318U;
			num |= 2920820225U;
			return this.82990408.D697DB31();
		}

		// Token: 0x06000115 RID: 277 RVA: 0x000646C4 File Offset: 0x000622C4
		public override void 7E869424(object A80A2982)
		{
			uint num = 2098866987U;
			11AE0F91.80068AA5 80068AA = this.82990408;
			num = 1326075558U >> (int)num;
			80068AA.7E869424(A80A2982);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x000646F4 File Offset: 0x000622F4
		public override object 0681AA27(FieldInfo E71C7638)
		{
			uint num = 1755765688U;
			num &= 3280646148U;
			11AE0F91.80068AA5 80068AA = this.82990408;
			num = 2132980386U / num;
			return 80068AA.0681AA27(E71C7638);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00064654 File Offset: 0x00062254
		public override Type 20129380()
		{
			uint num = 3039049746U;
			num = (1200571018U | num);
			11AE0F91.80068AA5 80068AA = this.82990408;
			num /= 302490685U;
			return 80068AA.20129380();
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00064724 File Offset: 0x00062324
		public override void B534E11F(FieldInfo A6AADA90, object 6B97E7B5)
		{
			uint num = 3995694911U;
			11AE0F91.80068AA5 80068AA = this.82990408;
			num -= 260061228U;
			num = (2232710055U & num);
			80068AA.B534E11F(A6AADA90, 6B97E7B5);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00064684 File Offset: 0x00062284
		public override 11AE0F91.80068AA5 ECAA59A1()
		{
			return new 11AE0F91.4E9D35B2(this.82990408);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00064618 File Offset: 0x00062218
		public 4E9D35B2(11AE0F91.80068AA5 E08B6504)
		{
			uint num = 203683218U;
			base..ctor();
			num *= 179101192U;
			if (-894014674 << (int)num != 0)
			{
				this.82990408 = E08B6504;
			}
		}

		// Token: 0x0400007C RID: 124
		private 11AE0F91.80068AA5 82990408;
	}

	// Token: 0x0200002F RID: 47
	private sealed class CB943E91 : 11AE0F91.6012BE05
	{
		// Token: 0x0600014F RID: 335 RVA: 0x0005FDD8 File Offset: 0x0005D9D8
		public override double DD227D0D()
		{
			return (double)this.B61A7D01;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0005FD98 File Offset: 0x0005D998
		public override ulong 6D84E72D()
		{
			return (ulong)this.B61A7D01;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0005FC00 File Offset: 0x0005D800
		public override object D697DB31()
		{
			return this.B61A7D01;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00060498 File Offset: 0x0005E098
		public static 11AE0F91.80068AA5 3195F2BC(11AE0F91.80068AA5 71AC249A, 11AE0F91.80068AA5 3092593C)
		{
			uint num;
			uint num7;
			11AE0F91.CB943E91 cb943E2;
			int num8;
			do
			{
				num = 3330413342U;
				uint num2 = 71AC249A.98A2A683();
				num *= 2241189789U;
				uint num3 = ~num2;
				num = (673758903U & num);
				uint num4 = ~3092593C.98A2A683();
				num &= 764852018U;
				uint num5 = num4;
				num = (1931362192U ^ num);
				uint num6 = num3 & num5;
				num |= 127804466U;
				num7 = num6;
				num >>= 26;
				if (num << 7 != 0U)
				{
					11AE0F91.CB943E91 cb943E = new 11AE0F91.CB943E91((int)num7);
					num |= 546527790U;
					cb943E2 = cb943E;
					do
					{
						num = 2156302637U - num;
						num8 = (int)(num ^ 1609774830U);
						num /= 3811812632U;
					}
					while ((num ^ 1093112202U) == 0U);
				}
				bool flag = num7 != 0U;
				num *= 1486806809U;
				if (flag)
				{
					goto IL_C3;
				}
			}
			while ((num & 2332372133U) != 0U);
			IL_A4:
			int num9 = num8;
			num = 2586382128U - num;
			int num10 = (int)(num - 2586382127U);
			num %= 279667109U;
			num8 = (num9 | num10);
			goto IL_10A;
			IL_C3:
			uint num11 = num7;
			num = (4105895313U ^ num);
			int num12 = (int)(num + 189072014U);
			num = 3661340728U * num;
			bool flag2 = num11 >> num12;
			num ^= 1441773531U;
			if (flag2)
			{
				num = 3691334203U >> (int)num;
				num8 |= (int)(num - 461416767U);
				num ^= 530712868U;
			}
			IL_10A:
			num = 394307763U * num;
			if ((211847053U ^ num) != 0U)
			{
				11AE0F91.80068AA5 80068AA = cb943E2;
				num = 1362602650U - num;
				int c7A9131D = num8;
				num = (884805552U | num);
				80068AA.3F831A1B(c7A9131D);
				num = 2143158159U / num;
				return cb943E2;
			}
			goto IL_A4;
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0005FD68 File Offset: 0x0005D968
		public override ushort CF9960A3()
		{
			return (ushort)this.B61A7D01;
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0005FC18 File Offset: 0x0005D818
		public override void 7E869424(object CC1C188D)
		{
			uint num = 613306928U;
			if (num / 1343142162U == 0U)
			{
				do
				{
					num <<= 24;
					num = (3300146193U | num);
					this.B61A7D01 = Convert.ToInt32(CC1C188D);
				}
				while ((2100237578U ^ num) == 0U);
			}
		}

		// Token: 0x06000155 RID: 341 RVA: 0x0005FCD4 File Offset: 0x0005D8D4
		public override int 30B7A98C()
		{
			uint num = 2508400531U;
			num = 2335250959U >> (int)num;
			return this.B61A7D01;
		}

		// Token: 0x06000156 RID: 342 RVA: 0x0005FE34 File Offset: 0x0005DA34
		public static 11AE0F91.80068AA5 1127EB82(11AE0F91.80068AA5 84274886, 11AE0F91.80068AA5 8E1F55A4)
		{
			uint num = 1292801042U;
			11AE0F91.CB943E91 cb943E2;
			if (3912173322U > num)
			{
				for (;;)
				{
					num = 2584550697U << (int)num;
					uint num2 = 84274886.98A2A683();
					num = (3842300078U | num);
					uint num3 = 8E1F55A4.98A2A683();
					num = 2931311142U + num;
					uint num4 = num2 + num3;
					num = 1017615295U << (int)num;
					11AE0F91.CB943E91 cb943E = new 11AE0F91.CB943E91((int)num4);
					num = 2831153209U % num;
					cb943E2 = cb943E;
					int num5 = (int)(num + 3474982855U);
					num = (599646508U | num);
					int num6 = num5;
					num = 1421034912U - num;
					uint num7 = num ^ 2696105059U;
					num = (4135743401U & num);
					uint num8 = num7;
					num = 974870028U / num;
					bool flag = (num2 ^ num4) != 0U;
					num = 1662831283U % num;
					bool flag2 = num3 != 0U;
					num = (472995105U ^ num);
					bool flag3 = ((flag2 ? 1U : 0U) ^ num4) != 0U;
					num = 3794909447U >> (int)num;
					bool flag4 = flag && flag3;
					num &= 2831108752U;
					bool flag5 = ((flag4 ? 1U : 0U) & num8) != 0U;
					num = (1593955353U & num);
					if (flag5)
					{
						int num9 = num6 | (int)(num - 16368U);
						num >>= 22;
						num6 = num9;
						num ^= 16384U;
					}
					num = 1159327785U << (int)num;
					bool flag6 = num3 != 0U;
					num <<= 12;
					bool flag7 = (num2 ^ (flag6 ? 1U : 0U)) != 0U;
					bool flag8 = num3 != 0U;
					bool flag9 = num4 != 0U;
					num = 1276159027U - num;
					bool flag10 = flag8 ^ flag9;
					num = 1186730166U - num;
					bool flag11 = flag7 && flag10;
					num = 2483804860U << (int)num;
					bool flag12 = (num2 ^ (flag11 ? 1U : 0U)) != 0U;
					num %= 3584330676U;
					bool flag13 = ((flag12 ? 1U : 0U) & num8) != 0U;
					num &= 178763023U;
					if (flag13)
					{
						num &= 3785534235U;
						if (num > 192989985U)
						{
							continue;
						}
						int num10 = num6;
						num = 177464580U - num;
						int num11 = num10 | (int)(num ^ 177300548U);
						num *= 4147490610U;
						num6 = num11;
						num ^= 77517256U;
					}
					num += 3322819488U;
					if ((3256244274U ^ num) != 0U)
					{
						cb943E2.3F831A1B(num6);
						if (1973829670U != num)
						{
							break;
						}
					}
				}
			}
			return cb943E2;
		}

		// Token: 0x06000157 RID: 343 RVA: 0x0005FCFC File Offset: 0x0005D8FC
		public override long D20998B6()
		{
			uint num = 3373372562U;
			long b61A7D = (long)this.B61A7D01;
			num = 2839083915U * num;
			return b61A7D;
		}

		// Token: 0x06000158 RID: 344 RVA: 0x0005FC98 File Offset: 0x0005D898
		public override sbyte 482F2014()
		{
			uint num = 974316942U;
			sbyte b61A7D = (sbyte)this.B61A7D01;
			num = 1857760518U << (int)num;
			return b61A7D;
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0005FC60 File Offset: 0x0005D860
		public override bool 2206A10D()
		{
			uint num = 2654575017U;
			int b61A7D = this.B61A7D01;
			num = 1748116782U << (int)num;
			uint num2 = num ^ 1682594816U;
			num -= 1948966283U;
			return b61A7D > num2;
		}

		// Token: 0x0600015A RID: 346 RVA: 0x0005FBB4 File Offset: 0x0005D7B4
		public override Type 20129380()
		{
			return typeof(int);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0005FD44 File Offset: 0x0005D944
		public override byte B508A9AB()
		{
			uint num = 1938084482U;
			byte b61A7D = (byte)this.B61A7D01;
			num %= 3272490006U;
			return b61A7D;
		}

		// Token: 0x0600015C RID: 348 RVA: 0x0006072C File Offset: 0x0005E32C
		public static 11AE0F91.80068AA5 15917E88(11AE0F91.80068AA5 4FAC339C, 11AE0F91.80068AA5 E42FF0BD)
		{
			uint num;
			do
			{
				num = 3761091881U;
				int num2 = E42FF0BD.3BA55C01();
				uint num3 = num ^ 3761091885U;
				num = 3275557127U >> (int)num;
				object obj = num2 & (int)num3;
				num = (3392698504U | num);
				uint num4 = num ^ 3396992652U;
				num >>= 24;
				bool flag = obj > num4;
				num = 3984620931U << (int)num;
				if (!flag)
				{
					goto IL_97;
				}
				num = 3652974735U / num;
			}
			while (num + 2441610521U == 0U);
			IL_62:
			uint num5 = 4FAC339C.98A2A683();
			num = 1696917157U / num;
			int num6 = E42FF0BD.30B7A98C();
			num &= 2519904537U;
			int num7 = num6;
			int num8 = num7 & (int)(num + 4292870158U);
			num /= 872769302U;
			return new 11AE0F91.CB943E91(num5 >> num8);
			IL_97:
			if (213045692U >= num)
			{
				num -= 3467463454U;
				int num9 = 4FAC339C.30B7A98C();
				num = 93084071U << (int)num;
				int num10 = E42FF0BD.30B7A98C();
				num /= 3158309916U;
				int num11 = num10;
				num = 2491945131U << (int)num;
				int num12 = (int)(num ^ 2491945140U);
				num += 2929126160U;
				int e99A = num9 >> (num11 & num12);
				num = 45392913U / num;
				return new 11AE0F91.CB943E91(e99A);
			}
			goto IL_62;
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0005FD7C File Offset: 0x0005D97C
		public override uint 98A2A683()
		{
			return (uint)this.B61A7D01;
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0005FBCC File Offset: 0x0005D7CC
		public override 11AE0F91.80068AA5 ECAA59A1()
		{
			11AE0F91.CB943E91 cb943E = new 11AE0F91.CB943E91(this.B61A7D01);
			uint num = 990846992U;
			num = (2852514456U ^ num);
			cb943E.3F831A1B(this.3BA55C01());
			return cb943E;
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0006088C File Offset: 0x0005E48C
		public static 11AE0F91.80068AA5 041A47B4(11AE0F91.80068AA5 693B5EA7, 11AE0F91.80068AA5 2186702E)
		{
			int num2;
			for (;;)
			{
				IL_00:
				uint num = 3477000989U;
				num2 = (int)(num - 3477000989U);
				num = 2147789106U % num;
				for (;;)
				{
					num %= 3493563067U;
					if ((2186702E.3BA55C01() & (int)(num ^ 2147789110U)) > (int)(num ^ 2147789106U))
					{
						if (num - 3627472418U == 0U)
						{
							continue;
						}
					}
					else
					{
						num = 4021170222U * num;
						int num3 = 693B5EA7.30B7A98C();
						num = 2511661868U << (int)num;
						int num4 = num3;
						num &= 344441146U;
						if (num * 2619629970U != 0U)
						{
							break;
						}
						int num5 = 2186702E.30B7A98C();
						num = 2185033254U * num;
						if (2493761834U == num)
						{
							break;
						}
						int num6 = num4;
						num ^= 2634576544U;
						int num7 = num5;
						num *= 1672570943U;
						if (num6 == num7)
						{
							num = 841854503U << (int)num;
							if (2216505662U - num != 0U)
							{
								int num8 = num2;
								num >>= 24;
								int num9 = num8 | (int)(num ^ 51U);
								num -= 3080856510U;
								num2 = num9;
								num ^= 1213683955U;
								goto IL_255;
							}
							break;
						}
						else
						{
							num /= 3911647365U;
							int num10 = num4;
							num %= 1125709219U;
							int num11 = num5;
							num ^= 689287U;
							if (num10 >= num11)
							{
								goto IL_255;
							}
							num += 3921064228U;
							if (1938195734U <= num)
							{
								int num12 = num2;
								int num13 = (int)(num - 3921753507U);
								num = 3542526468U + num;
								num2 = (num12 | num13);
								num ^= 3169671976U;
								goto IL_255;
							}
						}
					}
					for (;;)
					{
						uint num14 = 693B5EA7.98A2A683();
						if (num == 599456431U)
						{
							goto IL_00;
						}
						num = 1655124354U * num;
						uint num15 = 2186702E.98A2A683();
						if (3733970089U != num)
						{
							uint num16 = num14;
							uint num17 = num15;
							num %= 1957803U;
							if (num16 == num17)
							{
								break;
							}
							if (num <= 842447794U)
							{
								uint num18 = num14;
								uint num19 = num15;
								num ^= 331608U;
								if (num18 >= num19)
								{
									goto IL_255;
								}
								num -= 3356426025U;
								if (2484276021U / num == 0U)
								{
									goto IL_00;
								}
								int num20 = num2;
								num *= 2676514988U;
								int num21 = num20 | (int)(num ^ 720427808U);
								num = 834220478U >> (int)num;
								num2 = num21;
								if ((261902722U & num) != 0U)
								{
									goto Block_7;
								}
							}
						}
					}
					num = (4271125283U | num);
					int num22 = num2;
					num &= 798731280U;
					int num23 = (int)(num - 781953039U);
					num ^= 606023462U;
					int num24 = num22 | num23;
					num >>= 8;
					num2 = num24;
					goto IL_255;
					Block_7:
					num += 4292397910U;
					IL_255:
					if (825310014U + num != 0U)
					{
						goto Block_14;
					}
				}
			}
			Block_14:
			return new 11AE0F91.CB943E91(num2);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x000603C4 File Offset: 0x0005DFC4
		public static 11AE0F91.80068AA5 823F3018(11AE0F91.80068AA5 1DBE1419, 11AE0F91.80068AA5 C82775BD)
		{
			uint num = 270137356U;
			int num2 = C82775BD.3BA55C01();
			uint num3 = num ^ 270137352U;
			num += 993076905U;
			object obj = num2 & (int)num3;
			uint num4 = num + 3031753035U;
			num >>= 2;
			bool flag = obj > num4;
			num >>= 9;
			if (!flag)
			{
				num += 2677565330U;
				if (num > 1887846549U)
				{
					num = (951439242U & num);
					int num5 = 1DBE1419.30B7A98C();
					num = 1227099679U << (int)num;
					num *= 848034323U;
					int num6 = C82775BD.30B7A98C();
					num >>= 3;
					int e99A = num5 % num6;
					num = (2579476148U & num);
					return new 11AE0F91.CB943E91(e99A);
				}
			}
			int num7 = (int)1DBE1419.98A2A683();
			num = (538815019U | num);
			uint num8 = C82775BD.98A2A683();
			num = 3098808121U + num;
			uint num9 = num8;
			num %= 2534295464U;
			int num10 = (int)num9;
			num = 4262657550U * num;
			return new 11AE0F91.CB943E91(num7 % num10);
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00060B04 File Offset: 0x0005E704
		public static 11AE0F91.80068AA5 3B302122(11AE0F91.80068AA5 41B799B1)
		{
			uint num = 530643508U;
			int num4;
			for (;;)
			{
				IL_06:
				ulong num2 = 41B799B1.6D84E72D();
				if (3332161689U != num)
				{
					goto IL_18;
				}
				bool flag;
				for (;;)
				{
					IL_50:
					int num3 = (int)(num - 22549334U);
					num >>= 8;
					num4 = num3;
					if ((3439658882U ^ num) == 0U)
					{
						break;
					}
					for (;;)
					{
						ulong num5 = num2;
						long num6 = num ^ 2147395564U;
						num %= 1455259298U;
						long num7 = num6;
						num -= 246172052U;
						if (num5 > num7)
						{
							goto IL_DC;
						}
						num = 3239276453U >> (int)num;
						if ((1074232225U & num) == 0U)
						{
							break;
						}
						if (!flag)
						{
							if (2938342838U - num == 0U)
							{
								goto IL_DC;
							}
							int num8 = (int)num2;
							num ^= 1915666231U;
							uint num9 = num - 4063149878U;
							num ^= 1915666231U;
							if (num8 < num9)
							{
								num += 4048883326U;
								goto IL_DC;
							}
						}
						IL_112:
						int num10 = (int)num2;
						num <<= 5;
						41B799B1 = new 11AE0F91.CB943E91(num10);
						num = 2794743553U >> (int)num;
						if (num != 1117734925U)
						{
							goto Block_7;
						}
						continue;
						IL_DC:
						if (3484771592U / num == 0U)
						{
							int num11 = num4;
							num >>= 25;
							int num12 = (int)(num ^ 104U);
							num ^= 1879846913U;
							int num13 = num11 | num12;
							num *= 1896605862U;
							num4 = num13;
							num ^= 839390839U;
							goto IL_112;
						}
						goto IL_06;
					}
				}
				IL_18:
				uint num14 = 41B799B1.3BA55C01();
				num *= 3776565549U;
				uint num15 = num14 & (num ^ 514092832U);
				num = (562056581U | num);
				uint num16 = num + 3227226203U;
				num = 2252136636U % num;
				bool flag2 = num15 > num16;
				num %= 94105116U;
				flag = flag2;
				goto IL_50;
			}
			Block_7:
			11AE0F91.80068AA5 80068AA = 41B799B1;
			int c7A9131D = num4;
			num = 4206708889U << (int)num;
			80068AA.3F831A1B(c7A9131D);
			num = 4163537547U - num;
			return 41B799B1;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0005FDB4 File Offset: 0x0005D9B4
		public override float 599106A4()
		{
			uint num = 312223423U;
			float b61A7D = (float)this.B61A7D01;
			num >>= 28;
			return b61A7D;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00060834 File Offset: 0x0005E434
		public static 11AE0F91.80068AA5 9315E01E(11AE0F91.80068AA5 25968AB9, 11AE0F91.80068AA5 E59E4D1A)
		{
			int num = 25968AB9.30B7A98C();
			uint num2 = 598833966U;
			num2 = 1821512340U >> (int)num2;
			int num3 = E59E4D1A.30B7A98C();
			num2 <<= 24;
			int num4 = num3;
			num2 = 1680451734U / num2;
			int num5 = num4 & (int)(num2 - 4294967266U);
			num2 = 2888322704U * num2;
			return new 11AE0F91.CB943E91(num << num5);
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0005FD20 File Offset: 0x0005D920
		public override char 8EBDB806()
		{
			uint num = 2215924880U;
			char b61A7D = (char)this.B61A7D01;
			num /= 1728662200U;
			return b61A7D;
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0005FCC0 File Offset: 0x0005D8C0
		public override short C6A6922C()
		{
			return (short)this.B61A7D01;
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00060320 File Offset: 0x0005DF20
		public static 11AE0F91.80068AA5 83352C2C(11AE0F91.80068AA5 97880782, 11AE0F91.80068AA5 A52CDCA0)
		{
			uint num = 187981610U;
			if (num != 545616907U)
			{
				uint num2 = (uint)A52CDCA0.3BA55C01();
				num >>= 4;
				uint num3 = num - 11748846U;
				num = 3098657449U - num;
				bool flag = (num2 & num3) > num - 3086908599U;
				num /= 682435995U;
				if (!flag)
				{
					int num4 = 97880782.30B7A98C();
					int num5 = A52CDCA0.30B7A98C();
					num ^= 823182745U;
					int num6 = num5;
					num |= 3372571303U;
					return new 11AE0F91.CB943E91(num4 / num6);
				}
			}
			int num7 = (int)97880782.98A2A683();
			uint num8 = A52CDCA0.98A2A683();
			num %= 1301083139U;
			int num9 = (int)num8;
			num -= 2016113052U;
			int e99A = num7 / num9;
			num = (1209030797U & num);
			return new 11AE0F91.CB943E91(e99A);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x000605E4 File Offset: 0x0005E1E4
		public static 11AE0F91.80068AA5 CF0D6F0C(11AE0F91.80068AA5 6E0C1F39, 11AE0F91.80068AA5 9BB5A19A)
		{
			11AE0F91.CB943E91 cb943E;
			for (;;)
			{
				uint num = 77693207U;
				uint num2 = 6E0C1F39.98A2A683();
				num -= 4279204240U;
				uint num3 = ~num2;
				num %= 985361440U;
				num = 201968937U + num;
				uint num4 = ~9BB5A19A.98A2A683();
				num = 679733555U + num;
				uint num5 = num4;
				num = (1253038627U & num);
				uint num6 = num5;
				num %= 2853941000U;
				uint num7 = num3 | num6;
				num = 755402386U + num;
				uint num8 = num7;
				num = 2862340113U - num;
				int num10;
				if (1312346384U < num)
				{
					int e99A = (int)num8;
					num += 2097656210U;
					cb943E = new 11AE0F91.CB943E91(e99A);
					int num9 = (int)(num - 4035799790U);
					num = (1647154493U & num);
					num10 = num9;
					num = 43065605U - num;
					if (num8 == 0U)
					{
						num = (647094786U & num);
						int num11 = num10;
						num = (1050257302U | num);
						num10 = (num11 | (int)(num ^ 1050257303U));
					}
					else
					{
						num = (454025359U & num);
						if ((3893175961U & num) == 0U)
						{
							continue;
						}
						uint num12 = num8;
						num -= 4177782416U;
						bool flag = num12 >> (int)(num ^ 151009766U);
						num += 899247517U;
						if (flag)
						{
							num &= 1413461177U;
							int num13 = num10;
							num += 1888212238U;
							int num14 = num13 | (int)(num ^ 2225437078U);
							num = 2693122959U - num;
							num10 = num14;
							num += 582571429U;
						}
					}
				}
				IL_10D:
				num *= 4028608541U;
				11AE0F91.80068AA5 80068AA = cb943E;
				num = 2382803998U / num;
				80068AA.3F831A1B(num10);
				num = 1627969171U * num;
				if (num < 3861621419U)
				{
					break;
				}
				continue;
				goto IL_10D;
			}
			return cb943E;
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0005FDF4 File Offset: 0x0005D9F4
		public override IntPtr D20542BB()
		{
			return new IntPtr(this.B61A7D01);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0005FFDC File Offset: 0x0005DBDC
		public static 11AE0F91.80068AA5 69235B90(11AE0F91.80068AA5 6B8D0827, 11AE0F91.80068AA5 F4A21B97)
		{
			uint num = 1799120269U;
			if (4001417636U < num)
			{
				goto IL_59;
			}
			IL_13:
			num = 4130086827U << (int)num;
			uint num2 = 6B8D0827.98A2A683();
			if ((2426716338U ^ num) == 0U)
			{
				goto IL_59;
			}
			IL_37:
			num = 3526454071U << (int)num;
			uint num3 = F4A21B97.98A2A683();
			num = 4112863413U % num;
			uint num4 = num3;
			IL_59:
			ulong num5 = (ulong)(num2 * num4);
			num ^= 151755703U;
			ulong num6 = num5;
			num = 763435036U >> (int)num;
			ulong num7 = num6;
			uint num8;
			11AE0F91.CB943E91 cb943E;
			if (num << 4 != 0U)
			{
				num8 = (uint)num7;
				num = 648579076U - num;
				if (1233545906U / num == 0U)
				{
					goto IL_37;
				}
				int e99A = (int)num8;
				num /= 3557869629U;
				cb943E = new 11AE0F91.CB943E91(e99A);
			}
			int num9 = (int)(num ^ 0U);
			num &= 1720663711U;
			int num10 = num9;
			uint num11 = num ^ 2147483648U;
			bool flag = num2 != 0U;
			bool flag2 = num8 != 0U;
			num = 1410018066U << (int)num;
			bool flag3 = flag ^ flag2;
			num <<= 13;
			bool flag4 = num4 != 0U;
			bool flag5 = num8 != 0U;
			num &= 3709220766U;
			bool flag6 = flag3 & (flag4 ^ flag5);
			bool flag7 = num11 != 0U;
			num = 3105243021U << (int)num;
			if (flag6 && flag7)
			{
				num -= 2550930216U;
				int num12 = num10 | (int)(num + 3740654507U);
				num = 731197334U - num;
				num10 = num12;
				num += 2928358492U;
			}
			num = 4038062248U / num;
			if (1789309109U / num == 0U)
			{
				goto IL_37;
			}
			bool flag8 = num2 != 0U;
			num = (2676442036U & num);
			bool flag9 = (num2 ^ num4) != 0U;
			num |= 563430198U;
			bool flag10 = num4 != 0U;
			num &= 4044509197U;
			bool flag11 = ((flag10 ? 1U : 0U) ^ num8) != 0U;
			num %= 875549057U;
			bool flag12 = flag9 && flag11;
			num &= 2931035427U;
			bool flag13 = flag8 ^ flag12;
			bool flag14 = num11 != 0U;
			num *= 4171260163U;
			bool flag15 = flag13 && flag14;
			num = 17497505U >> (int)num;
			if (flag15)
			{
				if (num * 713164548U == 0U)
				{
					goto IL_13;
				}
				int num13 = num10;
				num /= 125881112U;
				int num14 = num13 | (int)(num + 64U);
				num = 3944346012U << (int)num;
				num10 = num14;
				num ^= 3927116861U;
			}
			uint num15 = F4A21B97.3BA55C01();
			num |= 3324821159U;
			uint num16 = num15 & (num ^ 3341746083U);
			uint num17 = num ^ 3341746087U;
			num = 663800866U % num;
			if (num16 > num17)
			{
				bool flag16 = num7 != 0UL;
				bool flag17 = (ulong)(num ^ 3631166429U) != 0UL;
				num = (2780357672U & num);
				bool flag18 = flag16 && flag17;
				num = 914862867U + num;
				if (flag18)
				{
					num *= 1185620152U;
					int num18 = num10;
					num |= 320132997U;
					num10 = (num18 | (int)(num ^ 3550339053U));
					num ^= 2407901342U;
				}
			}
			else
			{
				if (-627582038 << (int)num == 0)
				{
					goto IL_37;
				}
				long num19 = (long)num2;
				num = 2357272709U / num;
				long num20 = num19 * (long)num4;
				num <<= 21;
				num7 = (ulong)num20;
				num = 1435629448U / num;
				ulong num21 = num7;
				num <<= 0;
				object obj = num21 >> (int)(num ^ 219U);
				ulong num22 = (ulong)(num8 >> (int)(num - 197U));
				num += 1545107023U;
				if (obj != num22)
				{
					if (1594902279U < num)
					{
						goto IL_37;
					}
					int num23 = num10;
					int num24 = (int)(num + 2749860061U);
					num = (78595715U & num);
					int num25 = num23 | num24;
					num *= 866459052U;
					num10 = num25;
					num ^= 41162295U;
				}
			}
			11AE0F91.80068AA5 80068AA = cb943E;
			num = 3415453721U / num;
			80068AA.3F831A1B(num10);
			if (1010118842U > num)
			{
				return cb943E;
			}
			goto IL_13;
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0005FE14 File Offset: 0x0005DA14
		public override UIntPtr 0E10D236()
		{
			return new UIntPtr((uint)this.B61A7D01);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0005FB5C File Offset: 0x0005D75C
		public CB943E91(int E99A4886)
		{
			uint num = 520806299U;
			if (num <= 42265392U)
			{
				goto IL_27;
			}
			IL_11:
			num = 471624344U % num;
			base..ctor();
			num = 2349350656U + num;
			IL_27:
			num = 3794553377U / num;
			num = (3484859297U & num);
			this.B61A7D01 = E99A4886;
			if (num - 36252857U != 0U)
			{
				return;
			}
			goto IL_11;
		}

		// Token: 0x040000A6 RID: 166
		private int B61A7D01;
	}

	// Token: 0x02000030 RID: 48
	private sealed class 591C5123 : 11AE0F91.80068AA5
	{
		// Token: 0x0600016C RID: 364 RVA: 0x00062F9C File Offset: 0x00060B9C
		public override void 7E869424(object 1EA88826)
		{
			uint num = 1161124520U;
			if (1614722595U * num != 0U)
			{
				num = 3407723065U << (int)num;
				ushort a = Convert.ToUInt16(1EA88826);
				num *= 2569289524U;
				this.A3880491 = a;
			}
		}

		// Token: 0x0600016D RID: 365 RVA: 0x0006305C File Offset: 0x00060C5C
		public override ushort CF9960A3()
		{
			return this.A3880491;
		}

		// Token: 0x0600016E RID: 366 RVA: 0x000630A8 File Offset: 0x00060CA8
		public static 11AE0F91.80068AA5 798AFEBA(11AE0F91.80068AA5 979B1C93)
		{
			ulong num;
			uint num2;
			int num6;
			for (;;)
			{
				num = 979B1C93.6D84E72D();
				11AE0F91.80068AA5 80068AA = 979B1C93;
				num2 = 1412926091U;
				uint num3 = (uint)80068AA.3BA55C01();
				num2 = 2794885551U / num2;
				uint num4 = num3 & num2 - 4294967293U;
				num2 = (4204875559U | num2);
				bool flag = num4 > num2 - 4204875559U;
				int num5 = (int)(num2 ^ 4204875559U);
				num2 = (4215189394U ^ num2);
				num6 = num5;
				if (flag)
				{
					break;
				}
				if (num2 + 9199390U != 0U)
				{
					goto Block_1;
				}
			}
			IL_49:
			long num7 = (long)num;
			num2 = 4257159428U % num2;
			long num8 = (long)(num2 ^ 5428551U);
			num2 = 1303866156U >> (int)num2;
			if (num7 > num8)
			{
				int num9 = num6;
				num2 /= 3699990288U;
				num6 = (num9 | (int)(num2 ^ 16U));
				num2 ^= 77U;
				goto IL_CB;
			}
			goto IL_CB;
			Block_1:
			ulong num10 = num;
			long num11 = (long)(num2 ^ 27238218U);
			num2 ^= 27255032U;
			if (num10 > num11)
			{
				if (num2 == 1731374873U)
				{
					goto IL_49;
				}
				num6 |= (int)(num2 - 61U);
				num2 += 0U;
			}
			IL_CB:
			int e99A = (int)((ushort)num);
			num2 = (2878023832U & num2);
			11AE0F91.80068AA5 80068AA2 = new 11AE0F91.CB943E91(e99A);
			num2 += 280027265U;
			979B1C93 = 80068AA2;
			num2 = (3341483529U ^ num2);
			11AE0F91.80068AA5 80068AA3 = 979B1C93;
			num2 = 2408906883U << (int)num2;
			int c7A9131D = num6;
			num2 = 2492963359U - num2;
			80068AA3.3F831A1B(c7A9131D);
			num2 |= 2869554827U;
			return 979B1C93;
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0006308C File Offset: 0x00060C8C
		public override uint 98A2A683()
		{
			return (uint)this.A3880491;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00062F5C File Offset: 0x00060B5C
		public override 11AE0F91.80068AA5 ECAA59A1()
		{
			return new 11AE0F91.591C5123(this.A3880491);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00062F7C File Offset: 0x00060B7C
		public override object D697DB31()
		{
			return this.A3880491;
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00062F3C File Offset: 0x00060B3C
		public override Type 20129380()
		{
			return typeof(ushort);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00063070 File Offset: 0x00060C70
		public override int 30B7A98C()
		{
			return (int)this.A3880491;
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00062FE0 File Offset: 0x00060BE0
		public override 11AE0F91.6012BE05 04A04CBD()
		{
			return new 11AE0F91.CB943E91(this.30B7A98C());
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00063038 File Offset: 0x00060C38
		public override short C6A6922C()
		{
			uint num = 2693900424U;
			short a = (short)this.A3880491;
			num = (899044403U ^ num);
			return a;
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0006301C File Offset: 0x00060C1C
		public override byte B508A9AB()
		{
			return (byte)this.A3880491;
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00063000 File Offset: 0x00060C00
		public override sbyte 482F2014()
		{
			return (sbyte)this.A3880491;
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00062EE0 File Offset: 0x00060AE0
		public 591C5123(ushort 9C219EB7)
		{
			uint num = 1754269741U;
			if ((num ^ 3867525678U) == 0U)
			{
				goto IL_32;
			}
			IL_12:
			num = 4280481039U >> (int)num;
			base..ctor();
			if (3803580928U + num == 0U)
			{
				return;
			}
			IL_32:
			num = (4248299158U & num);
			this.A3880491 = 9C219EB7;
			if (num / 730889243U != 0U)
			{
				goto IL_12;
			}
		}

		// Token: 0x040000A7 RID: 167
		private ushort A3880491;
	}

	// Token: 0x0200003A RID: 58
	private sealed class 833BF530 : 11AE0F91.1280CA96
	{
		// Token: 0x06000196 RID: 406 RVA: 0x000678B8 File Offset: 0x000654B8
		public int 1B80EDB7()
		{
			uint num = 4164442508U;
			num <<= 25;
			Stack<int> ce9C9B = this.CE9C9B05;
			num = 2210300693U + num;
			return ce9C9B.Count;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x000678E8 File Offset: 0x000654E8
		public unsafe byte 853F4BB0()
		{
			uint num = 1722662842U;
			byte b2;
			for (;;)
			{
				num = (3618651963U & num);
				uint d422FB9F = this.D422FB9F;
				num = 3426184212U / num;
				IntPtr value = 0F35EF88.88B78B84(d422FB9F);
				num = 2904432010U - num;
				ref byte ptr = ref *(byte*)((void*)value);
				num = 3641701424U << (int)num;
				byte b = ptr;
				num = 1862597149U >> (int)num;
				b2 = b;
				num *= 2468209812U;
				num /= 3845074997U;
				uint d422FB9F2 = this.D422FB9F;
				num -= 487645994U;
				uint num2 = num ^ 3807321303U;
				num <<= 24;
				this.D422FB9F = d422FB9F2 + num2;
				num = 1061082661U % num;
				byte b3 = b2;
				num = (1756037419U & num);
				byte b4 = (byte)((uint)b3 ^ this.3D1F3399);
				num >>= 13;
				b2 = b4;
				num = 2779364031U >> (int)num;
				byte b5 = b2;
				num = (730418831U ^ num);
				int num3 = (int)(num - 730458917U);
				num += 598104717U;
				byte b6 = b5 << num3;
				num ^= 3745459728U;
				byte b7 = b2;
				num |= 1367532167U;
				byte b8 = b7 >> (int)(num ^ 3515870112U);
				num = 3416348200U % num;
				byte b9 = (byte)(-(byte)(~(byte)((uint)(b6 | b8) - (num ^ 3416348201U))));
				num ^= 472979974U;
				b2 = b9;
				num = 3549968303U * num;
				if (num != 2537298973U)
				{
					num %= 3902121899U;
					num >>= 16;
					uint num4 = this.3D1F3399;
					num = 556320013U / num;
					uint num5 = (uint)b2;
					num = (2292597660U | num);
					uint num6 = num4 ^ num5;
					num = 2729085997U << (int)num;
					this.3D1F3399 = num6;
					num = 3107516803U / num;
					if (num >> 28 == 0U)
					{
						break;
					}
				}
			}
			return b2;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00067EA0 File Offset: 0x00065AA0
		public float EC8194B9()
		{
			uint num = 721647537U;
			byte[] bytes = BitConverter.GetBytes(this.99BB76A6());
			int startIndex = (int)(num ^ 721647537U);
			num -= 3340192937U;
			return BitConverter.ToSingle(bytes, startIndex);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00067A58 File Offset: 0x00065658
		public unsafe byte 23A12822()
		{
			uint num = 1602807325U;
			byte b2;
			for (;;)
			{
				uint d422FB9F = this.D422FB9F;
				num = (1418437644U ^ num);
				IntPtr value = 0F35EF88.88B78B84(d422FB9F);
				num = 3987262778U % num;
				ref byte ptr = ref *(byte*)((void*)value);
				num |= 1662633245U;
				byte b = ptr;
				num >>= 24;
				b2 = b;
				num = 4145574306U / num;
				if (3987234311U >= num)
				{
					num = (959089940U ^ num);
					uint d422FB9F2 = this.D422FB9F;
					uint num2 = num ^ 994881267U;
					num %= 2994796722U;
					this.D422FB9F = d422FB9F2 + num2;
					byte b3 = b2;
					num += 1334392337U;
					byte b4 = (byte)((uint)b3 ^ this.3D1F3399);
					num ^= 1044010381U;
					b2 = b4;
					num &= 3274342168U;
					if (num != 1002243487U)
					{
						byte b5 = (byte)((uint)b2 - (num ^ 2150248457U));
						byte b6 = (byte)(num - 2150248280U);
						num >>= 2;
						b2 = (b5 ^ b6);
						byte b7 = b2;
						num ^= 1199687079U;
						byte b8 = b7 << (int)(num + 2557785692U);
						num = (1731907995U | num);
						byte b9 = (byte)((uint)b2 >> (int)(num ^ 1740364216U));
						num = (3440393139U | num);
						byte b10 = b8 | b9;
						num = 680790283U + num;
						byte b11 = (byte)((uint)b10 - (num - 407897289U));
						num ^= 2083018767U;
						b2 = b11;
						if ((1914356026U ^ num) != 0U)
						{
							break;
						}
					}
				}
			}
			num = 4030099722U % num;
			uint num3 = this.3D1F3399;
			num = 2621014463U % num;
			uint num4 = (uint)b2;
			num >>= 2;
			this.3D1F3399 = (num3 ^ num4);
			return b2;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00067814 File Offset: 0x00065414
		public void 73A4C02F()
		{
			uint num = 3154275850U;
			num += 623609615U;
			num &= 4170170259U;
			Stack<int> ce9C9B = this.CE9C9B05;
			num = 3800615301U - num;
			this.37242F0A(ce9C9B.Pop());
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00067ED4 File Offset: 0x00065AD4
		public double FA8E1432()
		{
			uint num = 423557434U;
			byte[] bytes = BitConverter.GetBytes(this.8B9CB93A());
			num = 1066733622U << (int)num;
			int startIndex = (int)(num - 3623878656U);
			num = (939637813U & num);
			return BitConverter.ToDouble(bytes, startIndex);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00067B94 File Offset: 0x00065794
		public unsafe short 50AB0933()
		{
			uint num2;
			ushort num3;
			for (;;)
			{
				ushort num = *(ushort*)((void*)0F35EF88.88B78B84(this.D422FB9F));
				num2 = 1337534482U;
				num3 = num;
				if (1654308994U >= num2)
				{
					goto IL_23;
				}
				for (;;)
				{
					IL_5A:
					ushort num4 = num3;
					num2 ^= 1821313169U;
					ushort num5 = (ushort)((uint)num4 ^ this.3D1F3399);
					num2 &= 4196269193U;
					num3 = num5;
					if (num2 >> 16 != 0U)
					{
						ushort num6 = (ushort)((uint)num3 + (num2 ^ 2988241848U));
						num2 *= 1712624699U;
						num3 = num6;
						num2 = (2822197419U ^ num2);
						if (num2 == 554412857U)
						{
							break;
						}
					}
					ushort num7 = num3;
					num2 = 487434040U - num2;
					int num8 = (int)(num2 ^ 3504119308U);
					num2 -= 2761047469U;
					ushort num9 = num7 << num8;
					ushort num10 = num3;
					num2 %= 906356004U;
					ushort num11 = num10 >> (int)(num2 ^ 743071855U);
					num2 /= 3809631489U;
					ushort num12 = ~(num9 | num11);
					num2 = (2243320510U ^ num2);
					ushort num13 = (ushort)((uint)num12 - (num2 - 2243266237U));
					num2 = 2636358975U * num2;
					ushort num14 = (ushort)(num2 ^ 1582731765U);
					num2 = 956529960U % num2;
					ushort num15 = num13 ^ num14;
					num2 = (2688136464U ^ num2);
					ushort num16 = ~num15;
					num2 &= 2819758721U;
					num3 = num16;
					if (num2 >> 10 != 0U)
					{
						goto Block_1;
					}
				}
				IL_23:
				num2 -= 2167808432U;
				num2 = (2368895508U ^ num2);
				uint d422FB9F = this.D422FB9F + (num2 ^ 1135705204U);
				num2 |= 3693197329U;
				this.D422FB9F = d422FB9F;
				if (num2 != 1143786416U)
				{
					goto IL_5A;
				}
			}
			Block_1:
			num2 %= 3736960161U;
			uint num17 = this.3D1F3399;
			uint num18 = (uint)num3;
			num2 %= 3241154699U;
			this.3D1F3399 = (num17 ^ num18);
			num2 = 3859954693U - num2;
			short num19 = (short)num3;
			num2 = 2729833138U / num2;
			return num19;
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00067F14 File Offset: 0x00065B14
		public 833BF530()
		{
			uint num = 104370618U;
			for (;;)
			{
				this.CE9C9B05 = new Stack<int>();
				num %= 3784783138U;
				if (num <= 3959552273U)
				{
					num <<= 26;
					base..ctor();
					if ((num & 3850888866U) != 0U)
					{
						break;
					}
				}
			}
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00067798 File Offset: 0x00065398
		public override void 37242F0A(int 8BB05D89)
		{
			uint num = 431007004U;
			num /= 1302550160U;
			this.D422FB9F = (uint)8BB05D89;
			do
			{
				this.3D1F3399 = this.D422FB9F;
			}
			while (num == 160359999U);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x000677D4 File Offset: 0x000653D4
		public void F43AFA0C(int 1C850D8A)
		{
			uint num = 3585993988U;
			if (num != 738510479U)
			{
				do
				{
					Stack<int> ce9C9B = this.CE9C9B05;
					num /= 161156772U;
					ce9C9B.Push(1C850D8A);
				}
				while (3532230817U <= num);
			}
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00067E40 File Offset: 0x00065A40
		public unsafe long 8B9CB93A()
		{
			uint d422FB9F = this.D422FB9F;
			uint num = 2509742365U;
			long result = *(long*)((void*)0F35EF88.88B78B84(d422FB9F));
			num -= 3608405552U;
			num = 1663054632U / num;
			uint d422FB9F2 = this.D422FB9F;
			num /= 3036983816U;
			uint d422FB9F3 = d422FB9F2 + (num ^ 8U);
			num = 4029509131U << (int)num;
			this.D422FB9F = d422FB9F3;
			return result;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00067850 File Offset: 0x00065450
		public void B03F07A7()
		{
			uint num = 3677010475U;
			if (154989453U + num == 0U)
			{
				goto IL_1D;
			}
			IL_12:
			this.CE9C9B05.Clear();
			IL_1D:
			num = (866001300U | num);
			this.3D1F3399 = (num ^ 4223581119U);
			num = (1259594035U | num);
			num = 528988685U * num;
			this.D422FB9F = (num ^ 677482163U);
			if (num < 1293494919U)
			{
				return;
			}
			goto IL_12;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00067CF0 File Offset: 0x000658F0
		public unsafe int 99BB76A6()
		{
			uint num = 211317815U;
			uint num3;
			if (num <= 4055163823U)
			{
				uint d422FB9F = this.D422FB9F;
				num <<= 31;
				uint num2 = *(uint*)((void*)0F35EF88.88B78B84(d422FB9F));
				num = 3893644678U % num;
				num3 = num2;
				num = 355726469U * num;
			}
			for (;;)
			{
				num += 4198212533U;
				uint d422FB9F2 = this.D422FB9F;
				num *= 1630106393U;
				uint num4 = num ^ 1901798175U;
				num ^= 2871779997U;
				uint d422FB9F3 = d422FB9F2 + num4;
				num = 588477845U >> (int)num;
				this.D422FB9F = d422FB9F3;
				num >>= 11;
				num3 ^= this.3D1F3399;
				uint num5 = num3;
				num -= 4003150988U;
				uint num6 = num5 >> (int)(num ^ 291820798U);
				uint num7 = num3;
				num &= 3106469166U;
				int num8 = (int)(num ^ 287364145U);
				num |= 2686907697U;
				uint num9 = num7 << num8;
				num = (186076986U & num);
				uint num10 = num6 | num9;
				uint num11 = num ^ 17188153U;
				num /= 128244513U;
				uint num12 = num10 + num11;
				uint num13 = num + 1955460413U;
				num = (2803723439U | num);
				num3 = (num12 ^ num13);
				num = (3716385577U | num);
				if ((1964503939U ^ num) != 0U)
				{
					uint num14 = num3;
					num = 2587605395U >> (int)num;
					uint num15 = num14 >> (int)(num ^ 78965U);
					num = 847390096U / num;
					num3 = (num15 | num3 << (int)(num ^ 10740U));
					uint num16 = this.3D1F3399;
					num *= 1703649944U;
					this.3D1F3399 = (num16 ^ num3);
					num = 2225614980U % num;
					if (num < 691848245U)
					{
						break;
					}
				}
			}
			return (int)num3;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00067784 File Offset: 0x00065384
		public override int B395DB29()
		{
			return (int)this.D422FB9F;
		}

		// Token: 0x040000D2 RID: 210
		private uint D422FB9F;

		// Token: 0x040000D3 RID: 211
		private Stack<int> CE9C9B05;

		// Token: 0x040000D4 RID: 212
		private uint 3D1F3399;
	}

	// Token: 0x0200003D RID: 61
	private abstract class 80068AA5
	{
		// Token: 0x060001A8 RID: 424 RVA: 0x0005EE28 File Offset: 0x0005CA28
		public virtual uint 98A2A683()
		{
			return Convert.ToUInt32(this.D697DB31());
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0005ECC8 File Offset: 0x0005C8C8
		public virtual bool FC990F28()
		{
			return false;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0005F024 File Offset: 0x0005CC24
		public static 11AE0F91.80068AA5 90BC983A(11AE0F91.80068AA5 6D8E093B, Type 74105C00)
		{
			uint num = 110424449U;
			if (1874545342U > num)
			{
				goto IL_11;
			}
			int num3;
			object obj;
			for (;;)
			{
				IL_28:
				num = 3607707928U >> (int)num;
				int num2 = (int)(num ^ 1720U);
				num = 288759346U >> (int)num;
				num3 = num2;
				Type type;
				for (;;)
				{
					bool flag = obj != null;
					num = 3761633708U + num;
					if (!flag)
					{
						goto Block_1;
					}
					if (1269555367U * num == 0U)
					{
						goto IL_11;
					}
					object obj2 = obj;
					num = (1787968513U | num);
					type = obj2.GetType();
					Type left = type;
					num = 3181730973U << (int)num;
					bool flag2 = left == 74105C00;
					num = 3835609021U / num;
					if (flag2)
					{
						goto IL_F7;
					}
					if ((num ^ 455498769U) != 0U)
					{
						goto Block_4;
					}
				}
				IL_115:
				num -= 2930217754U;
				if (num % 2031738151U != 0U)
				{
					break;
				}
				continue;
				IL_65:
				int num4 = num3;
				int num5 = (int)(num - 3761633724U);
				num ^= 196713737U;
				num3 = (num4 | num5);
				goto IL_115;
				Block_1:
				if (2881092754U != num)
				{
					goto IL_65;
				}
				goto IL_11;
				Block_4:
				num = 504901044U >> (int)num;
				Type c = type;
				num = 1787662644U + num;
				bool flag3 = 74105C00.IsAssignableFrom(c);
				num += 1911733414U;
				if (!flag3)
				{
					goto IL_115;
				}
				num ^= 3951846581U;
				IL_F7:
				if ((1639888164U ^ num) != 0U)
				{
					num3 |= (int)(num + 0U);
					num ^= 3951846581U;
					goto IL_115;
				}
				goto IL_65;
			}
			int e99A = num3;
			num = 925478528U + num;
			return new 11AE0F91.CB943E91(e99A);
			IL_11:
			num |= 2517020693U;
			object obj3 = 6D8E093B.D697DB31();
			num &= 2073040917U;
			obj = obj3;
			goto IL_28;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0005F2E0 File Offset: 0x0005CEE0
		public unsafe static 11AE0F91.80068AA5 872D5EA9(object 9730DA15, Type 4A3DAA3A)
		{
			uint num;
			for (;;)
			{
				num = 1821677844U;
				if (4A3DAA3A.IsEnum)
				{
					num &= 2551721101U;
					goto IL_19;
				}
				IL_92:
				TypeCode typeCode = Type.GetTypeCode(4A3DAA3A);
				if (num % 2779979652U != 0U)
				{
					for (;;)
					{
						switch (typeCode - (TypeCode)(num - 1821677841U))
						{
						case 0:
							if (674541064U / num == 0U)
							{
								goto Block_5;
							}
							continue;
						case 1:
							goto IL_108;
						case 2:
							goto IL_122;
						case 3:
							goto IL_136;
						case 4:
							goto IL_14A;
						case 5:
							goto IL_15E;
						case 6:
							goto IL_182;
						case 7:
							goto IL_1B0;
						case 8:
							goto IL_1D0;
						case 9:
							goto IL_1EC;
						case 10:
							goto IL_210;
						case 11:
							goto IL_238;
						}
						goto Block_4;
					}
					IL_182:
					num /= 3139245497U;
					if (1636614199U + num != 0U)
					{
						goto Block_6;
					}
					continue;
					IL_210:
					num = 1107969061U - num;
					if (num << 22 != 0U)
					{
						goto Block_8;
					}
					continue;
					Block_4:
					Type typeFromHandle = typeof(IntPtr);
					num %= 2184241435U;
					if (4A3DAA3A == typeFromHandle)
					{
						goto Block_9;
					}
					RuntimeTypeHandle handle = typeof(UIntPtr).TypeHandle;
					num = (2853618179U ^ num);
					Type typeFromHandle2 = Type.GetTypeFromHandle(handle);
					num = 2686543669U * num;
					if (4A3DAA3A == typeFromHandle2)
					{
						num >>= 22;
						if (num > 1612614676U)
						{
							goto IL_19;
						}
						bool flag = 9730DA15 != null;
						num = (1527342136U & num);
						if (!flag)
						{
							goto Block_13;
						}
						if (num + 1544236340U != 0U)
						{
							goto Block_14;
						}
						continue;
					}
					else
					{
						num *= 2006272556U;
						num /= 3953427767U;
						bool isValueType = 4A3DAA3A.IsValueType;
						num = 59334455U * num;
						if (isValueType)
						{
							if (num * 2794699708U == 0U)
							{
								goto Block_16;
							}
							goto IL_19;
						}
						else
						{
							num = 1351823497U << (int)num;
							bool isPointer = 4A3DAA3A.IsPointer;
							num = 2460574359U / num;
							if (!isPointer)
							{
								goto IL_3E3;
							}
							num |= 268492574U;
							if (1294912561U > num)
							{
								goto Block_18;
							}
							continue;
						}
					}
					IL_1B0:
					if (num + 4010145190U != 0U)
					{
						goto Block_7;
					}
				}
				IL_19:
				bool flag2 = 9730DA15 != null;
				num = (1780156211U ^ num);
				if (!flag2)
				{
					goto IL_76;
				}
				num = (438912437U | num);
				if (2944842037U > num)
				{
					break;
				}
				goto IL_92;
			}
			object obj = 9730DA15;
			num = 1763885363U - num;
			bool flag3 = obj is Enum;
			num <<= 25;
			num ^= 2584416055U;
			if (!flag3)
			{
				object obj2 = Enum.ToObject(4A3DAA3A, 9730DA15);
				num = (2486069027U ^ num);
				9730DA15 = obj2;
				num ^= 2486069027U;
			}
			IL_76:
			num = (3258364824U | num);
			object obj3 = 9730DA15;
			num = 346259090U / num;
			return new 11AE0F91.29057C93((Enum)obj3);
			Block_5:
			bool ab3A521B = Convert.ToBoolean(9730DA15);
			num *= 890770841U;
			return new 11AE0F91.F5AFA222(ab3A521B);
			IL_108:
			object value = 9730DA15;
			num = 1821461162U >> (int)num;
			return new 11AE0F91.429DA536(Convert.ToChar(value));
			IL_122:
			num = 3508824718U - num;
			return new 11AE0F91.281DB71D(Convert.ToSByte(9730DA15));
			IL_136:
			num = (1804033693U | num);
			return new 11AE0F91.E2A0AC8B(Convert.ToByte(9730DA15));
			IL_14A:
			short 03302CA = Convert.ToInt16(9730DA15);
			num ^= 42326414U;
			return new 11AE0F91.373CCBBA(03302CA);
			IL_15E:
			num = (3023431863U & num);
			object value2 = 9730DA15;
			num = 1242180776U / num;
			ushort 9C219EB = Convert.ToUInt16(value2);
			num = 799313694U % num;
			return new 11AE0F91.591C5123(9C219EB);
			Block_6:
			object value3 = 9730DA15;
			num = 867812270U >> (int)num;
			return new 11AE0F91.CB943E91(Convert.ToInt32(value3));
			Block_7:
			uint 423D881D = Convert.ToUInt32(9730DA15);
			num ^= 540406530U;
			return new 11AE0F91.840DFA36(423D881D);
			IL_1D0:
			num *= 2646492846U;
			long d1A1852C = Convert.ToInt64(9730DA15);
			num = 2654113434U / num;
			return new 11AE0F91.6A9A2996(d1A1852C);
			IL_1EC:
			num %= 481116854U;
			object value4 = 9730DA15;
			num *= 3038814100U;
			ulong 9939B02E = Convert.ToUInt64(value4);
			num &= 2299805450U;
			return new 11AE0F91.4422B13D(9939B02E);
			Block_8:
			float 76BAFC = Convert.ToSingle(9730DA15);
			num += 1966962078U;
			return new 11AE0F91.7621E502(76BAFC);
			IL_238:
			num >>= 25;
			object value5 = 9730DA15;
			num /= 1840732700U;
			double e71A18BC = Convert.ToDouble(value5);
			num *= 2897776137U;
			return new 11AE0F91.122C9D2C(e71A18BC);
			Block_9:
			bool flag4 = 9730DA15 != null;
			num |= 4263579583U;
			IntPtr b68DCD;
			if (!flag4)
			{
				num = (683331633U ^ num);
				b68DCD = IntPtr.Zero;
			}
			else
			{
				b68DCD = (IntPtr)9730DA15;
				num ^= 683331633U;
			}
			return new 11AE0F91.8A270C3B(b68DCD);
			Block_13:
			num ^= 3734967351U;
			UIntPtr 1CB6089E = UIntPtr.Zero;
			goto IL_31F;
			Block_14:
			1CB6089E = (UIntPtr)9730DA15;
			num += 3734967287U;
			IL_31F:
			return new 11AE0F91.39A8C69A(1CB6089E);
			Block_16:
			return new 11AE0F91.1718F939(9730DA15);
			Block_18:
			bool flag5 = 9730DA15 != null;
			num ^= 3768560690U;
			void* ptr;
			if (!flag5)
			{
				ptr = (num ^ 4036981549U);
			}
			else
			{
				object ptr2 = 9730DA15;
				num &= 3549879296U;
				ptr = Pointer.Unbox(ptr2);
				num += 537469741U;
			}
			object 4287A = Pointer.Box(ptr, 4A3DAA3A);
			num %= 3475194685U;
			num = 3298896943U >> (int)num;
			return new 11AE0F91.470344A8(4287A, 4A3DAA3A);
			IL_3E3:
			return new 11AE0F91.1C16CD2C(9730DA15);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0005FB04 File Offset: 0x0005D704
		protected 80068AA5()
		{
			uint num = 3254945595U;
			if (num <= 4156249882U)
			{
				do
				{
					base..ctor();
				}
				while (num < 3223460355U);
			}
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0005F168 File Offset: 0x0005CD68
		public static 11AE0F91.80068AA5 49072FA8(11AE0F91.80068AA5 F79EB897)
		{
			int num;
			for (;;)
			{
				num = 0;
				uint num2 = 61701551U;
				for (;;)
				{
					num2 ^= 2571028652U;
					uint num3 = (uint)F79EB897.3BA55C01();
					uint num4 = num2 ^ 2593371399U;
					num2 = 2971534234U >> (int)num2;
					bool flag = (num3 & num4) > (num2 ^ 371441779U);
					num2 >>= 23;
					if (flag)
					{
						break;
					}
					num2 <<= 29;
					if (num2 + 3946644543U != 0U)
					{
						goto Block_7;
					}
				}
				num2 = (2578729908U | num2);
				if ((3936003104U ^ num2) == 0U)
				{
					continue;
				}
				num2 ^= 1964081977U;
				float f = F79EB897.599106A4();
				if (462848188U - num2 == 0U)
				{
					continue;
				}
				bool flag2 = float.IsNaN(f);
				num2 -= 1647817657U;
				if (!flag2)
				{
					num2 /= 2494283299U;
					if (201659654U >= num2)
					{
						if (!float.IsInfinity(f))
						{
							goto IL_14F;
						}
						num2 ^= 2322470092U;
					}
				}
				num |= (int)(num2 ^ 2322470108U);
				if (4071055666U <= num2)
				{
					continue;
				}
				num2 ^= 2322470092U;
				IL_14F:
				num2 ^= 1753729938U;
				if (2778274855U / num2 != 0U)
				{
					break;
				}
				continue;
				Block_7:
				num2 = (2961316241U ^ num2);
				double num5 = F79EB897.DD227D0D();
				num2 %= 4003330729U;
				double num6 = num5;
				if (!double.IsNaN(num6))
				{
					double d = num6;
					num2 -= 2686722991U;
					bool flag3 = double.IsInfinity(d);
					num2 = 2476681518U * num2;
					num2 ^= 2057396380U;
					if (!flag3)
					{
						goto IL_14F;
					}
					num2 += 813832593U;
				}
				num2 = 2159225761U * num2;
				int num7 = num;
				num2 = (732486313U | num2);
				num = (num7 | (int)(num2 - 3215523753U));
				num2 ^= 3215523769U;
				goto IL_14F;
			}
			return new 11AE0F91.CB943E91(num);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0005EFF4 File Offset: 0x0005CBF4
		public virtual int 3BA55C01()
		{
			return this.02A8CFB0;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0005ED6C File Offset: 0x0005C96C
		public virtual int 30B7A98C()
		{
			return Convert.ToInt32(this.D697DB31());
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0005EEA0 File Offset: 0x0005CAA0
		public virtual IntPtr D20542BB()
		{
			uint num = 411262128U;
			object obj;
			for (;;)
			{
				obj = this.D697DB31();
				for (;;)
				{
					if (obj != null)
					{
						goto IL_25;
					}
					if ((2527917751U & num) == 0U)
					{
						break;
					}
					Type left = null;
					IL_3B:
					RuntimeTypeHandle handle = typeof(IntPtr).TypeHandle;
					num = 2334593161U + num;
					bool flag = left == Type.GetTypeFromHandle(handle);
					num <<= 16;
					if (flag)
					{
						if ((num & 76016419U) != 0U)
						{
							goto Block_4;
						}
						continue;
					}
					else
					{
						num &= 3577474312U;
						if (num + 1418650655U != 0U)
						{
							goto Block_5;
						}
					}
					IL_25:
					object obj2 = obj;
					num = 1327195932U / num;
					left = obj2.GetType();
					num ^= 411262131U;
					goto IL_3B;
				}
			}
			Block_4:
			return (IntPtr)obj;
			Block_5:
			throw new InvalidOperationException();
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0005EBF8 File Offset: 0x0005C7F8
		public virtual object 0681AA27(FieldInfo D7383194)
		{
			uint num;
			object obj2;
			for (;;)
			{
				object obj = this.D697DB31();
				num = 10550166U;
				obj2 = obj;
				num = 3191717536U % num;
				if (1519895939U % num != 0U)
				{
					if (obj2 == null || num << 21 == 0U)
					{
						goto IL_B1;
					}
					bool isValueType = D7383194.DeclaringType.IsValueType;
					num <<= 24;
					num += 1414853548U;
					if (!isValueType)
					{
						goto IL_B1;
					}
					bool isPrimitive = obj2.GetType().IsPrimitive;
					num ^= 0U;
					if (!isPrimitive)
					{
						goto IL_B1;
					}
					num = 1856580139U * num;
					if (num / 3366575515U == 0U)
					{
						break;
					}
				}
			}
			num = 4278684479U * num;
			IntPtr ptr = this.D20542BB();
			num *= 3258906803U;
			Type declaringType = D7383194.DeclaringType;
			num <<= 0;
			obj2 = Marshal.PtrToStructure(ptr, declaringType);
			num += 1945965336U;
			IL_B1:
			num = (2938074131U ^ num);
			return D7383194.GetValue(obj2);
		}

		// Token: 0x060001B2 RID: 434
		public abstract object D697DB31();

		// Token: 0x060001B3 RID: 435 RVA: 0x0005EF38 File Offset: 0x0005CB38
		public virtual UIntPtr 0E10D236()
		{
			uint num = 1639676691U;
			if (num == 545338118U)
			{
				goto IL_33;
			}
			IL_11:
			num >>= 1;
			object obj = this.D697DB31();
			num -= 2342834075U;
			if (num < 2762004795U)
			{
				goto IL_45;
			}
			IL_33:
			Type left;
			if (obj != null)
			{
				object obj2 = obj;
				num = 1083843217U >> (int)num;
				left = obj2.GetType();
				num ^= 2772037510U;
				goto IL_67;
			}
			if (num + 3424793644U == 0U)
			{
				goto IL_11;
			}
			IL_45:
			left = null;
			IL_67:
			RuntimeTypeHandle handle = typeof(UIntPtr).TypeHandle;
			num -= 4005383962U;
			if (left == Type.GetTypeFromHandle(handle))
			{
				if (2536026918U / num == 0U)
				{
					object obj3 = obj;
					num /= 3465545638U;
					return (UIntPtr)obj3;
				}
				goto IL_11;
			}
			else
			{
				if (2938708905U < num)
				{
					throw new InvalidOperationException();
				}
				goto IL_11;
			}
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0005EE40 File Offset: 0x0005CA40
		public virtual ulong 6D84E72D()
		{
			return Convert.ToUInt64(this.D697DB31());
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0005EE78 File Offset: 0x0005CA78
		public virtual double DD227D0D()
		{
			uint num = 730219678U;
			object value = this.D697DB31();
			num %= 3342690572U;
			return Convert.ToDouble(value);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0005EDE0 File Offset: 0x0005C9E0
		public virtual byte B508A9AB()
		{
			uint num = 3140630957U;
			object value = this.D697DB31();
			num -= 4237588783U;
			return Convert.ToByte(value);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0005ED8C File Offset: 0x0005C98C
		public virtual long D20998B6()
		{
			uint num = 37341497U;
			num = 3778380318U << (int)num;
			object value = this.D697DB31();
			num = 330650006U - num;
			return Convert.ToInt64(value);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0005ED4C File Offset: 0x0005C94C
		public virtual short C6A6922C()
		{
			return Convert.ToInt16(this.D697DB31());
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0005ED04 File Offset: 0x0005C904
		public virtual bool 2206A10D()
		{
			return Convert.ToBoolean(this.D697DB31());
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0005EE60 File Offset: 0x0005CA60
		public virtual float 599106A4()
		{
			return Convert.ToSingle(this.D697DB31());
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0005EDC0 File Offset: 0x0005C9C0
		public virtual char 8EBDB806()
		{
			return Convert.ToChar(this.D697DB31());
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0005ECD8 File Offset: 0x0005C8D8
		public virtual 11AE0F91.6012BE05 04A04CBD()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0005EAA8 File Offset: 0x0005C6A8
		public virtual void B534E11F(FieldInfo D9034495, object 83239DAC)
		{
			uint num = 3447992727U;
			for (;;)
			{
				num ^= 656091541U;
				object obj = this.D697DB31();
				num = 673469325U + num;
				object obj2 = obj;
				num >>= 9;
				for (;;)
				{
					bool flag = obj2 != null;
					num |= 3669793082U;
					if (flag)
					{
						goto IL_33;
					}
					IL_B9:
					if (3642314926U % num == 0U)
					{
						break;
					}
					num = (2838824883U | num);
					object obj3 = obj2;
					num >>= 8;
					D9034495.SetValue(obj3, 83239DAC);
					num = 1335671083U + num;
					if (-1449873503 << (int)num != 0)
					{
						object obj4 = obj2;
						num /= 252514212U;
						bool flag2 = obj4 is ValueType;
						num = 1888465313U / num;
						if (flag2)
						{
							if (3103999671U <= num)
							{
								break;
							}
							num = 4153088931U - num;
							this.7E869424(obj2);
							num += 897264489U;
						}
						if (2315531533U - num != 0U)
						{
							return;
						}
						continue;
					}
					IL_33:
					num ^= 2065238591U;
					Type declaringType = D9034495.DeclaringType;
					num = 528975139U % num;
					bool isValueType = declaringType.IsValueType;
					num ^= 3308944540U;
					if (!isValueType)
					{
						goto IL_B9;
					}
					object obj5 = obj2;
					num = 1142730523U % num;
					bool isPrimitive = obj5.GetType().IsPrimitive;
					num ^= 2661373604U;
					if (!isPrimitive)
					{
						goto IL_B9;
					}
					if (num >> 7 != 0U)
					{
						num = 1461163156U * num;
						IntPtr ptr = this.D20542BB();
						Type declaringType2 = D9034495.DeclaringType;
						num = 220299821U + num;
						object obj6 = Marshal.PtrToStructure(ptr, declaringType2);
						num = 2476236083U * num;
						obj2 = obj6;
						num += 14374468U;
						goto IL_B9;
					}
					break;
				}
			}
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0005ECF0 File Offset: 0x0005C8F0
		public virtual Type 20129380()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0005F6D8 File Offset: 0x0005D2D8
		public unsafe 11AE0F91.80068AA5 01245B13(Type 31130EB4)
		{
			uint num;
			IntPtr intPtr;
			object obj2;
			for (;;)
			{
				bool isEnum = 31130EB4.IsEnum;
				num = 867872945U;
				if (isEnum)
				{
					num = (3710195074U & num);
					goto IL_19;
				}
				num = 4046763837U / num;
				if (4131383961U % num == 0U)
				{
					continue;
				}
				TypeCode typeCode = Type.GetTypeCode(31130EB4);
				num <<= 19;
				if ((num ^ 3683772580U) == 0U)
				{
					continue;
				}
				uint num2 = (uint)typeCode;
				num *= 3330675979U;
				uint num3 = num2 - (num - 2707423229U);
				num = 294425533U * num;
				switch (num3)
				{
				case 0:
					if (num << 28 == 0U)
					{
						goto Block_8;
					}
					continue;
				case 1:
					goto IL_161;
				case 2:
					goto IL_185;
				case 3:
					goto IL_191;
				case 4:
					if (1268253727U != num)
					{
						goto Block_9;
					}
					goto IL_19;
				case 5:
					num = 2569732909U - num;
					if (170897796U != num)
					{
						goto Block_10;
					}
					break;
				case 6:
					if (num * 2122393126U != 0U)
					{
						goto Block_11;
					}
					continue;
				case 7:
					num = 4130704423U << (int)num;
					if ((2048222251U & num) != 0U)
					{
						goto Block_12;
					}
					break;
				case 8:
					if ((num ^ 3945662381U) != 0U)
					{
						goto Block_13;
					}
					goto IL_19;
				case 9:
					num |= 3122877313U;
					if (num - 614294318U != 0U)
					{
						goto Block_14;
					}
					goto IL_19;
				case 10:
					num = 3601233052U >> (int)num;
					if ((num ^ 1921305648U) != 0U)
					{
						goto Block_15;
					}
					goto IL_19;
				case 11:
					goto IL_2A5;
				default:
				{
					num = (950409089U ^ num);
					Type typeFromHandle = typeof(IntPtr);
					num = 3440515843U >> (int)num;
					bool flag = 31130EB4 == typeFromHandle;
					num = 2275257358U >> (int)num;
					if (flag)
					{
						if (num % 127409679U != 0U)
						{
							goto Block_17;
						}
					}
					else
					{
						num = (750631839U & num);
						num = 2358282150U % num;
						Type typeFromHandle2 = typeof(UIntPtr);
						num >>= 22;
						if (31130EB4 == typeFromHandle2)
						{
							goto Block_18;
						}
						num <<= 28;
						bool isValueType = 31130EB4.IsValueType;
						num <<= 17;
						if (isValueType)
						{
							if (num != 2165871148U)
							{
								goto Block_20;
							}
							continue;
						}
						else
						{
							num >>= 29;
							if (num << 11 != 0U)
							{
								goto IL_19;
							}
							num |= 3859531583U;
							if (!31130EB4.IsPointer)
							{
								goto IL_403;
							}
							num -= 2008158360U;
							num += 2753722032U;
							intPtr = this.D20542BB();
							if (num % 4247355038U != 0U)
							{
								goto Block_23;
							}
							goto IL_19;
						}
					}
					break;
				}
				}
				IL_4C:
				object obj = obj2;
				num >>= 25;
				bool flag2 = obj is Enum;
				num += 2143270904U;
				if (flag2)
				{
					goto IL_8A;
				}
				if (3859713162U >= num)
				{
					object obj3 = Enum.ToObject(31130EB4, obj2);
					num = 866029583U % num;
					obj2 = obj3;
					num += 1277241384U;
					goto IL_8A;
				}
				continue;
				IL_3B:
				if (obj2 == null)
				{
					goto IL_8A;
				}
				if (num >= 1496656007U)
				{
					goto IL_4C;
				}
				IL_19:
				object obj4 = this.D697DB31();
				num = (1839110323U ^ num);
				obj2 = obj4;
				num = (1672327191U | num);
				if (num != 958036741U)
				{
					goto IL_3B;
				}
				IL_8A:
				num *= 2744499132U;
				if (num <= 1930338867U)
				{
					break;
				}
				goto IL_3B;
			}
			Enum f7A98F = (Enum)obj2;
			num = 1804823057U << (int)num;
			return new 11AE0F91.29057C93(f7A98F);
			Block_8:
			num = 1008629644U % num;
			bool ab3A521B = this.2206A10D();
			num = (364609203U | num);
			return new 11AE0F91.F5AFA222(ab3A521B);
			IL_161:
			num = (336636056U ^ num);
			num /= 1753235104U;
			char 7136ED1F = this.8EBDB806();
			num = 1832403752U * num;
			return new 11AE0F91.429DA536(7136ED1F);
			IL_185:
			return new 11AE0F91.281DB71D(this.482F2014());
			IL_191:
			num >>= 27;
			num = 85584905U >> (int)num;
			return new 11AE0F91.E2A0AC8B(this.B508A9AB());
			Block_9:
			return new 11AE0F91.373CCBBA(this.C6A6922C());
			Block_10:
			ushort 9C219EB = this.CF9960A3();
			num = (1790381729U | num);
			return new 11AE0F91.591C5123(9C219EB);
			Block_11:
			return new 11AE0F91.CB943E91(this.30B7A98C());
			Block_12:
			return new 11AE0F91.840DFA36(this.98A2A683());
			Block_13:
			num %= 813910204U;
			return new 11AE0F91.6A9A2996(this.D20998B6());
			Block_14:
			num = (1713958670U | num);
			ulong 9939B02E = this.6D84E72D();
			num <<= 21;
			return new 11AE0F91.4422B13D(9939B02E);
			Block_15:
			return new 11AE0F91.7621E502(this.599106A4());
			IL_2A5:
			num += 1177998009U;
			num &= 4271118394U;
			return new 11AE0F91.122C9D2C(this.DD227D0D());
			Block_17:
			IntPtr b68DCD = this.D20542BB();
			num %= 3063628573U;
			return new 11AE0F91.8A270C3B(b68DCD);
			Block_18:
			UIntPtr 1CB6089E = this.0E10D236();
			num = (101991847U | num);
			return new 11AE0F91.39A8C69A(1CB6089E);
			Block_20:
			object 95274FB = this.D697DB31();
			num -= 1101978115U;
			return new 11AE0F91.1718F939(95274FB);
			Block_23:
			void* ptr = intPtr.ToPointer();
			num -= 2403061941U;
			object 4287A = Pointer.Box(ptr, 31130EB4);
			num = 1378558389U + num;
			return new 11AE0F91.470344A8(4287A, 31130EB4);
			IL_403:
			num = 2595373593U + num;
			object 8237D7A = this.D697DB31();
			num <<= 26;
			return new 11AE0F91.1C16CD2C(8237D7A);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0005ED24 File Offset: 0x0005C924
		public virtual sbyte 482F2014()
		{
			uint num = 2407903669U;
			object value = this.D697DB31();
			num = 1570336166U % num;
			return Convert.ToSByte(value);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0005F008 File Offset: 0x0005CC08
		public virtual void 3F831A1B(int C7A9131D)
		{
			this.02A8CFB0 = C7A9131D;
		}

		// Token: 0x060001C2 RID: 450
		public abstract void 7E869424(object 9590F201);

		// Token: 0x060001C3 RID: 451 RVA: 0x0005EE08 File Offset: 0x0005CA08
		public virtual ushort CF9960A3()
		{
			return Convert.ToUInt16(this.D697DB31());
		}

		// Token: 0x060001C4 RID: 452
		public abstract 11AE0F91.80068AA5 ECAA59A1();

		// Token: 0x040000D6 RID: 214
		private int 02A8CFB0;
	}

	// Token: 0x02000041 RID: 65
	private sealed class 373CCBBA : 11AE0F91.80068AA5
	{
		// Token: 0x060001C9 RID: 457 RVA: 0x00062DB4 File Offset: 0x000609B4
		public static 11AE0F91.80068AA5 75837AA8(11AE0F91.80068AA5 B1375B2C)
		{
			for (;;)
			{
				IL_00:
				ulong num = B1375B2C.6D84E72D();
				uint num2 = 2066094246U;
				if ((1939753484U & num2) != 0U)
				{
					for (;;)
					{
						int num3 = B1375B2C.3BA55C01() & (int)(num2 - 2066094242U);
						uint num4 = num2 ^ 2066094246U;
						num2 *= 1856686987U;
						bool flag = num3 > num4;
						num2 = 1746113547U % num2;
						bool flag2 = flag;
						int num5 = (int)(num2 - 1746113547U);
						for (;;)
						{
							long num6 = (long)num;
							num2 = (1501797408U | num2);
							if (num6 <= (long)(num2 + 2255283156U))
							{
								num2 = (892894008U | num2);
								if (num2 <= 397808953U)
								{
									goto IL_00;
								}
								bool flag3 = flag2;
								num2 *= 1017646871U;
								if (flag3)
								{
									break;
								}
								num2 *= 2937096490U;
								if (num2 == 1395740672U)
								{
									continue;
								}
								short num7 = num;
								num2 = 4103437489U / num2;
								short num8 = num7;
								uint num9 = num2 ^ 4294934529U;
								num2 += 2727371596U;
								if (num8 >= num9)
								{
									break;
								}
								num2 += 3607312606U;
							}
							num2 += 530624904U;
							if ((num2 & 1597659186U) != 0U)
							{
								goto Block_5;
							}
						}
						IL_DF:
						B1375B2C = new 11AE0F91.CB943E91((int)((short)num));
						if (num2 == 404767494U)
						{
							break;
						}
						11AE0F91.80068AA5 80068AA = B1375B2C;
						num2 = (3290628154U | num2);
						int c7A9131D = num5;
						num2 = 2554000811U >> (int)num2;
						80068AA.3F831A1B(c7A9131D);
						if (2586319893U - num2 != 0U)
						{
							return B1375B2C;
						}
						continue;
						Block_5:
						num5 |= (int)(num2 ^ 2570341795U);
						num2 ^= 1000615678U;
						goto IL_DF;
					}
				}
			}
			return B1375B2C;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00062CFC File Offset: 0x000608FC
		public override sbyte 482F2014()
		{
			return (sbyte)this.2A8BC30B;
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00062D98 File Offset: 0x00060998
		public override uint 98A2A683()
		{
			return (uint)this.2A8BC30B;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00062D3C File Offset: 0x0006093C
		public override short C6A6922C()
		{
			return this.2A8BC30B;
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00062D84 File Offset: 0x00060984
		public override int 30B7A98C()
		{
			return (int)this.2A8BC30B;
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00062C38 File Offset: 0x00060838
		public override Type 20129380()
		{
			return typeof(short);
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00062C70 File Offset: 0x00060870
		public override object D697DB31()
		{
			uint num = 2896110996U;
			num |= 985262394U;
			return this.2A8BC30B;
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00062C98 File Offset: 0x00060898
		public override void 7E869424(object CB1F8FA9)
		{
			uint num = 3028471603U;
			if (1209210165U <= num)
			{
				num /= 3057448848U;
				short num2 = Convert.ToInt16(CB1F8FA9);
				num = (958578203U | num);
				this.2A8BC30B = num2;
			}
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00062C50 File Offset: 0x00060850
		public override 11AE0F91.80068AA5 ECAA59A1()
		{
			return new 11AE0F91.373CCBBA(this.2A8BC30B);
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00062D58 File Offset: 0x00060958
		public override ushort CF9960A3()
		{
			uint num = 4220535444U;
			num -= 842874931U;
			ushort num2 = (ushort)this.2A8BC30B;
			num += 3921658753U;
			return num2;
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00062D18 File Offset: 0x00060918
		public override byte B508A9AB()
		{
			uint num = 4054774545U;
			byte b = (byte)this.2A8BC30B;
			num = (742051601U & num);
			return b;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00062CD4 File Offset: 0x000608D4
		public override 11AE0F91.6012BE05 04A04CBD()
		{
			uint num = 2375130144U;
			num = 1326687012U + num;
			return new 11AE0F91.CB943E91(this.30B7A98C());
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00062C10 File Offset: 0x00060810
		public 373CCBBA(short 03302CA5)
		{
			uint num = 1732105647U;
			num = 647467286U % num;
			base..ctor();
			this.2A8BC30B = 03302CA5;
		}

		// Token: 0x040000D7 RID: 215
		private short 2A8BC30B;
	}

	// Token: 0x02000047 RID: 71
	private sealed class 92167A27 : 11AE0F91.FCB842B2
	{
		// Token: 0x060001DC RID: 476 RVA: 0x000667E0 File Offset: 0x000643E0
		public override sbyte 482F2014()
		{
			return (sbyte)Marshal.ReadByte(this.9D8F251B);
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00066940 File Offset: 0x00064540
		public override ulong 6D84E72D()
		{
			uint num = 2141870374U;
			num %= 2141337648U;
			IntPtr ptr = this.9D8F251B;
			num /= 2165341074U;
			return (ulong)Marshal.ReadInt64(ptr);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00066830 File Offset: 0x00064430
		public override int 30B7A98C()
		{
			return Marshal.ReadInt32(this.9D8F251B);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x000669E0 File Offset: 0x000645E0
		public override IntPtr D20542BB()
		{
			uint num = 3365204530U;
			long value;
			while (IntPtr.Size == (int)(num - 3365204526U))
			{
				if (num < 4181213586U)
				{
					num = 673349277U - num;
					value = (long)Marshal.ReadInt32(this.9D8F251B);
					num += 1762092487U;
					IL_4E:
					num &= 338779933U;
					return new IntPtr(value);
				}
			}
			value = Marshal.ReadInt64(this.9D8F251B);
			goto IL_4E;
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x000669B0 File Offset: 0x000645B0
		public override double DD227D0D()
		{
			uint num = 2553136920U;
			return BitConverter.ToDouble(BitConverter.GetBytes(Marshal.ReadInt64(this.9D8F251B)), (int)(num - 2553136920U));
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0006643C File Offset: 0x0006403C
		public override void 7E869424(object FB28E7A6)
		{
			uint num = 2326300180U;
			for (;;)
			{
				num %= 2090389252U;
				if (FB28E7A6 == null)
				{
					num &= 546479247U;
					if (num << 15 != 0U)
					{
						break;
					}
				}
				num *= 1352096170U;
				if (this.DD88E2B8.IsValueType)
				{
					goto Block_2;
				}
				if (num == 774850580U)
				{
					break;
				}
				Type type = FB28E7A6.GetType();
				num = (741886752U & num);
				TypeCode typeCode = Type.GetTypeCode(type);
				for (;;)
				{
					TypeCode typeCode2 = typeCode;
					num = (3702346526U | num);
					uint num2 = num ^ 3702346554U;
					num = 2518725427U >> (int)num;
					switch (typeCode2 - num2)
					{
					case 0:
						goto IL_16A;
					case 1:
						goto IL_F4;
					case 2:
						goto IL_123;
					case 3:
					{
						num >>= 4;
						IntPtr ptr = this.9D8F251B;
						num <<= 21;
						short val = Convert.ToInt16(FB28E7A6);
						num = 1152874936U - num;
						Marshal.WriteInt16(ptr, val);
						if (num + 3254933278U != 0U)
						{
							return;
						}
						continue;
					}
					case 4:
						goto IL_1F0;
					case 5:
						goto IL_223;
					case 6:
						goto IL_265;
					case 7:
						goto IL_287;
					case 8:
						goto IL_2AF;
					case 9:
						goto IL_2EC;
					case 10:
						goto IL_333;
					}
					goto Block_4;
				}
				IL_F4:
				num = 641364137U - num;
				IntPtr ptr2 = this.9D8F251B;
				num = (4053537069U & num);
				Marshal.WriteByte(ptr2, (byte)Convert.ToSByte(FB28E7A6));
				if (num / 1570051597U == 0U)
				{
					return;
				}
				continue;
				IL_123:
				num = 2728303374U << (int)num;
				if (num == 1782457484U)
				{
					break;
				}
				IntPtr ptr3 = this.9D8F251B;
				num -= 3669957043U;
				byte val2 = Convert.ToByte(FB28E7A6);
				num = 2813210775U % num;
				Marshal.WriteByte(ptr3, val2);
				if ((num & 371066010U) != 0U)
				{
					return;
				}
				continue;
				IL_16A:
				num *= 2369075096U;
				if (num == 598313227U)
				{
					break;
				}
				num -= 3826750015U;
				IntPtr ptr4 = this.9D8F251B;
				num += 196063026U;
				num ^= 2343200513U;
				char val3 = Convert.ToChar(FB28E7A6);
				num = (1535365774U ^ num);
				Marshal.WriteInt16(ptr4, val3);
				if (num != 4112147356U)
				{
					return;
				}
				continue;
				IL_2AF:
				if (num < 3616658693U)
				{
					goto Block_12;
				}
				continue;
				IL_2EC:
				num = 3937278652U / num;
				IntPtr ptr5 = this.9D8F251B;
				num ^= 4093796890U;
				byte[] bytes = BitConverter.GetBytes(Convert.ToSingle(FB28E7A6));
				num = 664907527U - num;
				Marshal.WriteInt32(ptr5, BitConverter.ToInt32(bytes, (int)(num + 1504952381U)));
				if ((num & 1267265701U) != 0U)
				{
					return;
				}
				continue;
				IL_333:
				num = (3996465696U ^ num);
				if (num < 4187891595U)
				{
					goto Block_14;
				}
			}
			IL_28:
			throw new ArgumentException();
			Block_2:
			num += 2552801953U;
			num = 1831245982U + num;
			IntPtr ptr6 = this.9D8F251B;
			num = (2201389748U | num);
			bool fDeleteOld = (num ^ 3489131519U) != 0U;
			num = 935284907U << (int)num;
			Marshal.StructureToPtr(FB28E7A6, ptr6, fDeleteOld);
			return;
			Block_4:
			throw new ArgumentException();
			IL_1F0:
			IntPtr ptr7 = this.9D8F251B;
			num /= 4046005562U;
			num -= 3430973836U;
			short num3 = (short)Convert.ToUInt16(FB28E7A6);
			num = 4178193330U * num;
			short val4 = num3;
			num ^= 3273968191U;
			Marshal.WriteInt16(ptr7, val4);
			return;
			IL_223:
			num /= 3065129019U;
			IntPtr ptr8 = this.9D8F251B;
			num = 3985298722U >> (int)num;
			int val5 = Convert.ToInt32(FB28E7A6);
			num = 295095600U - num;
			Marshal.WriteInt32(ptr8, val5);
			if (1862656030 << (int)num != 0)
			{
				return;
			}
			goto IL_28;
			IL_265:
			num <<= 30;
			IntPtr ptr9 = this.9D8F251B;
			num &= 3340427047U;
			Marshal.WriteInt32(ptr9, (int)Convert.ToUInt32(FB28E7A6));
			return;
			IL_287:
			num = 2604360623U >> (int)num;
			IntPtr ptr10 = this.9D8F251B;
			num *= 1427634588U;
			Marshal.WriteInt64(ptr10, Convert.ToInt64(FB28E7A6));
			return;
			Block_12:
			num &= 195256852U;
			IntPtr ptr11 = this.9D8F251B;
			num /= 698151216U;
			num += 3120704774U;
			long val6 = (long)Convert.ToUInt64(FB28E7A6);
			num %= 2879162129U;
			Marshal.WriteInt64(ptr11, val6);
			return;
			Block_14:
			num %= 1756005930U;
			IntPtr ptr12 = this.9D8F251B;
			num /= 4062229665U;
			double value = Convert.ToDouble(FB28E7A6);
			num = 2696163218U >> (int)num;
			byte[] bytes2 = BitConverter.GetBytes(value);
			int startIndex = (int)(num - 2696163218U);
			num ^= 3635580165U;
			Marshal.WriteInt64(ptr12, BitConverter.ToInt64(bytes2, startIndex));
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00066140 File Offset: 0x00063D40
		public override 11AE0F91.80068AA5 ECAA59A1()
		{
			uint num = 2788490647U;
			IntPtr f79C96A = this.9D8F251B;
			num &= 45217588U;
			Type dd88E2B = this.DD88E2B8;
			num = 2627070257U / num;
			return new 11AE0F91.92167A27(f79C96A, dd88E2B);
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x000668E0 File Offset: 0x000644E0
		public override ushort CF9960A3()
		{
			uint num = 1085816759U;
			num = (900296065U & num);
			IntPtr ptr = this.9D8F251B;
			num = (950483767U | num);
			ushort num2 = (ushort)Marshal.ReadInt16(ptr);
			num ^= 3995862460U;
			return num2;
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00066878 File Offset: 0x00064478
		public override char 8EBDB806()
		{
			uint num = 884452792U;
			num = 1251251387U * num;
			IntPtr ptr = this.9D8F251B;
			num = 4001991307U % num;
			char c = (char)Marshal.ReadInt16(ptr);
			num = 3640703548U << (int)num;
			return c;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00066800 File Offset: 0x00064400
		public override short C6A6922C()
		{
			uint num = 1572235784U;
			num = 2375269556U * num;
			IntPtr ptr = this.9D8F251B;
			num = 1803963162U % num;
			return Marshal.ReadInt16(ptr);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x000668B8 File Offset: 0x000644B8
		public override byte B508A9AB()
		{
			uint num = 3491546680U;
			IntPtr ptr = this.9D8F251B;
			num %= 4071308417U;
			return Marshal.ReadByte(ptr);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00066A48 File Offset: 0x00064648
		public override UIntPtr 0E10D236()
		{
			uint num;
			ulong value;
			if (IntPtr.Size != 4)
			{
				num = 3375797427U;
				if (3728470449U * num != 0U)
				{
					value = (ulong)Marshal.ReadInt64(this.9D8F251B);
					goto IL_47;
				}
			}
			ulong num2 = (ulong)Marshal.ReadInt32(this.9D8F251B);
			num = 329152691U;
			value = num2;
			num ^= 3668503552U;
			IL_47:
			return new UIntPtr(value);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00066918 File Offset: 0x00064518
		public override uint 98A2A683()
		{
			uint num = 3619486391U;
			IntPtr ptr = this.9D8F251B;
			num += 3213652515U;
			return (uint)Marshal.ReadInt32(ptr);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00066174 File Offset: 0x00063D74
		public override object D697DB31()
		{
			uint num;
			for (;;)
			{
				IL_00:
				Type dd88E2B = this.DD88E2B8;
				num = 3448202534U;
				bool isValueType = dd88E2B.IsValueType;
				num = (1629441086U & num);
				if (isValueType)
				{
					break;
				}
				for (;;)
				{
					num = 3089984305U << (int)num;
					if ((487950780U ^ num) == 0U)
					{
						goto IL_26;
					}
					num = 3181976704U / num;
					Type dd88E2B2 = this.DD88E2B8;
					num <<= 2;
					TypeCode typeCode = Type.GetTypeCode(dd88E2B2);
					num >>= 17;
					TypeCode typeCode2 = typeCode;
					if ((369998344U ^ num) != 0U)
					{
						switch (typeCode2 - (TypeCode)(num ^ 4U))
						{
						case 0:
							goto IL_125;
						case 1:
							goto IL_D5;
						case 2:
							goto IL_FA;
						case 3:
							goto IL_147;
						case 4:
							num ^= 3601966085U;
							if (num != 1049382298U)
							{
								goto Block_7;
							}
							continue;
						case 5:
							goto IL_1AD;
						case 6:
							goto IL_1CC;
						case 7:
							goto IL_201;
						case 8:
							goto IL_212;
						case 9:
							goto IL_22B;
						case 10:
							goto IL_268;
						}
						break;
					}
					goto IL_00;
				}
				if (num / 1235916208U != 0U)
				{
					continue;
				}
				num = (379732110U & num);
				if (4010948121U != num)
				{
					goto Block_9;
				}
				continue;
				IL_FA:
				if (731847451 << (int)num != 0)
				{
					goto Block_6;
				}
				continue;
				IL_22B:
				num = (1562708743U & num);
				if (3390072355U >= num)
				{
					goto Block_8;
				}
			}
			num |= 3936700219U;
			IL_26:
			IntPtr ptr = this.9D8F251B;
			Type dd88E2B3 = this.DD88E2B8;
			num &= 1964266545U;
			return Marshal.PtrToStructure(ptr, dd88E2B3);
			IL_D5:
			if (1580117125U > num)
			{
				IntPtr ptr2 = this.9D8F251B;
				num = (2736057092U & num);
				return (sbyte)Marshal.ReadByte(ptr2);
			}
			goto IL_26;
			Block_6:
			num = 1822396830U * num;
			return Marshal.ReadByte(this.9D8F251B);
			IL_125:
			num = (1974441237U | num);
			char c = (char)Marshal.ReadInt16(this.9D8F251B);
			num = 4071227681U * num;
			return c;
			IL_147:
			num >>= 14;
			num += 2678741525U;
			IntPtr ptr3 = this.9D8F251B;
			num = (482100796U & num);
			return Marshal.ReadInt16(ptr3);
			Block_7:
			num = 834455564U / num;
			IntPtr ptr4 = this.9D8F251B;
			num = 2938169786U - num;
			ushort num2 = (ushort)Marshal.ReadInt16(ptr4);
			num = (1219487152U ^ num);
			return num2;
			IL_1AD:
			IntPtr ptr5 = this.9D8F251B;
			num = 1368613911U >> (int)num;
			return Marshal.ReadInt32(ptr5);
			IL_1CC:
			num = 633310725U >> (int)num;
			num |= 104691604U;
			uint num3 = (uint)Marshal.ReadInt32(this.9D8F251B);
			num = 3803743795U << (int)num;
			return num3;
			IL_201:
			return Marshal.ReadInt64(this.9D8F251B);
			IL_212:
			num ^= 2282903610U;
			return (ulong)Marshal.ReadInt64(this.9D8F251B);
			Block_8:
			int value = Marshal.ReadInt32(this.9D8F251B);
			num >>= 18;
			return BitConverter.ToSingle(BitConverter.GetBytes(value), (int)(num - 0U));
			IL_268:
			num = 3459281828U - num;
			IntPtr ptr6 = this.9D8F251B;
			num &= 3954059702U;
			byte[] bytes = BitConverter.GetBytes(Marshal.ReadInt64(ptr6));
			int startIndex = (int)(num ^ 3391103396U);
			num = 1937852094U % num;
			return BitConverter.ToDouble(bytes, startIndex);
			Block_9:
			throw new ArgumentException();
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00066850 File Offset: 0x00064450
		public override long D20998B6()
		{
			uint num = 3817105852U;
			IntPtr ptr = this.9D8F251B;
			num = 956401805U / num;
			return Marshal.ReadInt64(ptr);
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00066120 File Offset: 0x00063D20
		public override Type 20129380()
		{
			return typeof(Pointer);
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00066970 File Offset: 0x00064570
		public override float 599106A4()
		{
			uint num = 2399930428U;
			int value = Marshal.ReadInt32(this.9D8F251B);
			num = (2006065197U ^ num);
			byte[] bytes = BitConverter.GetBytes(value);
			num /= 901347877U;
			return BitConverter.ToSingle(bytes, (int)(num ^ 4U));
		}

		// Token: 0x060001ED RID: 493 RVA: 0x000660DC File Offset: 0x00063CDC
		public 92167A27(IntPtr F79C96A4, Type 820612B2)
		{
			uint num;
			do
			{
				base..ctor();
				num = 2393912192U;
				this.9D8F251B = F79C96A4;
				num |= 354785191U;
				num = 3090090036U + num;
				this.DD88E2B8 = 820612B2;
			}
			while (2996323469U == num);
		}

		// Token: 0x040000D9 RID: 217
		private Type DD88E2B8;

		// Token: 0x040000DA RID: 218
		private IntPtr 9D8F251B;
	}

	// Token: 0x02000048 RID: 72
	private sealed class 4F0A3DA2
	{
		// Token: 0x060001EE RID: 494 RVA: 0x0005E5C0 File Offset: 0x0005C1C0
		public void CB2E97A6(byte[] A2228B24, Module 63311D17)
		{
			uint num;
			for (;;)
			{
				IL_00:
				11AE0F91.56055C27 56055C = new 11AE0F91.56055C27(A2228B24);
				num = 1410300962U;
				11AE0F91.56055C27 56055C2 = 56055C;
				uint num12;
				int num14;
				for (;;)
				{
					IL_0E:
					11AE0F91.56055C27 56055C3 = 56055C2;
					num ^= 741703223U;
					11AE0F91.2A15CE18 2A15CE = (11AE0F91.2A15CE18)56055C3.749BD5AB();
					num = 1773097904U / num;
					this.961D8726 = 2A15CE;
					num = (50591128U ^ num);
					for (;;)
					{
						IL_33:
						num %= 2469938826U;
						bool flag = this.961D8726 != 11AE0F91.2A15CE18.F68C7D06;
						bool flag2 = (num ^ 50591112U) != 0U;
						num |= 2997107483U;
						if (flag && flag2)
						{
							goto IL_56;
						}
						IL_73:
						while (num != 144823171U)
						{
							num = 3953549991U << (int)num;
							11AE0F91.2A15CE18 2A15CE2 = this.961D8726;
							num >>= 6;
							11AE0F91.2A15CE18 2A15CE3 = 2A15CE2 & (11AE0F91.2A15CE18)(num - 14680049U);
							num |= 1091791418U;
							11AE0F91.2A15CE18 2A15CE4 = 2A15CE3;
							num = (1421189431U & num);
							11AE0F91.2A15CE18 2A15CE5 = 2A15CE4;
							num = 2668296369U / num;
							switch (2A15CE5)
							{
							case 0:
							case 1:
							case 2:
							case 3:
							case 4:
							case 5:
							case 8:
							case 9:
							case 11:
							{
								num = (4043666457U ^ num);
								uint num2 = 56055C2.0428FF10();
								num <<= 22;
								uint num3 = num2;
								num = 3785266483U >> (int)num;
								if (2704633255U >= num)
								{
									goto IL_56;
								}
								11AE0F91.56055C27 56055C4 = 56055C2;
								num = 3323441675U * num;
								this.0CB38901 = 56055C4.F6146116(63311D17);
								int num4 = (int)num3;
								num = 1317627706U + num;
								Type[] array = new Type[num4];
								num >>= 21;
								this.59225E1B = array;
								num = (2652901518U & num);
								int num5 = (int)(num - 140U);
								num = 1857841923U - num;
								int num6 = num5;
								if (2592824501U >> (int)num != 0U)
								{
									while ((2819507728U & num) != 0U)
									{
										long num7 = (long)num6;
										num = (4086016433U ^ num);
										ulong num8 = (ulong)num7;
										num -= 2567353148U;
										if (num8 >= (ulong)num3)
										{
											if (num << 0 != 0U)
											{
												return;
											}
											goto IL_33;
										}
										else
										{
											num = 2743764020U;
											if (num > 2939038612U)
											{
												break;
											}
											Type[] array2 = this.59225E1B;
											int num9 = num6;
											11AE0F91.56055C27 56055C5 = 56055C2;
											num += 707684362U;
											num ^= 2854229822U;
											array2[num9] = 56055C5.F6146116(63311D17);
											int num10 = num6;
											num = 3123261838U - num;
											int num11 = num10 + (int)(num + 2909784435U);
											num &= 3967920550U;
											num6 = num11;
											num += 775703025U;
										}
									}
									goto IL_00;
								}
								goto IL_56;
							}
							case 6:
							{
								num >>= 16;
								if (2535929253U <= num)
								{
									goto IL_0E;
								}
								num >>= 9;
								11AE0F91.56055C27 56055C6 = 56055C2;
								num = 1831662612U * num;
								this.0CB38901 = 56055C6.F6146116(63311D17);
								if (num != 2492325652U)
								{
									return;
								}
								goto IL_56;
							}
							case 7:
							case 10:
							{
								num ^= 1587947546U;
								num12 = 56055C2.0428FF10();
								num = (2568300164U | num);
								if (num <= 87088181U)
								{
									goto IL_00;
								}
								num = 606804528U >> (int)num;
								int num13 = (int)num12;
								num %= 2669705603U;
								this.59225E1B = new Type[num13];
								num14 = (int)(num ^ 2U);
								if (515530240U > num)
								{
									goto Block_11;
								}
								continue;
							}
							}
							goto Block_1;
						}
						break;
						IL_56:
						11AE0F91.56055C27 56055C7 = 56055C2;
						num /= 3451088662U;
						this.8797DF30 = 56055C7.0428FF10();
						num ^= 3014131611U;
						goto IL_73;
					}
				}
				Block_11:
				for (;;)
				{
					num = (3392273825U | num);
					ulong num15 = (ulong)((long)num14);
					num = 1560856366U / num;
					if (num15 >= (ulong)num12)
					{
						return;
					}
					num = 4095697045U;
					if (488222761U == num)
					{
						break;
					}
					num *= 2031491735U;
					this.59225E1B[num14] = 56055C2.F6146116(63311D17);
					int num16 = num14;
					num = 607735322U * num;
					int num17 = num16 + (int)(num ^ 3163998991U);
					num = 2609420701U % num;
					num14 = num17;
					num += 1685546597U;
				}
			}
			Block_1:
			num = 2670158085U / num;
			string message = null;
			num += 1262052627U;
			int errorCode = (int)(num - 448398172U);
			num /= 1359821077U;
			throw new COMException(message, errorCode);
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060001EF RID: 495 RVA: 0x0005E514 File Offset: 0x0005C114
		public bool 11AF2ABB
		{
			get
			{
				uint num2;
				for (;;)
				{
					uint num = (uint)this.961D8726;
					num2 = 3205650318U;
					switch (num & (num2 ^ 3205650305U))
					{
					case 0U:
					case 1U:
					case 2U:
					case 3U:
					case 4U:
					case 5U:
					case 9U:
					case 11U:
						goto IL_64;
					case 6U:
					case 7U:
					case 8U:
					case 10U:
						goto IL_74;
					default:
						if (1745524911U * num2 != 0U)
						{
							goto Block_1;
						}
						break;
					}
				}
				Block_1:
				num2 += 0U;
				goto IL_74;
				IL_64:
				num2 -= 3909225772U;
				return (num2 ^ 3591391843U) != 0U;
				IL_74:
				num2 = 428224662U % num2;
				return (num2 ^ 428224662U) != 0U;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x0005E458 File Offset: 0x0005C058
		public Type 300483B6
		{
			get
			{
				return this.0CB38901;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x0005E474 File Offset: 0x0005C074
		public CallingConvention 9D1F5603
		{
			get
			{
				11AE0F91.2A15CE18 2A15CE = this.961D8726 & 11AE0F91.2A15CE18.40252A8A;
				uint num = 2922304649U;
				if (num >= 378783500U)
				{
					for (;;)
					{
						11AE0F91.2A15CE18 2A15CE2 = 2A15CE;
						num /= 906620320U;
						uint num2 = num ^ 2U;
						num >>= 16;
						switch (2A15CE2 - num2)
						{
						case 0:
							goto IL_5A;
						case 1:
							goto IL_62;
						case 2:
							goto IL_6A;
						case 3:
							goto IL_72;
						default:
							if ((2962714265U & num) == 0U)
							{
								goto Block_2;
							}
							break;
						}
					}
					Block_2:
					goto IL_82;
					IL_5A:
					return (CallingConvention)(num ^ 2U);
					IL_62:
					return (CallingConvention)(num - 4294967293U);
					IL_6A:
					return (CallingConvention)(num ^ 4U);
					IL_72:
					num /= 2894783283U;
					return (CallingConvention)(num ^ 5U);
				}
				IL_82:
				num &= 3300350739U;
				return (CallingConvention)(num ^ 1U);
			}
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0005E434 File Offset: 0x0005C034
		public Type[] 2D850224()
		{
			uint num = 1990591161U;
			num *= 1729863096U;
			return this.59225E1B;
		}

		// Token: 0x040000DB RID: 219
		private Type[] 59225E1B;

		// Token: 0x040000DC RID: 220
		private Type 0CB38901;

		// Token: 0x040000DD RID: 221
		private uint 8797DF30;

		// Token: 0x040000DE RID: 222
		private 11AE0F91.2A15CE18 961D8726;
	}

	// Token: 0x02000050 RID: 80
	private sealed class 060D1790 : 11AE0F91.FCB842B2
	{
		// Token: 0x06000203 RID: 515 RVA: 0x00066D4C File Offset: 0x0006494C
		public override Type 20129380()
		{
			return typeof(int);
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00066D6C File Offset: 0x0006496C
		public override 11AE0F91.80068AA5 ECAA59A1()
		{
			return new 11AE0F91.060D1790(this.430C1F9E, this.AD0ACC96);
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00066DCC File Offset: 0x000649CC
		public override void 7E869424(object 79A618BE)
		{
			uint num = 2872304401U;
			if (2787392440U != num)
			{
				do
				{
					num = 1644991257U << (int)num;
					FieldInfo fieldInfo = this.430C1F9E;
					num = 1309858092U + num;
					object ad0ACC = this.AD0ACC96;
					num |= 4281641354U;
					11AE0F91.1280CA96 1280CA = (11AE0F91.1280CA96)fieldInfo.GetValue(ad0ACC);
					num = 3819112220U % num;
					int 301C73A = (int)79A618BE;
					num = (2869465398U ^ num);
					1280CA.37242F0A(301C73A);
				}
				while (num >= 4054816899U);
			}
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00066D90 File Offset: 0x00064990
		public override object D697DB31()
		{
			FieldInfo fieldInfo = this.430C1F9E;
			uint num = 3200248877U;
			int num2 = ((11AE0F91.1280CA96)fieldInfo.GetValue(this.AD0ACC96)).B395DB29();
			num <<= 0;
			return num2;
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00066CE8 File Offset: 0x000648E8
		public 060D1790(FieldInfo 4A2E4617, object D1295A08)
		{
			uint num = 3147151233U;
			if (num * 1270605458U != 0U)
			{
				num = 3131662209U >> (int)num;
				num = 1604271268U * num;
				this.430C1F9E = 4A2E4617;
				num &= 2105687041U;
			}
			num &= 3492230553U;
			num %= 1545966126U;
			this.AD0ACC96 = D1295A08;
		}

		// Token: 0x040000E0 RID: 224
		private object AD0ACC96;

		// Token: 0x040000E1 RID: 225
		private FieldInfo 430C1F9E;
	}

	// Token: 0x0200005F RID: 95
	private sealed class 2C3CDA04 : 11AE0F91.FCB842B2
	{
		// Token: 0x06000233 RID: 563 RVA: 0x00064DA8 File Offset: 0x000629A8
		public override void 7E869424(object 6C3F2B87)
		{
			uint num = 2485471264U;
			do
			{
				IL_06:
				num += 4255903252U;
				Type type = this.20129380();
				num = 2537387017U >> (int)num;
				TypeCode typeCode = Type.GetTypeCode(type);
				num ^= 3283860375U;
				TypeCode typeCode2 = typeCode;
				num = (3709582738U ^ num);
				for (;;)
				{
					TypeCode typeCode3 = typeCode2;
					uint num2 = num - 513806194U;
					num /= 3062172688U;
					switch (typeCode3 - num2)
					{
					case 0:
					{
						num = (3741757314U | num);
						if (3517298741U == num)
						{
							goto IL_06;
						}
						object obj = Convert.ToChar(6C3F2B87);
						num ^= 3063670714U;
						6C3F2B87 = obj;
						if (3550184839U == num)
						{
							continue;
						}
						num += 2523051976U;
						break;
					}
					case 1:
					{
						if (num / 2652872088U != 0U)
						{
							continue;
						}
						object value = 6C3F2B87;
						num = (3141507623U & num);
						6C3F2B87 = Convert.ToSByte(value);
						num += 0U;
						break;
					}
					case 2:
						goto IL_A5;
					case 3:
					{
						if (num << 5 != 0U)
						{
							continue;
						}
						object value2 = 6C3F2B87;
						num = (2350559794U & num);
						6C3F2B87 = Convert.ToInt16(value2);
						num ^= 0U;
						break;
					}
					case 4:
					{
						if (num >= 1084460715U)
						{
							continue;
						}
						object obj2 = Convert.ToUInt16(6C3F2B87);
						num %= 2201304978U;
						6C3F2B87 = obj2;
						if (num >= 35911450U)
						{
							goto IL_06;
						}
						num += 0U;
						break;
					}
					case 5:
					{
						num = 227752612U * num;
						object value3 = 6C3F2B87;
						num = (3523399459U & num);
						int num3 = Convert.ToInt32(value3);
						num = 2299756093U << (int)num;
						6C3F2B87 = num3;
						if (num >= 883758983U)
						{
							num += 1995211203U;
						}
						break;
					}
					case 6:
					{
						object value4 = 6C3F2B87;
						num = 1050034972U * num;
						uint num4 = Convert.ToUInt32(value4);
						num = 4054874910U * num;
						object obj3 = num4;
						num = 539800355U >> (int)num;
						6C3F2B87 = obj3;
						if (num / 2367270545U != 0U)
						{
							goto IL_A5;
						}
						num ^= 539800355U;
						break;
					}
					case 7:
					{
						object value5 = 6C3F2B87;
						num >>= 10;
						object obj4 = Convert.ToInt64(value5);
						num = 3718002310U + num;
						6C3F2B87 = obj4;
						if (4137004964U <= num)
						{
							goto IL_06;
						}
						num += 576964986U;
						break;
					}
					case 8:
					{
						num = 1747663754U >> (int)num;
						if (num < 438662920U)
						{
							goto IL_A5;
						}
						ulong num5 = Convert.ToUInt64(6C3F2B87);
						num = (1462840631U & num);
						object obj5 = num5;
						num &= 1203436446U;
						6C3F2B87 = obj5;
						num += 3219117822U;
						break;
					}
					}
					IL_27D:
					num += 2846685719U;
					if (num >= 851008701U)
					{
						break;
					}
					continue;
					IL_A5:
					num = 1009875248U << (int)num;
					object value6 = 6C3F2B87;
					num = 2972458420U % num;
					object obj6 = Convert.ToByte(value6);
					num = 2981208087U * num;
					6C3F2B87 = obj6;
					num ^= 3728434316U;
					goto IL_27D;
				}
				Array f7A = this.F7A06336;
				num = (965915264U ^ num);
				object value7 = 6C3F2B87;
				num *= 1059567642U;
				f7A.SetValue(value7, this.F1251582);
			}
			while (num * 2049254186U == 0U);
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00064D58 File Offset: 0x00062958
		public override 11AE0F91.80068AA5 ECAA59A1()
		{
			uint num = 3341658042U;
			Array f7A = this.F7A06336;
			num = 3028354706U + num;
			return new 11AE0F91.2C3CDA04(f7A, this.F1251582);
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00064D2C File Offset: 0x0006292C
		public override Type 20129380()
		{
			uint num = 3097959851U;
			object f7A = this.F7A06336;
			num = (67730603U & num);
			return f7A.GetType().GetElementType();
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00064D84 File Offset: 0x00062984
		public override object D697DB31()
		{
			return this.F7A06336.GetValue(this.F1251582);
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00064CD8 File Offset: 0x000628D8
		public 2C3CDA04(Array 0A043CBB, int C424FE99)
		{
			uint num;
			do
			{
				num = 2795424402U;
				base..ctor();
				num = (4088616845U | num);
				num /= 849679385U;
				num = 1143037979U % num;
				this.F7A06336 = 0A043CBB;
			}
			while (2116088884U <= num);
			num /= 2753957004U;
			this.F1251582 = C424FE99;
		}

		// Token: 0x040000EF RID: 239
		private int F1251582;

		// Token: 0x040000F0 RID: 240
		private Array F7A06336;
	}

	// Token: 0x0200007E RID: 126
	private sealed class 1718F939 : 11AE0F91.6012BE05
	{
		// Token: 0x06000261 RID: 609 RVA: 0x00064540 File Offset: 0x00062140
		public override object D697DB31()
		{
			return this.1D890486;
		}

		// Token: 0x06000262 RID: 610 RVA: 0x000643C0 File Offset: 0x00061FC0
		public override Type 20129380()
		{
			return typeof(ValueType);
		}

		// Token: 0x06000263 RID: 611 RVA: 0x0006455C File Offset: 0x0006215C
		public override void 7E869424(object 5EB8CF02)
		{
			for (;;)
			{
				uint num = 3761942457U;
				if (5EB8CF02 != null)
				{
					num |= 1000471602U;
					for (;;)
					{
						bool flag = 5EB8CF02 is ValueType;
						num = 3741611523U + num;
						num ^= 989518343U;
						if (flag)
						{
							break;
						}
						if (num >= 2634645400U)
						{
							goto Block_2;
						}
					}
				}
				while (2453029655U <= num)
				{
					num = 3416393874U << (int)num;
					this.1D890486 = 5EB8CF02;
					if ((339160625U ^ num) != 0U)
					{
						return;
					}
				}
			}
			Block_2:
			throw new ArgumentException();
		}

		// Token: 0x06000264 RID: 612 RVA: 0x000643E0 File Offset: 0x00061FE0
		public override 11AE0F91.80068AA5 ECAA59A1()
		{
			uint num = 1133393571U;
			object obj2;
			do
			{
				IL_06:
				num <<= 3;
				if (this.1D890486 != null)
				{
					num = 3373281166U << (int)num;
					num &= 3342199727U;
					object obj = this.1D890486;
					num = 3887540031U - num;
					Type type = obj.GetType();
					FieldInfo[] fields = type.GetFields((BindingFlags)(num ^ 1639393035U));
					num ^= 3356048822U;
					FieldInfo[] array = fields;
					num /= 2779260214U;
					obj2 = Activator.CreateInstance(type);
					num = (807887905U | num);
					FieldInfo[] array2 = array;
					num = 2215810316U + num;
					FieldInfo[] array3 = array2;
					int num2 = (int)(num - 3023698221U);
					while (num != 3576621884U)
					{
						int num3 = num2;
						int num4 = array3.Length;
						num /= 2929023027U;
						if (num3 >= num4)
						{
							num ^= 477213977U;
							goto IL_141;
						}
						FieldInfo[] array4 = array3;
						num = 3592389300U;
						int num5 = num2;
						num = (4145107345U & num);
						FieldInfo fieldInfo = array4[num5];
						num = 255411335U - num;
						FieldInfo fieldInfo2 = fieldInfo;
						num = 2198813728U << (int)num;
						FieldInfo fieldInfo3 = fieldInfo2;
						object obj3 = obj2;
						FieldInfo fieldInfo4 = fieldInfo2;
						num = 2007988016U + num;
						num = (109678389U & num);
						object obj4 = this.1D890486;
						num -= 1318100253U;
						fieldInfo3.SetValue(obj3, fieldInfo4.GetValue(obj4));
						if (3795370792U < num)
						{
							goto IL_06;
						}
						int num6 = num2;
						num += 839355686U;
						int num7 = (int)(num ^ 3925866296U);
						num ^= 3230725301U;
						num2 = num6 + num7;
						num ^= 2639723169U;
					}
				}
				do
				{
					obj2 = null;
				}
				while (num >= 3686120071U);
				IL_141:;
			}
			while (2117850671U < num);
			return new 11AE0F91.1718F939(obj2);
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00064334 File Offset: 0x00061F34
		public 1718F939(object 95274FB3)
		{
			uint num = 3894823481U;
			if (-327142996 << (int)num != 0)
			{
				while (95274FB3 != null)
				{
					num ^= 3811190837U;
					if (2611394576U > num)
					{
						num = 1898475664U % num;
						bool flag = 95274FB3 is ValueType;
						num = 1569710908U + num;
						num += 2280245989U;
						if (!flag)
						{
							goto IL_5A;
						}
						break;
					}
				}
				num |= 3592774456U;
				num = 1864216335U >> (int)num;
				this.1D890486 = 95274FB3;
				return;
			}
			IL_5A:
			throw new ArgumentException();
		}

		// Token: 0x040000FD RID: 253
		private object 1D890486;
	}

	// Token: 0x0200007F RID: 127
	private sealed class 39A8C69A : 11AE0F91.6012BE05
	{
		// Token: 0x06000266 RID: 614 RVA: 0x00065AF8 File Offset: 0x000636F8
		public override ulong 6D84E72D()
		{
			uint num = 3716354081U;
			num = (2410221238U | num);
			11AE0F91.80068AA5 80068AA = this.4F9BB201;
			num %= 3585480196U;
			return 80068AA.6D84E72D();
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00065BA4 File Offset: 0x000637A4
		public static 11AE0F91.80068AA5 362B2039(11AE0F91.80068AA5 EF3D9112)
		{
			int size = IntPtr.Size;
			uint num = 713980448U;
			uint num2 = num + 3580986852U;
			num *= 4138477981U;
			if (size == num2 || 1395681178U == num)
			{
				num |= 3224252605U;
				if ((2425910578U & num) != 0U)
				{
					return 11AE0F91.840DFA36.B78D5C34(EF3D9112);
				}
			}
			return 11AE0F91.4422B13D.E50C09B0(EF3D9112);
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00065934 File Offset: 0x00063534
		public override 11AE0F91.80068AA5 ECAA59A1()
		{
			return new 11AE0F91.39A8C69A(this.9B967D39);
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00065A20 File Offset: 0x00063620
		public override short C6A6922C()
		{
			return this.4F9BB201.C6A6922C();
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00065B88 File Offset: 0x00063788
		public override UIntPtr 0E10D236()
		{
			return this.9B967D39;
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00065954 File Offset: 0x00063554
		public override object D697DB31()
		{
			return this.9B967D39;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00065AD8 File Offset: 0x000636D8
		public override uint 98A2A683()
		{
			return this.4F9BB201.98A2A683();
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00065B68 File Offset: 0x00063768
		public override IntPtr D20542BB()
		{
			return this.4F9BB201.D20542BB();
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00065A90 File Offset: 0x00063690
		public override byte B508A9AB()
		{
			uint num = 2626733592U;
			num >>= 11;
			return this.4F9BB201.B508A9AB();
		}

		// Token: 0x0600026F RID: 623 RVA: 0x000659F8 File Offset: 0x000635F8
		public override sbyte 482F2014()
		{
			uint num = 1176601663U;
			11AE0F91.80068AA5 80068AA = this.4F9BB201;
			num |= 1151885490U;
			return 80068AA.482F2014();
		}

		// Token: 0x06000270 RID: 624 RVA: 0x000658B0 File Offset: 0x000634B0
		private static 11AE0F91.80068AA5 56308689(UIntPtr 3719B62E)
		{
			uint num = 1125691152U;
			uint size = (uint)IntPtr.Size;
			num -= 2200012850U;
			if (size != num + 1074321702U || num < 1287190302U)
			{
				num = (3717968913U & num);
				if (num / 1108328481U != 0U)
				{
					return new 11AE0F91.6A9A2996((long)3719B62E.ToUInt64());
				}
			}
			int e99A = (int)3719B62E.ToUInt32();
			num = 179508490U / num;
			return new 11AE0F91.CB943E91(e99A);
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0006591C File Offset: 0x0006351C
		public override Type 20129380()
		{
			return typeof(UIntPtr);
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0006596C File Offset: 0x0006356C
		public override void 7E869424(object F79DCD30)
		{
			uint num = 1578219446U;
			num += 2661483784U;
			num = 3834754741U - num;
			UIntPtr uintPtr = (UIntPtr)F79DCD30;
			num = 436874786U * num;
			this.9B967D39 = uintPtr;
			num = 639863203U % num;
			num |= 405985565U;
			num = (1805934134U ^ num);
			this.4F9BB201 = 11AE0F91.39A8C69A.56308689(this.9B967D39);
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00065B48 File Offset: 0x00063748
		public override double DD227D0D()
		{
			return this.4F9BB201.DD227D0D();
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00065A68 File Offset: 0x00063668
		public override long D20998B6()
		{
			uint num = 2326883114U;
			num = 530999721U % num;
			return this.4F9BB201.D20998B6();
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00065B28 File Offset: 0x00063728
		public override float 599106A4()
		{
			return this.4F9BB201.599106A4();
		}

		// Token: 0x06000276 RID: 630 RVA: 0x000659CC File Offset: 0x000635CC
		public override bool 2206A10D()
		{
			uint num = 2996996670U;
			UIntPtr value = this.9B967D39;
			num %= 3960269955U;
			return value != UIntPtr.Zero;
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00065A40 File Offset: 0x00063640
		public override int 30B7A98C()
		{
			uint num = 479644163U;
			num = 1335880462U % num;
			return this.4F9BB201.30B7A98C();
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00065AB8 File Offset: 0x000636B8
		public override ushort CF9960A3()
		{
			return this.4F9BB201.CF9960A3();
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00065850 File Offset: 0x00063450
		public 39A8C69A(UIntPtr 1CB6089E)
		{
			for (;;)
			{
				uint num = 4011540506U;
				base..ctor();
				if (num >= 3725617674U)
				{
					num = 3534966696U % num;
					this.9B967D39 = 1CB6089E;
					num = 4194477085U * num;
					num %= 3758717444U;
					this.4F9BB201 = 11AE0F91.39A8C69A.56308689(this.9B967D39);
					if (1487790859U < num)
					{
						break;
					}
				}
			}
		}

		// Token: 0x040000FE RID: 254
		private 11AE0F91.80068AA5 4F9BB201;

		// Token: 0x040000FF RID: 255
		private UIntPtr 9B967D39;
	}

	// Token: 0x02000084 RID: 132
	private sealed class 29057C93 : 11AE0F91.6012BE05
	{
		// Token: 0x0600027F RID: 639 RVA: 0x00065DB0 File Offset: 0x000639B0
		public override Type 20129380()
		{
			uint num = 238809915U;
			num ^= 3892514853U;
			return this.BD9B73B9.GetType();
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00065F44 File Offset: 0x00063B44
		public override uint 98A2A683()
		{
			return this.35B55287.98A2A683();
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00065E1C File Offset: 0x00063A1C
		public override void 7E869424(object FD0723B2)
		{
			if (FD0723B2 != null)
			{
				Enum bd9B73B = (Enum)FD0723B2;
				uint num = 2240889483U;
				this.BD9B73B9 = bd9B73B;
				num = 700262298U / num;
				if (num != 303259572U)
				{
					num = (3769975063U | num);
					num = 101552439U + num;
					this.35B55287 = 11AE0F91.29057C93.BD383D3E(this.BD9B73B9);
					return;
				}
			}
			throw new ArgumentException();
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00065FAC File Offset: 0x00063BAC
		public override float 599106A4()
		{
			uint num = 362607642U;
			num >>= 20;
			11AE0F91.80068AA5 80068AA = this.35B55287;
			num = 822630078U << (int)num;
			return 80068AA.599106A4();
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00066070 File Offset: 0x00063C70
		public override UIntPtr 0E10D236()
		{
			int size = IntPtr.Size;
			int num = 4;
			uint num2 = 473261605U;
			ulong value;
			if ((size == num || num2 <= 335548435U) && 3862840211U * num2 != 0U)
			{
				num2 = 2017017356U - num2;
				value = (ulong)this.98A2A683();
				num2 ^= 917506033U;
			}
			else
			{
				num2 -= 2978059791U;
				value = this.6D84E72D();
			}
			num2 -= 673422109U;
			return new UIntPtr(value);
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00066008 File Offset: 0x00063C08
		public override IntPtr D20542BB()
		{
			uint num = 2415924405U;
			long value;
			while (IntPtr.Size == (int)(num ^ 2415924401U))
			{
				if (26300989U >> (int)num != 0U)
				{
					num = 3827768348U / num;
					long num2 = (long)this.30B7A98C();
					num /= 3172047749U;
					value = num2;
					num ^= 2415924405U;
					IL_53:
					return new IntPtr(value);
				}
			}
			value = this.D20998B6();
			goto IL_53;
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00065FE0 File Offset: 0x00063BE0
		public override double DD227D0D()
		{
			uint num = 1259612676U;
			11AE0F91.80068AA5 80068AA = this.35B55287;
			num *= 566193026U;
			return 80068AA.DD227D0D();
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00065F24 File Offset: 0x00063B24
		public override int 30B7A98C()
		{
			return this.35B55287.30B7A98C();
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00065EFC File Offset: 0x00063AFC
		public override ushort CF9960A3()
		{
			uint num = 4256823189U;
			num <<= 13;
			return this.35B55287.CF9960A3();
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00065ED4 File Offset: 0x00063AD4
		public override short C6A6922C()
		{
			uint num = 3264671131U;
			11AE0F91.80068AA5 80068AA = this.35B55287;
			num %= 4011039379U;
			return 80068AA.C6A6922C();
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00065F64 File Offset: 0x00063B64
		public override long D20998B6()
		{
			uint num = 3248231103U;
			num = 716493589U / num;
			11AE0F91.80068AA5 80068AA = this.35B55287;
			num = 430580399U + num;
			return 80068AA.D20998B6();
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00065DF8 File Offset: 0x000639F8
		public override object D697DB31()
		{
			uint num = 3867322410U;
			num ^= 2987121342U;
			return this.BD9B73B9;
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00065F94 File Offset: 0x00063B94
		public override ulong 6D84E72D()
		{
			return this.35B55287.6D84E72D();
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00065E84 File Offset: 0x00063A84
		public override byte B508A9AB()
		{
			uint num = 2240151969U;
			11AE0F91.80068AA5 80068AA = this.35B55287;
			num *= 34808851U;
			return 80068AA.B508A9AB();
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00065C90 File Offset: 0x00063890
		private static 11AE0F91.80068AA5 BD383D3E(Enum 4B3A7DA3)
		{
			uint num = 270304673U;
			if (num <= 3364940603U)
			{
				goto IL_11;
			}
			TypeCode typeCode;
			for (;;)
			{
				IL_26:
				int num2 = typeCode - ((int)num + (TypeCode)(-292886865));
				num -= 2659246867U;
				switch (num2)
				{
				case 0:
				case 2:
				case 4:
					num ^= 3331016833U;
					if (num > 1789336192U)
					{
						goto Block_3;
					}
					continue;
				case 1:
				case 3:
				case 5:
					goto IL_6C;
				case 6:
					goto IL_EB;
				case 7:
					goto IL_C3;
				}
				break;
			}
			if (num == 513227402U)
			{
				goto IL_6C;
			}
			IL_67:
			throw new InvalidOperationException();
			IL_6C:
			if (3123519522U + num != 0U)
			{
				num &= 1787930538U;
				int e99A = (int)Convert.ToUInt32(4B3A7DA3);
				num &= 1453349800U;
				return new 11AE0F91.CB943E91(e99A);
			}
			goto IL_67;
			Block_3:
			num = (2359013439U & num);
			int e99A2 = Convert.ToInt32(4B3A7DA3);
			num = 1605376690U / num;
			return new 11AE0F91.CB943E91(e99A2);
			IL_C3:
			num = 1042418721U * num;
			if ((3121553316U & num) != 0U)
			{
				long d1A1852C = (long)Convert.ToUInt64(4B3A7DA3);
				num *= 774294929U;
				return new 11AE0F91.6A9A2996(d1A1852C);
			}
			goto IL_11;
			IL_EB:
			if (1327617415U + num != 0U)
			{
				num = 1908326969U * num;
				return new 11AE0F91.6A9A2996(Convert.ToInt64(4B3A7DA3));
			}
			IL_11:
			typeCode = 4B3A7DA3.GetTypeCode();
			num = 146443435U << (int)num;
			goto IL_26;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00065EAC File Offset: 0x00063AAC
		public override sbyte 482F2014()
		{
			uint num = 1454650917U;
			11AE0F91.80068AA5 80068AA = this.35B55287;
			num = 369831556U / num;
			return 80068AA.482F2014();
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00065DD8 File Offset: 0x000639D8
		public override 11AE0F91.80068AA5 ECAA59A1()
		{
			return new 11AE0F91.29057C93(this.BD9B73B9);
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00065BFC File Offset: 0x000637FC
		public 29057C93(Enum F7A98F38)
		{
			uint num = 1234871100U;
			base..ctor();
			num |= 935315213U;
			while (F7A98F38 == null)
			{
				if (2837245625U > num)
				{
					throw new ArgumentException();
				}
			}
			num |= 1964998316U;
			if ((196757534U ^ num) != 0U)
			{
				num = (3901247409U & num);
				num <<= 3;
				this.BD9B73B9 = F7A98F38;
			}
			num %= 4018959379U;
			num += 3389258753U;
			Enum bd9B73B = this.BD9B73B9;
			num = 3030370103U + num;
			11AE0F91.80068AA5 80068AA = 11AE0F91.29057C93.BD383D3E(bd9B73B);
			num >>= 0;
			this.35B55287 = 80068AA;
		}

		// Token: 0x0400012E RID: 302
		private 11AE0F91.80068AA5 35B55287;

		// Token: 0x0400012F RID: 303
		private Enum BD9B73B9;
	}

	// Token: 0x02000088 RID: 136
	private enum 2A15CE18
	{
		// Token: 0x04000130 RID: 304
		F003ACB5 = 9,
		// Token: 0x04000131 RID: 305
		BB938B8F = 2,
		// Token: 0x04000132 RID: 306
		40257C89 = 5,
		// Token: 0x04000133 RID: 307
		7282FA8A = 3,
		// Token: 0x04000134 RID: 308
		518AEC86,
		// Token: 0x04000135 RID: 309
		403943BE = 10,
		// Token: 0x04000136 RID: 310
		BB8E2C38 = 32,
		// Token: 0x04000137 RID: 311
		40252A8A = 15,
		// Token: 0x04000138 RID: 312
		D0AFADA5 = 6,
		// Token: 0x04000139 RID: 313
		3182BD36 = 8,
		// Token: 0x0400013A RID: 314
		93847DA9 = 16,
		// Token: 0x0400013B RID: 315
		F68C7D06 = 0,
		// Token: 0x0400013C RID: 316
		4680BDBF = 11,
		// Token: 0x0400013D RID: 317
		B729AB1B = 64,
		// Token: 0x0400013E RID: 318
		9F283E97 = 7,
		// Token: 0x0400013F RID: 319
		A1B3AF05 = 1
	}

	// Token: 0x0200008A RID: 138
	private sealed class 628F1DA3
	{
		// Token: 0x06000297 RID: 663 RVA: 0x00066AF4 File Offset: 0x000646F4
		public int 1393F713()
		{
			return this.4F8CA3AC;
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00066AE0 File Offset: 0x000646E0
		public byte DB0E7732()
		{
			return this.DF352EB2;
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00066B10 File Offset: 0x00064710
		public int BF1FDE10()
		{
			return this.970F3ABE;
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00066AA4 File Offset: 0x000646A4
		public 628F1DA3(byte C497779B, int D1BD8F01, int 1D36FC35)
		{
			uint num;
			do
			{
				base..ctor();
				this.DF352EB2 = C497779B;
				num = 1267113879U;
				this.4F8CA3AC = D1BD8F01;
			}
			while (759115781U % num == 0U);
			this.970F3ABE = 1D36FC35;
		}

		// Token: 0x04000141 RID: 321
		private int 970F3ABE;

		// Token: 0x04000142 RID: 322
		private int 4F8CA3AC;

		// Token: 0x04000143 RID: 323
		private byte DF352EB2;
	}

	// Token: 0x02000091 RID: 145
	private sealed class F5AFA222 : 11AE0F91.80068AA5
	{
		// Token: 0x060002A4 RID: 676 RVA: 0x00063284 File Offset: 0x00060E84
		public override void 7E869424(object 8C177019)
		{
			uint num;
			do
			{
				num = 3407324699U;
				bool c620FEB = Convert.ToBoolean(8C177019);
				num &= 3993339917U;
				this.C620FEB0 = c620FEB;
			}
			while (num << 21 == 0U);
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00063254 File Offset: 0x00060E54
		public override object D697DB31()
		{
			uint num = 305391790U;
			num /= 3577625749U;
			bool c620FEB = this.C620FEB0;
			num = 1830816281U * num;
			return c620FEB;
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0006320C File Offset: 0x00060E0C
		public override Type 20129380()
		{
			return typeof(bool);
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x000632B8 File Offset: 0x00060EB8
		public override 11AE0F91.6012BE05 04A04CBD()
		{
			return new 11AE0F91.CB943E91(this.30B7A98C());
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x000632D8 File Offset: 0x00060ED8
		public override int 30B7A98C()
		{
			uint num = 890173112U;
			if (!this.C620FEB0)
			{
				num -= 1395886471U;
				return (int)(num ^ 3789253937U);
			}
			num = 2761244837U - num;
			return (int)(num ^ 1871071724U);
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x0006322C File Offset: 0x00060E2C
		public override 11AE0F91.80068AA5 ECAA59A1()
		{
			uint num = 3761599658U;
			bool c620FEB = this.C620FEB0;
			num >>= 18;
			return new 11AE0F91.F5AFA222(c620FEB);
		}

		// Token: 0x060002AA RID: 682 RVA: 0x000631C8 File Offset: 0x00060DC8
		public F5AFA222(bool AB3A521B)
		{
			uint num = 3264200239U;
			num %= 813830716U;
			base..ctor();
			num = 3661210169U - num;
			do
			{
				this.C620FEB0 = AB3A521B;
			}
			while (-1423234419 << (int)num == 0);
		}

		// Token: 0x04000144 RID: 324
		private bool C620FEB0;
	}

	// Token: 0x02000098 RID: 152
	private sealed class 2DBFD518 : 11AE0F91.FCB842B2
	{
		// Token: 0x060002B5 RID: 693 RVA: 0x00064B18 File Offset: 0x00062718
		public override 11AE0F91.80068AA5 ECAA59A1()
		{
			11AE0F91.80068AA5 bd9C = this.BD9C4013;
			uint num = 2551578887U;
			num |= 3702412215U;
			return new 11AE0F91.2DBFD518(bd9C, this.160E5D21);
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00064B64 File Offset: 0x00062764
		public override void 7E869424(object 1B817BA2)
		{
			11AE0F91.80068AA5 bd9C = this.BD9C4013;
			uint num = 3367785912U;
			bd9C.7E869424(1B817BA2);
			num = 389883665U % num;
			if ((num ^ 1100914974U) != 0U)
			{
				11AE0F91.80068AA5 80068AA = this.160E5D21;
				object 9590F = this.BD9C4013.D697DB31();
				num = (3758361109U & num);
				80068AA.7E869424(9590F);
			}
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00064B44 File Offset: 0x00062744
		public override object D697DB31()
		{
			return this.BD9C4013.D697DB31();
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00064B00 File Offset: 0x00062700
		public override Type 20129380()
		{
			return this.BD9C4013.20129380();
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00064ABC File Offset: 0x000626BC
		public 2DBFD518(11AE0F91.80068AA5 A23F9F15, 11AE0F91.80068AA5 3221CAA5)
		{
			uint num = 2317472572U;
			base..ctor();
			num = (3744051507U | num);
			num %= 3314401942U;
			this.BD9C4013 = A23F9F15;
			do
			{
				this.160E5D21 = 3221CAA5;
			}
			while (1502859406U < num);
		}

		// Token: 0x04000147 RID: 327
		private 11AE0F91.80068AA5 160E5D21;

		// Token: 0x04000148 RID: 328
		private 11AE0F91.80068AA5 BD9C4013;
	}

	// Token: 0x020000BA RID: 186
	private sealed class 7621E502 : 11AE0F91.6012BE05
	{
		// Token: 0x0600035E RID: 862 RVA: 0x00061F7C File Offset: 0x0005FB7C
		public override IntPtr D20542BB()
		{
			uint num2;
			long value;
			if (IntPtr.Size != 4)
			{
				long num = (long)this.3C3C8A0C;
				num2 = 3493197087U;
				value = num;
			}
			else
			{
				num2 = 3070898483U;
				int num3 = (int)this.3C3C8A0C;
				num2 >>= 2;
				value = (long)num3;
				num2 += 2725472467U;
			}
			num2 <<= 19;
			return new IntPtr(value);
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00062260 File Offset: 0x0005FE60
		public static 11AE0F91.80068AA5 77AB949A(11AE0F91.80068AA5 B488EEAD)
		{
			uint num = 1193892618U;
			if (1310848773U <= num)
			{
				goto IL_6E;
			}
			ulong num3;
			do
			{
				num += 505192104U;
				ulong num2 = B488EEAD.6D84E72D();
				num /= 3190668828U;
				num3 = num2;
			}
			while (101630267U <= num);
			IL_33:
			uint num4 = (uint)B488EEAD.3BA55C01();
			uint num5 = num + 4U;
			num >>= 16;
			bool flag = (num4 & num5) > (num ^ 0U);
			num -= 1830716170U;
			float 76BAFC;
			if (!flag)
			{
				num = 958140198U / num;
				76BAFC = (float)num3;
				goto IL_9C;
			}
			IL_6E:
			num &= 4043414415U;
			if (num == 4069431588U)
			{
				goto IL_33;
			}
			ulong num6 = num3;
			num = 2326626306U * num;
			float num7 = num6;
			num <<= 26;
			76BAFC = num7;
			num ^= 805306368U;
			IL_9C:
			num = (3725609382U | num);
			return new 11AE0F91.7621E502(76BAFC);
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00061E54 File Offset: 0x0005FA54
		public override short C6A6922C()
		{
			uint num = 3131688577U;
			short num2 = (short)this.3C3C8A0C;
			num <<= 18;
			return num2;
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00062118 File Offset: 0x0005FD18
		public static 11AE0F91.80068AA5 45966726(11AE0F91.80068AA5 9FAB5F09, 11AE0F91.80068AA5 1DB77709)
		{
			uint num = 1015122067U;
			float num2 = 9FAB5F09.599106A4();
			num += 1798849923U;
			num |= 3993319103U;
			float num3 = 1DB77709.599106A4();
			num = 898342708U << (int)num;
			float num4 = num3;
			num = (4062097050U | num);
			return new 11AE0F91.7621E502(num2 % num4);
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00061ECC File Offset: 0x0005FACC
		public override byte B508A9AB()
		{
			uint num = 882684050U;
			byte b = (byte)this.3C3C8A0C;
			num = (2510430379U | num);
			return b;
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00061D84 File Offset: 0x0005F984
		public override 11AE0F91.80068AA5 ECAA59A1()
		{
			uint num = 2872831117U;
			num -= 825066007U;
			return new 11AE0F91.7621E502(this.3C3C8A0C);
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00062090 File Offset: 0x0005FC90
		public static 11AE0F91.80068AA5 DF333B1F(11AE0F91.80068AA5 EC83BAA1, 11AE0F91.80068AA5 DAA7143A)
		{
			uint num = 1443294266U;
			num &= 1317495945U;
			float num2 = EC83BAA1.599106A4();
			num >>= 18;
			float num3 = DAA7143A.599106A4();
			float 76BAFC = num2 / num3;
			num = (2249226286U & num);
			return new 11AE0F91.7621E502(76BAFC);
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00061E78 File Offset: 0x0005FA78
		public override int 30B7A98C()
		{
			return (int)this.3C3C8A0C;
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00061DDC File Offset: 0x0005F9DC
		public override void 7E869424(object 56AE681D)
		{
			uint num = 2634066459U;
			do
			{
				num %= 749133062U;
				this.3C3C8A0C = Convert.ToSingle(56AE681D);
			}
			while (num == 3417565215U);
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00061D64 File Offset: 0x0005F964
		public override Type 20129380()
		{
			return typeof(float);
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00062168 File Offset: 0x0005FD68
		public static 11AE0F91.80068AA5 C523BC0D(11AE0F91.80068AA5 0D911CBC)
		{
			uint num = 3409167020U;
			float num2 = 0D911CBC.599106A4();
			num *= 763489321U;
			float 76BAFC = -num2;
			num *= 2174531768U;
			return new 11AE0F91.7621E502(76BAFC);
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00061FD4 File Offset: 0x0005FBD4
		public override UIntPtr 0E10D236()
		{
			uint num;
			for (;;)
			{
				uint size = (uint)IntPtr.Size;
				num = 4206787244U;
				if (size != num - 4206787240U && (num & 531261316U) != 0U)
				{
					break;
				}
				num ^= 228135862U;
				if (2796012067U / num == 0U)
				{
					goto Block_2;
				}
			}
			num = 2727005339U * num;
			ulong num2 = (ulong)this.3C3C8A0C;
			num = (707230251U & num);
			ulong value = num2;
			goto IL_71;
			Block_2:
			ulong num3 = (ulong)((uint)this.3C3C8A0C);
			num = 3862379812U >> (int)num;
			value = num3;
			num ^= 33903129U;
			IL_71:
			return new UIntPtr(value);
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00062198 File Offset: 0x0005FD98
		public static 11AE0F91.80068AA5 8A95E515(11AE0F91.80068AA5 E43088BA, 11AE0F91.80068AA5 42AD44A7)
		{
			uint num = 3803000345U;
			int num5;
			for (;;)
			{
				num -= 2391259026U;
				float num2 = E43088BA.599106A4();
				num ^= 2032971449U;
				float num3 = num2;
				num <<= 13;
				float num4 = 42AD44A7.599106A4();
				num = 2411606672U * num;
				num5 = (int)(num - 937164800U);
				float num6 = num3;
				num >>= 16;
				if (num6 == num4)
				{
					num = 1603253423U - num;
					num5 |= (int)(num ^ 1603239122U);
					if (1947951920U * num != 0U)
					{
						break;
					}
				}
				float num7 = num3;
				float num8 = num4;
				num += 1603224823U;
				if (num7 >= num8)
				{
					break;
				}
				if (num % 1938248085U != 0U)
				{
					goto Block_4;
				}
			}
			goto IL_A3;
			Block_4:
			int num9 = num5;
			int num10 = (int)(num ^ 1603239131U);
			num = 3384353435U + num;
			num5 = (num9 | num10);
			num ^= 1992811453U;
			IL_A3:
			num = (1065555859U ^ num);
			int e99A = num5;
			num /= 1083033904U;
			return new 11AE0F91.CB943E91(e99A);
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00061F0C File Offset: 0x0005FB0C
		public override uint 98A2A683()
		{
			return (uint)this.3C3C8A0C;
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00061DAC File Offset: 0x0005F9AC
		public override object D697DB31()
		{
			uint num = 2075315853U;
			num -= 3568716209U;
			float num2 = this.3C3C8A0C;
			num = (3753438484U | num);
			return num2;
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00061EA8 File Offset: 0x0005FAA8
		public override char 8EBDB806()
		{
			uint num = 3626854689U;
			num = 1287618365U + num;
			return (char)this.3C3C8A0C;
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00061EF0 File Offset: 0x0005FAF0
		public override ushort CF9960A3()
		{
			return (ushort)this.3C3C8A0C;
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00061F28 File Offset: 0x0005FB28
		public override ulong 6D84E72D()
		{
			return (ulong)this.3C3C8A0C;
		}

		// Token: 0x06000370 RID: 880 RVA: 0x000620D0 File Offset: 0x0005FCD0
		public static 11AE0F91.80068AA5 072E5F9D(11AE0F91.80068AA5 49958327, 11AE0F91.80068AA5 1F28B7BB)
		{
			uint num = 3307246982U;
			num = (679487243U ^ num);
			float num2 = 49958327.599106A4();
			num = 100707849U >> (int)num;
			float num3 = 1F28B7BB.599106A4();
			float num4 = num3;
			num = (2309797047U ^ num);
			return new 11AE0F91.7621E502(num2 / num4);
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00061F44 File Offset: 0x0005FB44
		public override float 599106A4()
		{
			return this.3C3C8A0C;
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00061E94 File Offset: 0x0005FA94
		public override long D20998B6()
		{
			return (long)this.3C3C8A0C;
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00061F60 File Offset: 0x0005FB60
		public override double DD227D0D()
		{
			return (double)this.3C3C8A0C;
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00062058 File Offset: 0x0005FC58
		public static 11AE0F91.80068AA5 790434B9(11AE0F91.80068AA5 2B2EEDA5, 11AE0F91.80068AA5 B5B55214)
		{
			uint num = 1981003026U;
			float num2 = 2B2EEDA5.599106A4();
			num = 3266057381U + num;
			float num3 = B5B55214.599106A4();
			float num4 = num3;
			num = (136019084U & num);
			return new 11AE0F91.7621E502(num2 + num4);
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00061E10 File Offset: 0x0005FA10
		public override bool 2206A10D()
		{
			uint num = 4272505015U;
			float value = this.3C3C8A0C;
			num &= 537163029U;
			return Convert.ToBoolean(value);
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00061E38 File Offset: 0x0005FA38
		public override sbyte 482F2014()
		{
			return (sbyte)this.3C3C8A0C;
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00062318 File Offset: 0x0005FF18
		public static 11AE0F91.80068AA5 572C9C80(11AE0F91.80068AA5 FD2D9929)
		{
			uint num = 1077629473U;
			float 76BAFC = FD2D9929.599106A4();
			num -= 220057019U;
			return new 11AE0F91.7621E502(76BAFC);
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00061D28 File Offset: 0x0005F928
		public 7621E502(float 76BAFC03)
		{
			uint num;
			do
			{
				num = 2956578463U;
				base..ctor();
				num = (958906785U ^ num);
			}
			while (967966734U >= num);
			num = 2561706269U % num;
			this.3C3C8A0C = 76BAFC03;
		}

		// Token: 0x04000157 RID: 343
		private float 3C3C8A0C;
	}

	// Token: 0x020000C0 RID: 192
	private sealed class 6A9A2996 : 11AE0F91.6012BE05
	{
		// Token: 0x06000383 RID: 899 RVA: 0x00060E40 File Offset: 0x0005EA40
		public override ushort CF9960A3()
		{
			return (ushort)this.A498D886;
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00060DF4 File Offset: 0x0005E9F4
		public override int 30B7A98C()
		{
			uint num = 825882886U;
			num /= 3266705180U;
			return (int)this.A498D886;
		}

		// Token: 0x06000385 RID: 901 RVA: 0x00060DB4 File Offset: 0x0005E9B4
		public override sbyte 482F2014()
		{
			uint num = 197130124U;
			num = 1799049737U + num;
			return (sbyte)this.A498D886;
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00060E70 File Offset: 0x0005EA70
		public override ulong 6D84E72D()
		{
			return (ulong)this.A498D886;
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00060DA0 File Offset: 0x0005E9A0
		public override byte B508A9AB()
		{
			return (byte)this.A498D886;
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00060EA0 File Offset: 0x0005EAA0
		public override double DD227D0D()
		{
			return (double)this.A498D886;
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00061A94 File Offset: 0x0005F694
		public static 11AE0F91.80068AA5 1E2BD10B(11AE0F91.80068AA5 D70FBB80, 11AE0F91.80068AA5 11344B3D)
		{
			uint num;
			int num3;
			for (;;)
			{
				IL_00:
				num = 750033930U;
				int num2 = (int)(num ^ 750033930U);
				num = 2133765123U % num;
				num3 = num2;
				num %= 3699611563U;
				long num16;
				long num18;
				for (;;)
				{
					IL_25:
					num %= 3559748497U;
					uint num4 = (uint)11344B3D.3BA55C01();
					uint num5 = num - 633697259U;
					num <<= 8;
					if ((num4 & num5) > (num ^ 3312709376U))
					{
						num <<= 14;
						if ((2525572763U & num) == 0U)
						{
							goto IL_00;
						}
						num |= 178665366U;
						ulong num6 = D70FBB80.6D84E72D();
						num -= 1057978774U;
						ulong num7 = num6;
						for (;;)
						{
							ulong num8 = 11344B3D.6D84E72D();
							num %= 2495524760U;
							if (4130024086U == num)
							{
								goto IL_25;
							}
							for (;;)
							{
								ulong num9 = num7;
								num = (4246380605U & num);
								if (num9 == num8)
								{
									break;
								}
								if ((num & 3096154275U) != 0U)
								{
									goto Block_5;
								}
							}
							if (1501872918U > num)
							{
								break;
							}
							continue;
							Block_5:
							ulong num10 = num7;
							num = (3434115093U & num);
							ulong num11 = num8;
							num += 2415647760U;
							if (num10 >= num11)
							{
								goto IL_265;
							}
							num = 1932252425U % num;
							int num12 = num3;
							num %= 3375557806U;
							int num13 = (int)(num ^ 1932252417U);
							num ^= 1857374091U;
							num3 = (num12 | num13);
							if (1470576521U >= num)
							{
								goto Block_7;
							}
						}
						int num14 = num3;
						num = 1955061645U + num;
						int num15 = (int)(num ^ 2627723188U);
						num = (4211858448U & num);
						num3 = (num14 | num15);
						if (2492537236U >> (int)num != 0U)
						{
							goto Block_4;
						}
					}
					else
					{
						if (num <= 2813392297U)
						{
							goto IL_00;
						}
						num >>= 4;
						num16 = D70FBB80.D20998B6();
						num = 1855076269U - num;
						num = (129486117U | num);
						long num17 = 11344B3D.D20998B6();
						num = (1404140585U ^ num);
						num18 = num17;
						num ^= 1327608358U;
						if (num >= 3768028041U)
						{
							goto IL_00;
						}
						long num19 = num16;
						num |= 1477841439U;
						if (num19 != num18)
						{
							goto IL_21D;
						}
						num = 4088885910U % num;
						if (4280150297U + num != 0U)
						{
							break;
						}
					}
				}
				int num20 = num3;
				int num21 = (int)(num ^ 2021146326U);
				num = 4072145081U * num;
				num3 = (num20 | num21);
				if (num % 900348324U != 0U)
				{
					goto Block_12;
				}
				continue;
				IL_21D:
				num = 3122437407U - num;
				long num22 = num16;
				long num23 = num18;
				num += 1496216240U;
				if (num22 >= num23)
				{
					break;
				}
				if (num >= 1024537135U)
				{
					goto Block_14;
				}
			}
			Block_4:
			goto IL_265;
			Block_7:
			num ^= 2241154706U;
			goto IL_265;
			Block_12:
			num ^= 4016485711U;
			goto IL_265;
			Block_14:
			int num24 = num3 | (int)(num - 2550914056U);
			num |= 2343944748U;
			num3 = num24;
			num += 4232838612U;
			IL_265:
			return new 11AE0F91.CB943E91(num3);
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00060F80 File Offset: 0x0005EB80
		public static 11AE0F91.80068AA5 1126E12A(11AE0F91.80068AA5 EBB2F293, 11AE0F91.80068AA5 3D2F802E)
		{
			uint num = 3557239308U;
			11AE0F91.6A9A2996 6A9A2;
			if (221420471U != num)
			{
				num *= 2852872231U;
				ulong num2 = EBB2F293.6D84E72D();
				num = 2184098219U + num;
				ulong num3 = 3D2F802E.6D84E72D();
				num <<= 20;
				num = 1813916463U * num;
				ulong num4 = num3;
				num = 3121663635U << (int)num;
				ulong num5 = num2 + num4;
				num = 4012622000U + num;
				ulong num6 = num5;
				long d1A1852C = (long)num6;
				num &= 1863860767U;
				11AE0F91.6A9A2996 6A9A = new 11AE0F91.6A9A2996(d1A1852C);
				num %= 1529783081U;
				6A9A2 = 6A9A;
				num *= 253883682U;
				int num7 = (int)(num + 562027674U);
				num = (723712653U ^ num);
				uint num8 = num - 1973606891U;
				num = 1570260539U >> (int)num;
				uint num9 = num8;
				num %= 2006391303U;
				bool flag = (num2 ^ num6) != 0UL;
				bool flag2 = num3 != 0UL;
				num = 1688629152U + num;
				bool flag3 = ((flag ? 1UL : 0UL) & ((flag2 ? 1UL : 0UL) ^ num6)) != 0UL;
				num = 3425216665U - num;
				bool flag4 = ((flag3 ? 1UL : 0UL) & (ulong)num9) != 0UL;
				num |= 1279173915U;
				if (flag4)
				{
					num *= 503765257U;
					int num10 = num7;
					num /= 638851382U;
					int num11 = (int)(num ^ 19U);
					num >>= 29;
					int num12 = num10 | num11;
					num %= 2978509982U;
					num7 = num12;
					num += 1870571003U;
				}
				num |= 2743186817U;
				bool flag5 = (num2 ^ num3) != 0UL;
				num ^= 2894432655U;
				bool flag6 = ((flag5 ? 1UL : 0UL) & (num3 ^ num6)) != 0UL;
				num += 1916344983U;
				bool flag7 = (num2 ^ (flag6 ? 1UL : 0UL)) != 0UL;
				num /= 906518818U;
				ulong num13 = (ulong)num9;
				num ^= 3499135876U;
				bool flag8 = ((flag7 ? 1UL : 0UL) & num13) != 0UL;
				num ^= 3976358677U;
				if (!flag8)
				{
					goto IL_173;
				}
				num = (522557718U | num);
				if (num == 196932752U)
				{
					return 6A9A2;
				}
				IL_157:
				int num14 = num7;
				int num15 = (int)(num - 1069021526U);
				num %= 2248554146U;
				num7 = (num14 | num15);
				num += 4258987772U;
				IL_173:
				num <<= 5;
				11AE0F91.80068AA5 80068AA = 6A9A2;
				num = (2022469433U ^ num);
				int c7A9131D = num7;
				num += 2710147585U;
				80068AA.3F831A1B(c7A9131D);
				num ^= 412712631U;
				if (682883352U > num)
				{
					goto IL_157;
				}
			}
			return 6A9A2;
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00060D18 File Offset: 0x0005E918
		public override object D697DB31()
		{
			return this.A498D886;
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00060D38 File Offset: 0x0005E938
		public override void 7E869424(object 23B6AC84)
		{
			this.A498D886 = Convert.ToInt64(23B6AC84);
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00060CA0 File Offset: 0x0005E8A0
		public override Type 20129380()
		{
			uint num = 3735352737U;
			RuntimeTypeHandle handle = typeof(long).TypeHandle;
			num >>= 20;
			return Type.GetTypeFromHandle(handle);
		}

		// Token: 0x0600038E RID: 910 RVA: 0x00060F00 File Offset: 0x0005EB00
		public override UIntPtr 0E10D236()
		{
			uint num = 128874388U;
			for (;;)
			{
				int size = UIntPtr.Size;
				num *= 3064905477U;
				uint num2 = num + 801652256U;
				num = 1988416269U - num;
				if (size != num2)
				{
					break;
				}
				if (3095850140U != num)
				{
					goto Block_2;
				}
			}
			ulong value = (ulong)this.A498D886;
			goto IL_65;
			Block_2:
			num = (471724721U ^ num);
			uint a498D = (uint)this.A498D886;
			num *= 588092953U;
			ulong num3 = (ulong)a498D;
			num = 288550920U - num;
			value = num3;
			num ^= 2239018777U;
			IL_65:
			num = (3962858531U | num);
			return new UIntPtr(value);
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00060EBC File Offset: 0x0005EABC
		public override IntPtr D20542BB()
		{
			long value;
			if (IntPtr.Size != 4)
			{
				value = this.A498D886;
			}
			else
			{
				uint num = 3265105184U;
				value = (long)((int)this.A498D886);
				num ^= 2075440153U;
			}
			return new IntPtr(value);
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00061640 File Offset: 0x0005F240
		public static 11AE0F91.80068AA5 8232AF01(11AE0F91.80068AA5 D029432B, 11AE0F91.80068AA5 251F0003)
		{
			uint num = 2073892763U;
			uint num2 = (uint)(251F0003.3BA55C01() & (int)(num - 2073892759U));
			num = 1832041918U % num;
			bool flag = num2 > num + 2462925378U;
			num /= 4127383202U;
			if (!flag && 1387971342 << (int)num != 0)
			{
				long num3 = D029432B.D20998B6();
				num <<= 10;
				long num4 = 251F0003.D20998B6();
				num %= 3573831976U;
				long num5 = num4;
				long d1A1852C = num3 % num5;
				num >>= 16;
				return new 11AE0F91.6A9A2996(d1A1852C);
			}
			num = 1127030305U << (int)num;
			long num6 = (long)D029432B.6D84E72D();
			num = 303428130U + num;
			num >>= 18;
			ulong num7 = 251F0003.6D84E72D();
			num /= 851159188U;
			long d1A1852C2 = num6 % (long)num7;
			num %= 4189930174U;
			return new 11AE0F91.6A9A2996(d1A1852C2);
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00060DD8 File Offset: 0x0005E9D8
		public override short C6A6922C()
		{
			return (short)this.A498D886;
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00060D54 File Offset: 0x0005E954
		public override bool 2206A10D()
		{
			return this.A498D886 != 0L;
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00061540 File Offset: 0x0005F140
		public static 11AE0F91.80068AA5 D29D5A89(11AE0F91.80068AA5 E6B2ED2E, 11AE0F91.80068AA5 C0991E9F)
		{
			uint num = 2787600026U;
			for (;;)
			{
				num >>= 30;
				int num2 = C0991E9F.3BA55C01();
				num -= 1678744369U;
				uint num3 = num + 1678744371U;
				num = 1714246463U >> (int)num;
				object obj = num2 & (int)num3;
				num *= 1217154694U;
				uint num4 = num ^ 800289156U;
				num -= 2678223144U;
				if (obj > num4)
				{
					if (num < 3886448945U)
					{
						break;
					}
				}
				else if (3903650215U > num)
				{
					goto Block_2;
				}
			}
			IL_5B:
			long num5 = (long)E6B2ED2E.6D84E72D();
			num %= 2829208383U;
			ulong num6 = C0991E9F.6D84E72D();
			num = 3960214326U >> (int)num;
			ulong num7 = num6;
			num = (356453506U & num);
			long num8 = (long)num7;
			num >>= 1;
			long num9 = num5 / num8;
			goto IL_D1;
			Block_2:
			long num10 = E6B2ED2E.D20998B6();
			num = 2114467622U / num;
			long num11 = C0991E9F.D20998B6();
			num <<= 22;
			long num12 = num11;
			long num13 = num10 / num12;
			num = 1949730238U - num;
			num9 = num13;
			num += 2345237059U;
			IL_D1:
			if (num < 3375976579U)
			{
				long d1A1852C = num9;
				num = 1757216939U >> (int)num;
				return new 11AE0F91.6A9A2996(d1A1852C);
			}
			goto IL_5B;
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00060E5C File Offset: 0x0005EA5C
		public override uint 98A2A683()
		{
			return (uint)this.A498D886;
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00060E84 File Offset: 0x0005EA84
		public override float 599106A4()
		{
			return (float)this.A498D886;
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00061700 File Offset: 0x0005F300
		public static 11AE0F91.80068AA5 05197C0C(11AE0F91.80068AA5 263CD430, 11AE0F91.80068AA5 93BE21A5)
		{
			11AE0F91.6A9A2996 6A9A2;
			for (;;)
			{
				IL_00:
				ulong num = 263CD430.6D84E72D();
				uint num2 = 1564086319U;
				ulong num3 = ~num;
				num2 = (2407612175U & num2);
				ulong num4 = ~93BE21A5.6D84E72D();
				num2 = 2636213024U * num2;
				ulong num5 = num4;
				num2 = 1553065740U + num2;
				ulong num6 = num3 & num5;
				int num8;
				for (;;)
				{
					11AE0F91.6A9A2996 6A9A = new 11AE0F91.6A9A2996((long)num6);
					num2 ^= 3885018632U;
					6A9A2 = 6A9A;
					num2 >>= 5;
					int num7 = (int)(num2 ^ 92097567U);
					num2 = 226703669U + num2;
					num8 = num7;
					num2 >>= 29;
					bool flag = num6 != 0UL;
					num2 = (2956492206U ^ num2);
					if (!flag)
					{
						int num9 = num8;
						int num10 = (int)(num2 ^ 2956492207U);
						num2 = 4269880116U % num2;
						num8 = (num9 | num10);
						if (3249329077U * num2 != 0U)
						{
							break;
						}
					}
					else
					{
						num2 = 3833815046U << (int)num2;
						if ((num2 ^ 2323831358U) == 0U)
						{
							goto IL_00;
						}
						bool flag2 = num6 >> (int)(num2 + 670990399U) != 0UL;
						num2 = (4060464031U | num2);
						num2 += 1413673447U;
						if (!flag2)
						{
							break;
						}
						if (2592575625U + num2 != 0U)
						{
							goto Block_4;
						}
					}
				}
				IL_118:
				11AE0F91.80068AA5 80068AA = 6A9A2;
				num2 += 4026919451U;
				int c7A9131D = num8;
				num2 *= 1234559900U;
				80068AA.3F831A1B(c7A9131D);
				num2 += 3844792754U;
				if (3601680827U >= num2)
				{
					break;
				}
				continue;
				goto IL_118;
				Block_4:
				int num11 = num8;
				num2 = 3090587058U >> (int)num2;
				num8 = (num11 | (int)(num2 - 48290414U));
				num2 ^= 1286107120U;
				goto IL_118;
			}
			return 6A9A2;
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00061D10 File Offset: 0x0005F910
		public static 11AE0F91.80068AA5 4E8DB1A3(11AE0F91.80068AA5 6E3F6614)
		{
			return new 11AE0F91.6A9A2996((long)6E3F6614.6D84E72D());
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00061858 File Offset: 0x0005F458
		public static 11AE0F91.80068AA5 C1BF27AF(11AE0F91.80068AA5 4C94F1BF, 11AE0F91.80068AA5 2B1C6131)
		{
			uint num2;
			ulong num7;
			11AE0F91.6A9A2996 6A9A2;
			int num8;
			for (;;)
			{
				IL_00:
				ulong num = 4C94F1BF.6D84E72D();
				num2 = 2512282418U;
				ulong num3 = ~num;
				num2 = 2819469607U + num2;
				num2 %= 276824864U;
				ulong num4 = 2B1C6131.6D84E72D();
				num2 ^= 1587995674U;
				ulong num5 = ~num4;
				num2 -= 2273952317U;
				ulong num6 = num5;
				num7 = (num3 | num6);
				for (;;)
				{
					11AE0F91.6A9A2996 6A9A = new 11AE0F91.6A9A2996((long)num7);
					num2 = 1996965151U + num2;
					6A9A2 = 6A9A;
					for (;;)
					{
						num8 = (int)(num2 - 1114141125U);
						bool flag = num7 != 0UL;
						num2 <<= 28;
						if (flag)
						{
							break;
						}
						num2 /= 414700845U;
						if (2478298901U % num2 == 0U)
						{
							goto IL_00;
						}
						num8 |= (int)(num2 ^ 2U);
						if (num2 >> 22 == 0U)
						{
							goto IL_9A;
						}
					}
					if (2760240442U % num2 != 0U)
					{
						goto Block_2;
					}
				}
			}
			IL_9A:
			goto IL_F8;
			Block_2:
			ulong num9 = num7;
			num2 = 2290141748U / num2;
			bool flag2 = num9 >> (int)(num2 - 4294967234U);
			num2 ^= 2U;
			if (flag2)
			{
				int num10 = num8;
				int num11 = (int)(num2 + 5U);
				num2 -= 3549992611U;
				int num12 = num10 | num11;
				num2 += 3205844383U;
				num8 = num12;
				num2 ^= 3950819068U;
			}
			IL_F8:
			num2 -= 3675825697U;
			11AE0F91.80068AA5 80068AA = 6A9A2;
			num2 ^= 2794772505U;
			int c7A9131D = num8;
			num2 = (3224280630U & num2);
			80068AA.3F831A1B(c7A9131D);
			if (1251306682U != num2)
			{
				return 6A9A2;
			}
			goto IL_9A;
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00060CC8 File Offset: 0x0005E8C8
		public override 11AE0F91.80068AA5 ECAA59A1()
		{
			uint num = 503336465U;
			long a498D = this.A498D886;
			num = 2670776196U / num;
			11AE0F91.6A9A2996 6A9A = new 11AE0F91.6A9A2996(a498D);
			num *= 3862545700U;
			num = 2419724160U << (int)num;
			num = 883986954U + num;
			6A9A.3F831A1B(this.3BA55C01());
			return 6A9A;
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00061A3C File Offset: 0x0005F63C
		public static 11AE0F91.80068AA5 BF22DEA6(11AE0F91.80068AA5 8B0D512D, 11AE0F91.80068AA5 47822F0A)
		{
			uint num = 1337449367U;
			num = (3642979333U | num);
			long num2 = 8B0D512D.D20998B6();
			num = 4030533567U - num;
			int num3 = 47822F0A.30B7A98C();
			num %= 3196951578U;
			int num4 = num3;
			int num5 = num4;
			num *= 3149684737U;
			int num6 = num5 & (int)(num ^ 200544279U);
			num = 2862783246U + num;
			return new 11AE0F91.6A9A2996(num2 << num6);
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00061134 File Offset: 0x0005ED34
		public static 11AE0F91.80068AA5 8C9F8D33(11AE0F91.80068AA5 618E0784, 11AE0F91.80068AA5 C03B5E8B)
		{
			uint num;
			11AE0F91.6A9A2996 6A9A2;
			int num9;
			for (;;)
			{
				IL_00:
				num = 3909299858U;
				ulong num2 = 618E0784.6D84E72D();
				num = 335827510U / num;
				if (2369773711U >= num)
				{
					for (;;)
					{
						ulong num3 = C03B5E8B.6D84E72D();
						num >>= 10;
						ulong num4 = num3;
						num += 2788720307U;
						if (num / 3423164184U != 0U)
						{
							goto IL_00;
						}
						ulong num5 = num2;
						num *= 573206806U;
						ulong num6 = num4;
						num *= 2022193082U;
						ulong num7 = num5 * num6;
						long d1A1852C = (long)num7;
						num = (1065839540U & num);
						11AE0F91.6A9A2996 6A9A = new 11AE0F91.6A9A2996(d1A1852C);
						num *= 1913143702U;
						6A9A2 = 6A9A;
						num = 406317465U % num;
						int num8 = (int)(num ^ 406317465U);
						num /= 3618128434U;
						num9 = num8;
						uint num10 = num ^ 2147483648U;
						num = 909573780U << (int)num;
						bool flag = num2 != 0UL;
						num ^= 1060886586U;
						bool flag2 = (((flag ? 1UL : 0UL) ^ num7) & (num4 ^ num7)) != 0UL;
						ulong num11 = (ulong)num10;
						num += 1168190007U;
						if (((flag2 ? 1UL : 0UL) & num11) != 0UL)
						{
							int num12 = num9;
							int num13 = (int)(num ^ 1320046837U);
							num ^= 3309044110U;
							num9 = (num12 | num13);
							num ^= 3309044110U;
						}
						num = 3733162291U >> (int)num;
						bool flag3 = num2 != 0UL;
						num *= 2400452762U;
						bool flag4 = num2 != 0UL;
						num &= 1510636843U;
						bool flag5 = num4 != 0UL;
						num = (2955996860U & num);
						bool flag6 = flag4 ^ flag5;
						bool flag7 = num4 != 0UL;
						bool flag8 = num7 != 0UL;
						num = (67168267U & num);
						bool flag9 = flag3 ^ (flag6 & (flag7 ^ flag8));
						ulong num14 = (ulong)num10;
						num += 1454837288U;
						if (((flag9 ? 1UL : 0UL) & num14) != 0UL)
						{
							int num15 = num9;
							int num16 = (int)(num ^ 1454837360U);
							num >>= 19;
							num9 = (num15 | num16);
							num ^= 1454834918U;
						}
						num = (2055592204U & num);
						int num17 = C03B5E8B.3BA55C01();
						uint num18 = num ^ 1384450052U;
						num = (1058713495U & num);
						object obj = num17 & (int)num18;
						num -= 1644819111U;
						uint num19 = num ^ 2952140121U;
						num |= 2350027934U;
						bool flag10 = obj > num19;
						num = (3523956159U ^ num);
						if (!flag10)
						{
							break;
						}
						ulong num20 = num2;
						num = 3197797288U / num;
						ulong num21 = (ulong)(num + 4294967294U);
						num = 1873078402U / num;
						ulong num22 = num20 & num21;
						if (394868657U / num == 0U)
						{
							ulong num23 = num2 >> (int)(num ^ 1873078434U);
							num = (3867668375U | num);
							ulong num24 = num23;
							num = (900407426U & num);
							if ((3425796749U & num) == 0U)
							{
								goto IL_00;
							}
							ulong num25 = num4;
							ulong num26 = (ulong)(num - 631447683U);
							num = (4177803444U | num);
							ulong num27 = num25 & num26;
							num = (1527273013U & num);
							if (12340407U / num != 0U)
							{
								goto IL_00;
							}
							ulong num28 = num4;
							num = (1384501515U ^ num);
							int num29 = (int)(num ^ 193315103U);
							num = (763482034U ^ num);
							ulong num30 = num28 >> num29;
							num = 490279211U * num;
							ulong num31 = num22;
							ulong num32 = num27;
							num = (607384704U ^ num);
							ulong num33 = num31 * num32;
							ulong num34 = num24 * num27;
							ulong num35 = num33;
							int num36 = (int)(num + 96912881U);
							num = (2349243282U | num);
							ulong num37 = num34 + (num35 >> num36);
							num = 2929097345U / num;
							num33 = num37;
							ulong num38 = num33;
							num /= 2493523774U;
							ulong num39 = (ulong)(num + uint.MaxValue);
							num *= 3493543983U;
							ulong num40 = num38 & num39;
							num |= 1461188281U;
							ulong num41 = num33;
							num = 3893166604U / num;
							ulong num42 = num41 >> (int)(num ^ 34U);
							ulong num43 = num22;
							num &= 3892590255U;
							ulong num44 = num40 + num43 * num30;
							num /= 120008863U;
							num33 = num44;
							ulong num45 = num42;
							ulong num46 = num24;
							num |= 3172070686U;
							ulong num47 = num46 * num30;
							num *= 2039271818U;
							ulong num48 = num45 + num47;
							num = 437755294U << (int)num;
							ulong num49 = num33;
							int num50 = (int)(num ^ 2044321824U);
							num %= 1176754111U;
							ulong num51 = num48 + (num49 >> num50);
							num ^= 4288905360U;
							num33 = num51;
							num = (2954327700U | num);
							if (2341701378U >= num)
							{
								goto IL_00;
							}
							bool flag11 = num33 != 0UL;
							num = 1410211859U % num;
							num += 703576141U;
							if (!flag11)
							{
								break;
							}
							if (1803907130U * num != 0U)
							{
								goto Block_9;
							}
						}
					}
					IL_3C5:
					num |= 3020013847U;
					if (1594881167U <= num)
					{
						break;
					}
					continue;
					Block_9:
					int num52 = num9;
					num = (2342684938U & num);
					int num53 = num52 | (int)(num ^ 161515584U);
					num %= 690112918U;
					num9 = num53;
					num ^= 1952272480U;
					goto IL_3C5;
				}
			}
			11AE0F91.80068AA5 80068AA = 6A9A2;
			num = (3045746316U ^ num);
			80068AA.3F831A1B(num9);
			num = 155148934U << (int)num;
			return 6A9A2;
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00060D74 File Offset: 0x0005E974
		public override char 8EBDB806()
		{
			uint num = 3391486756U;
			num <<= 29;
			char a498D = (char)this.A498D886;
			num = 1386058259U % num;
			return a498D;
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00061990 File Offset: 0x0005F590
		public static 11AE0F91.80068AA5 F6392A0C(11AE0F91.80068AA5 79102A01, 11AE0F91.80068AA5 D2343DA0)
		{
			uint num = 521873583U;
			if ((D2343DA0.3BA55C01() & (int)(num ^ 521873579U)) <= (int)(num ^ 521873583U) && (num ^ 1929612186U) != 0U)
			{
				long num2 = 79102A01.D20998B6();
				num -= 792660031U;
				int num3 = D2343DA0.30B7A98C();
				int num4 = num3;
				num = 2961522213U / num;
				int num5 = (int)(num ^ 63U);
				num = (1588009869U & num);
				int num6 = num4 & num5;
				num <<= 21;
				return new 11AE0F91.6A9A2996(num2 >> num6);
			}
			ulong num7 = 79102A01.6D84E72D();
			int num8 = D2343DA0.30B7A98C();
			num = 557348526U % num;
			int num9 = num8;
			num ^= 3566711558U;
			int num10 = num9 & (int)(num - 3599433402U);
			num = (2753773615U | num);
			return new 11AE0F91.6A9A2996(num7 >> num10);
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00060E18 File Offset: 0x0005EA18
		public override long D20998B6()
		{
			uint num = 2210133435U;
			num = 2386256945U << (int)num;
			return this.A498D886;
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00060C6C File Offset: 0x0005E86C
		public 6A9A2996(long D1A1852C)
		{
			uint num = 2930187910U;
			base..ctor();
			if (411370251U < num)
			{
				num = (423470512U & num);
				this.A498D886 = D1A1852C;
			}
		}

		// Token: 0x04000158 RID: 344
		private long A498D886;
	}

	// Token: 0x020000C2 RID: 194
	private sealed class E2A0AC8B : 11AE0F91.80068AA5
	{
		// Token: 0x060003A2 RID: 930 RVA: 0x000635A8 File Offset: 0x000611A8
		public override sbyte 482F2014()
		{
			return (sbyte)this.1D0E3501;
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0006360C File Offset: 0x0006120C
		public override ushort CF9960A3()
		{
			return (ushort)this.1D0E3501;
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00063644 File Offset: 0x00061244
		public override uint 98A2A683()
		{
			return (uint)this.1D0E3501;
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00063578 File Offset: 0x00061178
		public override 11AE0F91.6012BE05 04A04CBD()
		{
			uint num = 520776585U;
			num %= 3977110826U;
			int e99A = this.30B7A98C();
			num = 1226363407U * num;
			return new 11AE0F91.CB943E91(e99A);
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00063660 File Offset: 0x00061260
		public static 11AE0F91.80068AA5 9A073E2C(11AE0F91.80068AA5 D120932A)
		{
			uint num2;
			do
			{
				ulong num = D120932A.6D84E72D();
				int num5;
				for (;;)
				{
					11AE0F91.80068AA5 80068AA = D120932A;
					num2 = 3684223376U;
					uint num3 = (uint)(80068AA.3BA55C01() & (int)(num2 ^ 3684223380U));
					num2 = (957498138U & num2);
					bool flag = num3 > num2 - 420495632U;
					num2 = (2038720264U | num2);
					int num4 = (int)(num2 ^ 2039768856U);
					num2 = (3652968479U | num2);
					num5 = num4;
					if (flag && num2 > 1176576788U)
					{
						goto IL_54;
					}
					ulong num6 = num;
					num2 = 3275539490U << (int)num2;
					long num7 = num2 + 127U;
					num2 = 3728603523U * num2;
					long num8 = num7;
					num2 = 2811501961U << (int)num2;
					num2 += 3806390362U;
					if (num6 > num8)
					{
						num2 <<= 28;
						if (3407174288U == num2)
						{
							goto IL_54;
						}
						int num9 = num5;
						int num10 = (int)(num2 ^ 805306384U);
						num2 = (378146715U | num2);
						num5 = (num9 | num10);
						num2 ^= 3170830968U;
					}
					IL_F8:
					num2 *= 914636217U;
					int e99A = (int)((byte)num);
					num2 <<= 30;
					D120932A = new 11AE0F91.CB943E91(e99A);
					num2 ^= 3241861926U;
					if ((num2 & 842761785U) != 0U)
					{
						break;
					}
					continue;
					IL_54:
					ulong num11 = num;
					long num12 = num2 ^ 4190103520U;
					num2 += 573265944U;
					long num13 = num12;
					num2 *= 957041845U;
					if (num11 > num13)
					{
						int num14 = num5;
						num2 = (3818596514U | num2);
						num5 = (num14 | (int)(num2 + 335598125U));
						num2 ^= 1636444160U;
						goto IL_F8;
					}
					goto IL_F8;
				}
				D120932A.3F831A1B(num5);
			}
			while (280021012U - num2 == 0U);
			return D120932A;
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x000635C4 File Offset: 0x000611C4
		public override byte B508A9AB()
		{
			uint num = 4161224754U;
			num ^= 898721053U;
			return this.1D0E3501;
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00063558 File Offset: 0x00061158
		public override void 7E869424(object 25882916)
		{
			this.1D0E3501 = Convert.ToByte(25882916);
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00063540 File Offset: 0x00061140
		public override object D697DB31()
		{
			return this.1D0E3501;
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00063528 File Offset: 0x00061128
		public override 11AE0F91.80068AA5 ECAA59A1()
		{
			return new 11AE0F91.E2A0AC8B(this.1D0E3501);
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00063620 File Offset: 0x00061220
		public override int 30B7A98C()
		{
			uint num = 1251822594U;
			num = 2880294301U % num;
			return (int)this.1D0E3501;
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00063508 File Offset: 0x00061108
		public override Type 20129380()
		{
			return typeof(byte);
		}

		// Token: 0x060003AD RID: 941 RVA: 0x000635E8 File Offset: 0x000611E8
		public override short C6A6922C()
		{
			uint num = 514397569U;
			num <<= 31;
			return (short)this.1D0E3501;
		}

		// Token: 0x060003AE RID: 942 RVA: 0x000634CC File Offset: 0x000610CC
		public E2A0AC8B(byte 960B79B9)
		{
			uint num;
			do
			{
				num = 1245602346U;
				base..ctor();
				num = 2645865649U - num;
			}
			while (2611199759U >> (int)num == 0U);
			this.1D0E3501 = 960B79B9;
		}

		// Token: 0x04000159 RID: 345
		private byte 1D0E3501;
	}

	// Token: 0x020000D0 RID: 208
	private sealed class 122C9D2C : 11AE0F91.6012BE05
	{
		// Token: 0x060003C6 RID: 966 RVA: 0x00062B48 File Offset: 0x00060748
		public static 11AE0F91.80068AA5 390D87B2(11AE0F91.80068AA5 B1254E87)
		{
			uint num2;
			ulong num3;
			for (;;)
			{
				ulong num = B1254E87.6D84E72D();
				num2 = 489209659U;
				num3 = num;
				num2 >>= 9;
				uint num4 = B1254E87.3BA55C01();
				num2 <<= 28;
				uint num5 = num4 & (num2 ^ 4026531844U);
				uint num6 = num2 ^ 4026531840U;
				num2 = (2794538624U ^ num2);
				if (num5 <= num6)
				{
					if (num2 >> 27 != 0U)
					{
						break;
					}
				}
				else if (num2 / 60813075U != 0U)
				{
					goto Block_2;
				}
			}
			double num7 = (double)num3;
			num2 = 775543952U % num2;
			double e71A18BC = num7;
			goto IL_83;
			Block_2:
			ulong num8 = num3;
			num2 -= 1804320410U;
			double num9 = num8;
			num2 /= 3078875037U;
			e71A18BC = num9;
			num2 ^= 775543953U;
			IL_83:
			num2 = 3122811839U * num2;
			return new 11AE0F91.122C9D2C(e71A18BC);
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00062BE8 File Offset: 0x000607E8
		public static 11AE0F91.80068AA5 4FBA800B(11AE0F91.80068AA5 3C855524)
		{
			uint num = 2400057655U;
			double e71A18BC = 3C855524.DD227D0D();
			num /= 3129105832U;
			return new 11AE0F91.122C9D2C(e71A18BC);
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00062648 File Offset: 0x00060248
		public override UIntPtr 0E10D236()
		{
			uint size = (uint)IntPtr.Size;
			uint num = 495574058U;
			ulong value;
			if (size != num + 3799393242U)
			{
				num >>= 21;
			}
			else if (num / 4055694608U == 0U)
			{
				num = (1805780021U | num);
				ulong num2 = (ulong)((uint)this.1D150333);
				num = (2251549726U & num);
				value = num2;
				num ^= 1693310031U;
				goto IL_67;
			}
			num *= 202096162U;
			ulong num3 = (ulong)this.1D150333;
			num -= 3087349511U;
			value = num3;
			IL_67:
			num = (4205543066U ^ num);
			return new UIntPtr(value);
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00062388 File Offset: 0x0005FF88
		public override Type 20129380()
		{
			uint num = 330638986U;
			RuntimeTypeHandle handle = typeof(double).TypeHandle;
			num = (1023539218U ^ num);
			return Type.GetTypeFromHandle(handle);
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00062548 File Offset: 0x00060148
		public override uint 98A2A683()
		{
			uint num = 287051191U;
			uint num2 = (uint)this.1D150333;
			num = (3825983376U & num);
			return num2;
		}

		// Token: 0x060003CB RID: 971 RVA: 0x000623F8 File Offset: 0x0005FFF8
		public override void 7E869424(object 4D0D6438)
		{
			uint num = 1386679047U;
			double num2 = (double)4D0D6438;
			num >>= 31;
			this.1D150333 = num2;
		}

		// Token: 0x060003CC RID: 972 RVA: 0x000628F4 File Offset: 0x000604F4
		public static 11AE0F91.80068AA5 1215CBB2(11AE0F91.80068AA5 97BC8C18)
		{
			uint num = 3246856997U;
			for (;;)
			{
				11AE0F91.80068AA5 80068AA = 97BC8C18;
				num >>= 3;
				double num2 = 80068AA.DD227D0D();
				num /= 3868993419U;
				double num3 = num2;
				num = 3198295482U * num;
				ulong num6;
				int num7;
				for (;;)
				{
					IL_25:
					long num4 = (long)num3;
					num >>= 6;
					ulong num5 = (ulong)num4;
					num *= 3642836881U;
					num6 = num5;
					for (;;)
					{
						num7 = (int)(num - 0U);
						for (;;)
						{
							uint num8 = (uint)97BC8C18.3BA55C01();
							num = 1655569U >> (int)num;
							uint num9 = num + 4293311731U;
							num = 2428297648U % num;
							bool flag = (num8 & num9) > (num ^ 1233494U);
							num |= 3996203404U;
							if (flag)
							{
								double num10 = num3;
								num ^= 1395200553U;
								double num11 = -1.0;
								num = 992776328U << (int)num;
								if (num10 <= num11)
								{
									goto IL_D9;
								}
								num |= 815455643U;
								if (2771491251U < num)
								{
									goto IL_25;
								}
								double num12 = num3;
								num -= 1895867934U;
								double num13 = 1.8446744073709552E+19;
								num = 3322000140U / num;
								if (num12 >= num13)
								{
									num ^= 1140850742U;
									goto IL_D9;
								}
								IL_FB:
								num *= 354862479U;
								double num14 = num6;
								num += 2965367214U;
								double num15 = 9.223372036854776E+18;
								num = 2231966745U % num;
								if (num14 < num15)
								{
									goto IL_1EB;
								}
								if (3674909574U != num)
								{
									goto Block_6;
								}
								continue;
								IL_D9:
								num = 1765312539U / num;
								int num16 = num7;
								int num17 = (int)(num ^ 17U);
								num ^= 1069536277U;
								num7 = (num16 | num17);
								num += 3225431074U;
								goto IL_FB;
							}
							if (num3 <= -9.223372036854778E+18)
							{
								break;
							}
							num |= 68830257U;
							if (num >= 153739904U)
							{
								goto Block_8;
							}
						}
						IL_1BD:
						if ((295817918U ^ num) != 0U)
						{
							goto Block_10;
						}
						continue;
						Block_8:
						double num18 = num3;
						double num19 = 9.223372036854776E+18;
						num ^= 4269516142U;
						if (num18 >= num19)
						{
							num += 3723731277U;
							goto IL_1BD;
						}
						goto IL_1EB;
					}
				}
				IL_1EB:
				num *= 1084347414U;
				long d1A1852C = (long)num6;
				num = 2486166673U >> (int)num;
				11AE0F91.80068AA5 80068AA2 = new 11AE0F91.6A9A2996(d1A1852C);
				num %= 2174799150U;
				97BC8C18 = 80068AA2;
				num |= 2519932696U;
				11AE0F91.80068AA5 80068AA3 = 97BC8C18;
				num %= 3919985664U;
				int c7A9131D = num7;
				num = (1564449294U ^ num);
				80068AA3.3F831A1B(c7A9131D);
				num = (3709337525U | num);
				if (num + 2645607610U != 0U)
				{
					break;
				}
				continue;
				Block_6:
				double num20 = (double)num6;
				num /= 1353734536U;
				ulong num21 = (ulong)num20;
				num = 3516298419U - num;
				ulong num22 = (ulong)9.223372036854776E+18;
				num = 2443783061U - num;
				ulong num23 = num21 - num22;
				num = (1261761723U | num);
				ulong num24 = 9223372036854775808UL;
				num %= 4122689979U;
				num6 = num23 + num24;
				num ^= 3681987690U;
				goto IL_1EB;
				Block_10:
				int num25 = num7;
				int num26 = (int)(num - 3996384206U);
				num -= 2450433552U;
				int num27 = num25 | num26;
				num = 2637619771U % num;
				num7 = num27;
				num += 3475951140U;
				goto IL_1EB;
			}
			return 97BC8C18;
		}

		// Token: 0x060003CD RID: 973 RVA: 0x000625D0 File Offset: 0x000601D0
		public override IntPtr D20542BB()
		{
			uint size = (uint)IntPtr.Size;
			uint num = 3347710266U;
			long value;
			if (size != (num ^ 3347710270U))
			{
				num |= 168674956U;
				num = (2662476211U ^ num);
				value = (long)this.1D150333;
			}
			else
			{
				num += 4223183642U;
				num %= 674869802U;
				long num2 = (long)((int)this.1D150333);
				num <<= 26;
				value = num2;
				num += 2705190413U;
			}
			num += 767397521U;
			return new IntPtr(value);
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00062754 File Offset: 0x00060354
		public static 11AE0F91.80068AA5 D332AB36(11AE0F91.80068AA5 D902F43D, 11AE0F91.80068AA5 2A9ED1A8)
		{
			double num = D902F43D.DD227D0D();
			double num2 = 2A9ED1A8.DD227D0D();
			uint num3 = 3936187412U;
			double num4 = num2;
			double num5 = num4;
			num3 &= 2377421869U;
			return new 11AE0F91.122C9D2C(num / num5);
		}

		// Token: 0x060003CF RID: 975 RVA: 0x000624D8 File Offset: 0x000600D8
		public override char 8EBDB806()
		{
			uint num = 3323896974U;
			num = 1361262252U << (int)num;
			char c = (char)this.1D150333;
			num = (2268279297U | num);
			return c;
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x000623B0 File Offset: 0x0005FFB0
		public override 11AE0F91.80068AA5 ECAA59A1()
		{
			uint num = 2604368177U;
			num /= 948202754U;
			return new 11AE0F91.122C9D2C(this.1D150333);
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00062508 File Offset: 0x00060108
		public override byte B508A9AB()
		{
			uint num = 4181519268U;
			byte b = (byte)this.1D150333;
			num |= 3447869595U;
			return b;
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00062420 File Offset: 0x00060020
		public override bool 2206A10D()
		{
			return Convert.ToBoolean(this.1D150333);
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00062704 File Offset: 0x00060304
		public static 11AE0F91.80068AA5 4925D79E(11AE0F91.80068AA5 6E83AF35, 11AE0F91.80068AA5 AD326107)
		{
			uint num = 2375108920U;
			num = (3037365519U | num);
			double num2 = 6E83AF35.DD227D0D();
			num = (2860688277U | num);
			num &= 823868598U;
			double num3 = AD326107.DD227D0D();
			num = (2409372838U | num);
			double e71A18BC = num2 * num3;
			num <<= 10;
			return new 11AE0F91.122C9D2C(e71A18BC);
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x000624B4 File Offset: 0x000600B4
		public override long D20998B6()
		{
			uint num = 2593076610U;
			long num2 = (long)this.1D150333;
			num = (2350434100U & num);
			return num2;
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x0006256C File Offset: 0x0006016C
		public override ulong 6D84E72D()
		{
			uint num = 3895437999U;
			num <<= 21;
			ulong num2 = (ulong)this.1D150333;
			num = (916039474U | num);
			return num2;
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00062598 File Offset: 0x00060198
		public override float 599106A4()
		{
			return (float)this.1D150333;
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00062784 File Offset: 0x00060384
		public static 11AE0F91.80068AA5 A49C8FA2(11AE0F91.80068AA5 D43B341E, 11AE0F91.80068AA5 E98FEE84)
		{
			uint num = 4051903550U;
			double num2 = D43B341E.DD227D0D();
			num *= 3079103904U;
			double num3 = E98FEE84.DD227D0D();
			num -= 2703841171U;
			double num4 = num3;
			num >>= 5;
			double e71A18BC = num2 % num4;
			num = 1539306514U / num;
			return new 11AE0F91.122C9D2C(e71A18BC);
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x0006252C File Offset: 0x0006012C
		public override ushort CF9960A3()
		{
			return (ushort)this.1D150333;
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00062464 File Offset: 0x00060064
		public override short C6A6922C()
		{
			uint num = 3357640238U;
			num *= 3700226566U;
			short num2 = (short)this.1D150333;
			num = 3717036984U - num;
			return num2;
		}

		// Token: 0x060003DA RID: 986 RVA: 0x000627FC File Offset: 0x000603FC
		public static 11AE0F91.80068AA5 FE86852D(11AE0F91.80068AA5 6E987004, 11AE0F91.80068AA5 3C32D3BE)
		{
			int num6;
			for (;;)
			{
				uint num = 2545060280U;
				double num2 = 6E987004.DD227D0D();
				if (2184933677U * num != 0U)
				{
					for (;;)
					{
						num = (3509913493U ^ num);
						double num3 = 3C32D3BE.DD227D0D();
						num = (1126153011U & num);
						double num4 = num3;
						int num5 = (int)(num + 3187176927U);
						num = 293757347U * num;
						num6 = num5;
						double num7 = num2;
						num = (925711676U & num);
						double num8 = num4;
						num = (656954678U ^ num);
						if (num7 == num8)
						{
							break;
						}
						if (num / 3599423634U != 0U)
						{
							goto IL_62;
						}
						double num9 = num2;
						num = 2401006766U - num;
						double num10 = num4;
						num ^= 1137430456U;
						if (num9 >= num10)
						{
							goto IL_C9;
						}
						if (num <= 2409230498U)
						{
							goto Block_3;
						}
					}
					if (3498748704U > num)
					{
						goto IL_62;
					}
					continue;
					IL_C9:
					num = 2802580763U - num;
					if (-1751510606 << (int)num != 0)
					{
						break;
					}
					continue;
					Block_3:
					int num11 = num6;
					int num12 = (int)(num ^ 952425672U);
					num <<= 22;
					num6 = (num11 | num12);
					num ^= 147119296U;
					goto IL_C9;
					IL_62:
					int num13 = num6;
					num = 4236898057U * num;
					int num14 = num13 | (int)(num ^ 1612698855U);
					num = 1931370528U * num;
					num6 = num14;
					goto IL_C9;
				}
			}
			return new 11AE0F91.CB943E91(num6);
		}

		// Token: 0x060003DB RID: 987 RVA: 0x000625B4 File Offset: 0x000601B4
		public override double DD227D0D()
		{
			return this.1D150333;
		}

		// Token: 0x060003DC RID: 988 RVA: 0x000623D8 File Offset: 0x0005FFD8
		public override object D697DB31()
		{
			return this.1D150333;
		}

		// Token: 0x060003DD RID: 989 RVA: 0x000626CC File Offset: 0x000602CC
		public static 11AE0F91.80068AA5 ABBDD91C(11AE0F91.80068AA5 D3AF13BE, 11AE0F91.80068AA5 B7B65712)
		{
			double num = D3AF13BE.DD227D0D();
			double num2 = B7B65712.DD227D0D();
			uint num3 = 1694704565U;
			double num4 = num2;
			num3 %= 1613209473U;
			double num5 = num4;
			num3 ^= 457097138U;
			return new 11AE0F91.122C9D2C(num + num5);
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00062440 File Offset: 0x00060040
		public override sbyte 482F2014()
		{
			uint num = 3096605486U;
			sbyte b = (sbyte)this.1D150333;
			num = (1906986680U & num);
			return b;
		}

		// Token: 0x060003DF RID: 991 RVA: 0x000627CC File Offset: 0x000603CC
		public static 11AE0F91.80068AA5 AB1162AA(11AE0F91.80068AA5 FC2F2E35)
		{
			uint num = 2114593412U;
			double num2 = FC2F2E35.DD227D0D();
			num = 2015750975U / num;
			double e71A18BC = -num2;
			num >>= 28;
			return new 11AE0F91.122C9D2C(e71A18BC);
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00062490 File Offset: 0x00060090
		public override int 30B7A98C()
		{
			uint num = 4020027421U;
			num |= 1930270617U;
			return (int)this.1D150333;
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00062340 File Offset: 0x0005FF40
		public 122C9D2C(double E71A18BC)
		{
			uint num = 1243278115U;
			base..ctor();
			do
			{
				num = 2403236105U >> (int)num;
				num = 900379697U << (int)num;
				this.1D150333 = E71A18BC;
			}
			while ((num ^ 976865957U) == 0U);
		}

		// Token: 0x0400018C RID: 396
		private double 1D150333;
	}

	// Token: 0x020000E1 RID: 225
	private sealed class 6B246EA5 : 11AE0F91.FCB842B2
	{
		// Token: 0x060003FA RID: 1018 RVA: 0x00064C64 File Offset: 0x00062864
		public override object D697DB31()
		{
			return this.499D1D8B.0681AA27(this.AB084B05);
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00064C40 File Offset: 0x00062840
		public override 11AE0F91.80068AA5 ECAA59A1()
		{
			return new 11AE0F91.6B246EA5(this.AB084B05, this.499D1D8B);
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00064C88 File Offset: 0x00062888
		public override void 7E869424(object 6C3DDB9A)
		{
			uint num = 4005387393U;
			do
			{
				num = 1789281579U * num;
				11AE0F91.80068AA5 80068AA = this.499D1D8B;
				num %= 364565660U;
				num = 3131695516U / num;
				FieldInfo ab084B = this.AB084B05;
				num = 154486675U - num;
				80068AA.B534E11F(ab084B, 6C3DDB9A);
			}
			while (3594034708U == num);
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00064C20 File Offset: 0x00062820
		public override Type 20129380()
		{
			return this.AB084B05.FieldType;
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00064BB8 File Offset: 0x000627B8
		public 6B246EA5(FieldInfo D0BD6B9A, 11AE0F91.80068AA5 38BE1116)
		{
			for (;;)
			{
				uint num = 3158160286U;
				base..ctor();
				num %= 884630435U;
				if (num != 171500474U)
				{
					num = 2081834159U / num;
					this.AB084B05 = D0BD6B9A;
					num = 3196183936U - num;
					num = (453045769U & num);
					num = 67412874U * num;
					this.499D1D8B = 38BE1116;
					if (411884988U != num)
					{
						break;
					}
				}
			}
		}

		// Token: 0x04000198 RID: 408
		private 11AE0F91.80068AA5 499D1D8B;

		// Token: 0x04000199 RID: 409
		private FieldInfo AB084B05;
	}

	// Token: 0x020000E9 RID: 233
	private sealed class AEB82B22 : 11AE0F91.6012BE05
	{
		// Token: 0x06000408 RID: 1032 RVA: 0x000650B8 File Offset: 0x00062CB8
		public override Type 20129380()
		{
			return typeof(MethodBase);
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x000650F0 File Offset: 0x00062CF0
		public override object D697DB31()
		{
			return this.ED26AE11;
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x0006510C File Offset: 0x00062D0C
		public override void 7E869424(object 0B0B5F89)
		{
			this.ED26AE11 = (MethodBase)0B0B5F89;
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x0006512C File Offset: 0x00062D2C
		public override IntPtr D20542BB()
		{
			uint num;
			RuntimeMethodHandle runtimeMethodHandle;
			do
			{
				num = 4138351923U;
				MethodBase ed26AE = this.ED26AE11;
				num += 985591078U;
				RuntimeMethodHandle methodHandle = ed26AE.MethodHandle;
				num = 3095455104U * num;
				runtimeMethodHandle = methodHandle;
			}
			while (num == 180337853U);
			return runtimeMethodHandle.GetFunctionPointer();
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x000650D0 File Offset: 0x00062CD0
		public override 11AE0F91.80068AA5 ECAA59A1()
		{
			return new 11AE0F91.AEB82B22(this.ED26AE11);
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00065074 File Offset: 0x00062C74
		public AEB82B22(MethodBase 3916BE9F)
		{
			uint num = 884887990U;
			do
			{
				base..ctor();
				num = 767433344U * num;
				num >>= 7;
				num &= 3308308626U;
				this.ED26AE11 = 3916BE9F;
			}
			while (1471137413U % num == 0U);
		}

		// Token: 0x0400019C RID: 412
		private MethodBase ED26AE11;
	}

	// Token: 0x020000F2 RID: 242
	private sealed class 1C16CD2C : 11AE0F91.6012BE05
	{
		// Token: 0x0600041C RID: 1052 RVA: 0x000640BC File Offset: 0x00061CBC
		public override 11AE0F91.80068AA5 ECAA59A1()
		{
			return new 11AE0F91.1C16CD2C(this.909C4598);
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x000640F0 File Offset: 0x00061CF0
		public override void 7E869424(object 86065B9B)
		{
			uint num = 3996168996U;
			num -= 1336188546U;
			this.909C4598 = 86065B9B;
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x000640D4 File Offset: 0x00061CD4
		public override object D697DB31()
		{
			return this.909C4598;
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x0006409C File Offset: 0x00061C9C
		public override Type 20129380()
		{
			return typeof(object);
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00064114 File Offset: 0x00061D14
		public static 11AE0F91.80068AA5 2434FB9C(11AE0F91.80068AA5 D597812C, 11AE0F91.80068AA5 20BDE031)
		{
			uint num = 2516685829U;
			int num3;
			for (;;)
			{
				object obj = D597812C.D697DB31();
				num = 1435023399U >> (int)num;
				object obj2 = obj;
				if ((num ^ 145748019U) != 0U)
				{
					object obj3 = 20BDE031.D697DB31();
					num = (3826327982U ^ num);
					object obj4 = obj3;
					int num2 = (int)(num + 423795601U);
					num = 3223711505U - num;
					num3 = num2;
					num = (1713542292U ^ num);
					object obj5 = obj2;
					num = 1253520315U << (int)num;
					if (obj5 == obj4)
					{
						num /= 1471522322U;
						if (num >= 93248926U)
						{
							continue;
						}
						num3 |= (int)(num + uint.MaxValue);
					}
					else
					{
						bool flag = obj2 != null;
						num = 2208566078U + num;
						num ^= 1919159100U;
						if (!flag)
						{
							num *= 4087412631U;
							int num4 = num3;
							int num5 = (int)(num ^ 3879857958U);
							num >>= 19;
							num3 = (num4 | num5);
							num ^= 7402U;
						}
					}
					if (num / 3887799099U == 0U)
					{
						break;
					}
				}
			}
			return new 11AE0F91.CB943E91(num3);
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00064058 File Offset: 0x00061C58
		public 1C16CD2C(object 8237D7A7)
		{
			uint num = 1613698367U;
			num *= 632906897U;
			base..ctor();
			num = 884512431U * num;
			do
			{
				num >>= 16;
				this.909C4598 = 8237D7A7;
			}
			while ((3014540469U ^ num) == 0U);
		}

		// Token: 0x040001A7 RID: 423
		private object 909C4598;
	}

	// Token: 0x02000109 RID: 265
	private abstract class 6012BE05 : 11AE0F91.80068AA5
	{
		// Token: 0x06000459 RID: 1113 RVA: 0x0005FB34 File Offset: 0x0005D734
		public override 11AE0F91.6012BE05 04A04CBD()
		{
			return this;
		}
	}

	// Token: 0x0200010B RID: 267
	private sealed class B59F4436 : IDisposable
	{
		// Token: 0x0600045B RID: 1115 RVA: 0x0005E974 File Offset: 0x0005C574
		public void Dispose()
		{
			uint num = 2584251393U;
			List<GCHandle>.Enumerator enumerator = this.1A2C7907.GetEnumerator();
			num <<= 22;
			using (List<GCHandle>.Enumerator enumerator2 = enumerator)
			{
				do
				{
					for (;;)
					{
						num = 607483800U << (int)num;
						if (!enumerator2.MoveNext())
						{
							break;
						}
						num = 1924733349U;
						if (1025548455U < num)
						{
							GCHandle gchandle = enumerator2.Current;
							num = (1672227372U ^ num);
							GCHandle gchandle2 = gchandle;
							num ^= 3366984471U;
							if (2316510228U / num == 0U)
							{
								gchandle2.Free();
								num += 647681890U;
							}
						}
					}
				}
				while (278082879U == num);
			}
			do
			{
				num = 54114564U;
				num = 4254738973U << (int)num;
				List<GCHandle> list = this.1A2C7907;
				num = 933018036U << (int)num;
				list.Clear();
			}
			while (num == 3737003816U);
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x0005EA70 File Offset: 0x0005C670
		public B59F4436()
		{
			uint num = 4198301215U;
			this.1A2C7907 = new List<GCHandle>();
			if (num != 632230408U)
			{
				num %= 3776141732U;
				base..ctor();
			}
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x0005E908 File Offset: 0x0005C508
		public IntPtr 7C285EBA(object 980058A7)
		{
			uint num = 2442505002U;
			GCHandle gchandle;
			do
			{
				num *= 3516018359U;
				GCHandleType type = (GCHandleType)(num ^ 3736266501U);
				num = 2335248567U + num;
				gchandle = GCHandle.Alloc(980058A7, type);
				if (371833485U == num)
				{
					break;
				}
				num = 647261839U % num;
				List<GCHandle> list = this.1A2C7907;
				GCHandle item = gchandle;
				num |= 3407431318U;
				list.Add(item);
			}
			while (num / 1526809994U == 0U);
			return gchandle.AddrOfPinnedObject();
		}

		// Token: 0x040001C0 RID: 448
		private List<GCHandle> 1A2C7907;
	}

	// Token: 0x0200010C RID: 268
	private sealed class B7939DAF : 11AE0F91.6012BE05
	{
		// Token: 0x0600045E RID: 1118 RVA: 0x00064860 File Offset: 0x00062460
		public override object 0681AA27(FieldInfo 3D089D0F)
		{
			object result = this.890FAD95.0681AA27(3D089D0F);
			Thread.MemoryBarrier();
			return result;
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x00064974 File Offset: 0x00062574
		public override int 30B7A98C()
		{
			int result = this.890FAD95.30B7A98C();
			Thread.MemoryBarrier();
			return result;
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x00064904 File Offset: 0x00062504
		public override sbyte 482F2014()
		{
			uint num = 296770232U;
			11AE0F91.80068AA5 80068AA = this.890FAD95;
			num = 1655085621U - num;
			sbyte result = 80068AA.482F2014();
			num %= 3381498928U;
			Thread.MemoryBarrier();
			return result;
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00064998 File Offset: 0x00062598
		public override long D20998B6()
		{
			long result = this.890FAD95.D20998B6();
			Thread.MemoryBarrier();
			return result;
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00064A54 File Offset: 0x00062654
		public override float 599106A4()
		{
			uint num = 588093712U;
			num = 3977670076U >> (int)num;
			11AE0F91.80068AA5 80068AA = this.890FAD95;
			num = 3091041164U + num;
			float result = 80068AA.599106A4();
			num = (2268276901U | num);
			Thread.MemoryBarrier();
			return result;
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00064884 File Offset: 0x00062484
		public override void B534E11F(FieldInfo 79146917, object C21D65A9)
		{
			Thread.MemoryBarrier();
			uint num = 3985619351U;
			if (num % 3131528855U != 0U)
			{
				num >>= 6;
				11AE0F91.80068AA5 80068AA = this.890FAD95;
				num = (1856169907U & num);
				num |= 1049381822U;
				num *= 3146004741U;
				80068AA.B534E11F(79146917, C21D65A9);
			}
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x000649E8 File Offset: 0x000625E8
		public override ushort CF9960A3()
		{
			ushort result = this.890FAD95.CF9960A3();
			Thread.MemoryBarrier();
			return result;
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x000647D8 File Offset: 0x000623D8
		public override 11AE0F91.80068AA5 ECAA59A1()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x00064A98 File Offset: 0x00062698
		public override double DD227D0D()
		{
			double result = this.890FAD95.DD227D0D();
			Thread.MemoryBarrier();
			return result;
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x000648D8 File Offset: 0x000624D8
		public override bool 2206A10D()
		{
			uint num = 3768641042U;
			11AE0F91.80068AA5 80068AA = this.890FAD95;
			num = (3685020478U & num);
			bool result = 80068AA.2206A10D();
			Thread.MemoryBarrier();
			return result;
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x000647B0 File Offset: 0x000623B0
		public override bool FC990F28()
		{
			uint num = 2954837689U;
			num /= 3650966558U;
			return this.890FAD95.FC990F28();
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00064A0C File Offset: 0x0006260C
		public override uint 98A2A683()
		{
			uint result = this.890FAD95.98A2A683();
			Thread.MemoryBarrier();
			return result;
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00064788 File Offset: 0x00062388
		public override Type 20129380()
		{
			uint num = 3909754896U;
			num = (3282896277U ^ num);
			return this.890FAD95.20129380();
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x000649BC File Offset: 0x000625BC
		public override byte B508A9AB()
		{
			uint num = 2903693616U;
			byte result = this.890FAD95.B508A9AB();
			num *= 2534049316U;
			Thread.MemoryBarrier();
			return result;
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x00064810 File Offset: 0x00062410
		public override void 7E869424(object 3327DD2B)
		{
			uint num = 1124880826U;
			if (211515417U <= num)
			{
				for (;;)
				{
					Thread.MemoryBarrier();
					if (num % 1679738020U != 0U)
					{
						11AE0F91.80068AA5 80068AA = this.890FAD95;
						num |= 3575942204U;
						80068AA.7E869424(3327DD2B);
						if (2318196015U <= num)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x000647EC File Offset: 0x000623EC
		public override object D697DB31()
		{
			object result = this.890FAD95.D697DB31();
			Thread.MemoryBarrier();
			return result;
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00064938 File Offset: 0x00062538
		public override short C6A6922C()
		{
			uint num = 3627294373U;
			num = 2948261788U << (int)num;
			11AE0F91.80068AA5 80068AA = this.890FAD95;
			num = (1855171336U | num);
			short result = 80068AA.C6A6922C();
			Thread.MemoryBarrier();
			return result;
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00064A30 File Offset: 0x00062630
		public override ulong 6D84E72D()
		{
			ulong result = this.890FAD95.6D84E72D();
			Thread.MemoryBarrier();
			return result;
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00064754 File Offset: 0x00062354
		public B7939DAF(11AE0F91.80068AA5 3C9294A9)
		{
			uint num;
			do
			{
				base..ctor();
				num = 3022876421U;
				num += 666291377U;
				this.890FAD95 = 3C9294A9;
			}
			while (num == 2132932993U);
		}

		// Token: 0x040001C1 RID: 449
		private 11AE0F91.80068AA5 890FAD95;
	}

	// Token: 0x02000118 RID: 280
	private sealed class 470344A8 : 11AE0F91.80068AA5
	{
		// Token: 0x06000487 RID: 1159 RVA: 0x000642C8 File Offset: 0x00061EC8
		public override 11AE0F91.80068AA5 ECAA59A1()
		{
			uint num = 3476728335U;
			num = (2419513276U | num);
			object 4287A = this.42A4B424;
			num = 3867423363U * num;
			return new 11AE0F91.470344A8(4287A, this.9A30CABD);
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x000642FC File Offset: 0x00061EFC
		public override object D697DB31()
		{
			return this.42A4B424;
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00064310 File Offset: 0x00061F10
		public override void 7E869424(object DABFD13B)
		{
			uint num = 94130992U;
			num = 3820889347U / num;
			this.42A4B424 = DABFD13B;
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x0006423C File Offset: 0x00061E3C
		public override 11AE0F91.6012BE05 04A04CBD()
		{
			uint num;
			IntPtr b68DCD;
			while (this.42A4B424 == null)
			{
				num = 1309830962U;
				if (-703093852 << (int)num != 0)
				{
					b68DCD = IntPtr.Zero;
					num ^= 1379084082U;
					IL_5B:
					return new 11AE0F91.8A270C3B(b68DCD);
				}
			}
			num = 3775554237U;
			num >>= 14;
			object ptr = this.42A4B424;
			num <<= 11;
			b68DCD = new IntPtr(Pointer.Unbox(ptr));
			goto IL_5B;
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x000642AC File Offset: 0x00061EAC
		public override Type 20129380()
		{
			return this.9A30CABD;
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x000641F0 File Offset: 0x00061DF0
		public 470344A8(object 4287A603, Type 1EB7483B)
		{
			uint num;
			do
			{
				num = 470759832U;
				base..ctor();
				num |= 1572460198U;
				num <<= 24;
				this.42A4B424 = 4287A603;
			}
			while (num >= 4018994861U);
			num = 262773289U / num;
			this.9A30CABD = 1EB7483B;
		}

		// Token: 0x040001F6 RID: 502
		private Type 9A30CABD;

		// Token: 0x040001F7 RID: 503
		private object 42A4B424;
	}

	// Token: 0x0200011E RID: 286
	// (Invoke) Token: 0x06000493 RID: 1171
	internal delegate void E489CC87();

	// Token: 0x02000139 RID: 313
	private sealed class 429DA536 : 11AE0F91.80068AA5
	{
		// Token: 0x060004BE RID: 1214 RVA: 0x00063428 File Offset: 0x00061028
		public override sbyte 482F2014()
		{
			uint num = 3750484523U;
			sbyte e509053E = (sbyte)this.E509053E;
			num |= 1881079340U;
			return e509053E;
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00063490 File Offset: 0x00061090
		public override ushort CF9960A3()
		{
			return (ushort)this.E509053E;
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x000634A4 File Offset: 0x000610A4
		public override int 30B7A98C()
		{
			return (int)this.E509053E;
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x0006344C File Offset: 0x0006104C
		public override byte B508A9AB()
		{
			uint num = 790690970U;
			byte e509053E = (byte)this.E509053E;
			num = 4070931988U >> (int)num;
			return e509053E;
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x000633C0 File Offset: 0x00060FC0
		public override void 7E869424(object 36303F8B)
		{
			uint num = 3896132920U;
			if (3013126941U * num != 0U)
			{
				do
				{
					num = (2945465143U & num);
					num *= 1753818558U;
					this.E509053E = Convert.ToChar(36303F8B);
				}
				while (num / 69756726U == 0U);
			}
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x000634B8 File Offset: 0x000610B8
		public override uint 98A2A683()
		{
			return (uint)this.E509053E;
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00063354 File Offset: 0x00060F54
		public override Type 20129380()
		{
			return typeof(char);
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00063394 File Offset: 0x00060F94
		public override object D697DB31()
		{
			uint num = 1570460947U;
			num = 3702602150U << (int)num;
			return this.E509053E;
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x0006336C File Offset: 0x00060F6C
		public override 11AE0F91.80068AA5 ECAA59A1()
		{
			uint num = 2627203113U;
			num <<= 25;
			return new 11AE0F91.429DA536(this.E509053E);
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00063474 File Offset: 0x00061074
		public override short C6A6922C()
		{
			return (short)this.E509053E;
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00063408 File Offset: 0x00061008
		public override 11AE0F91.6012BE05 04A04CBD()
		{
			return new 11AE0F91.CB943E91(this.30B7A98C());
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00063318 File Offset: 0x00060F18
		public 429DA536(char 7136ED1F)
		{
			uint num = 2871970053U;
			do
			{
				num >>= 18;
				base..ctor();
			}
			while (1259386900U - num == 0U);
			num &= 2383443202U;
			this.E509053E = 7136ED1F;
		}

		// Token: 0x04000212 RID: 530
		private char E509053E;
	}

	// Token: 0x02000142 RID: 322
	private sealed class 840DFA36 : 11AE0F91.80068AA5
	{
		// Token: 0x060004DF RID: 1247 RVA: 0x00063A84 File Offset: 0x00061684
		public override 11AE0F91.80068AA5 ECAA59A1()
		{
			uint num = 2822560428U;
			uint 423D881D = this.3F0C30A3;
			num = 3073442339U << (int)num;
			return new 11AE0F91.840DFA36(423D881D);
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00063B6C File Offset: 0x0006176C
		public override ushort CF9960A3()
		{
			uint num = 3071858977U;
			num &= 3272976897U;
			ushort num2 = (ushort)this.3F0C30A3;
			num /= 1689489820U;
			return num2;
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x00063B28 File Offset: 0x00061728
		public override sbyte 482F2014()
		{
			return (sbyte)this.3F0C30A3;
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00063B3C File Offset: 0x0006173C
		public override byte B508A9AB()
		{
			return (byte)this.3F0C30A3;
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00063AF8 File Offset: 0x000616F8
		public override 11AE0F91.6012BE05 04A04CBD()
		{
			uint num = 3415406655U;
			num |= 3104230034U;
			int e99A = this.30B7A98C();
			num += 3859275553U;
			return new 11AE0F91.CB943E91(e99A);
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00063BB4 File Offset: 0x000617B4
		public override uint 98A2A683()
		{
			return this.3F0C30A3;
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00063AD0 File Offset: 0x000616D0
		public override void 7E869424(object 8000059F)
		{
			uint num = 2887385478U;
			uint num2 = Convert.ToUInt32(8000059F);
			num = (2870397499U & num);
			this.3F0C30A3 = num2;
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00063B98 File Offset: 0x00061798
		public override int 30B7A98C()
		{
			return (int)this.3F0C30A3;
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00063A6C File Offset: 0x0006166C
		public override Type 20129380()
		{
			return typeof(uint);
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00063B50 File Offset: 0x00061750
		public override short C6A6922C()
		{
			return (short)this.3F0C30A3;
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00063BD0 File Offset: 0x000617D0
		public static 11AE0F91.80068AA5 B78D5C34(11AE0F91.80068AA5 D5867785)
		{
			for (;;)
			{
				11AE0F91.80068AA5 80068AA = D5867785;
				uint num = 187212731U;
				ulong num2 = 80068AA.6D84E72D();
				num |= 3048571416U;
				if (2453029129U * num != 0U)
				{
					for (;;)
					{
						uint num3 = (uint)(D5867785.3BA55C01() & (int)(num ^ 3216876479U));
						num += 1923819310U;
						bool flag = num3 > (num ^ 845728489U);
						int num4 = (int)(num + 3449238807U);
						if (flag)
						{
							if (321982774U == num)
							{
								continue;
							}
						}
						else
						{
							num = (621945003U & num);
							ulong num5 = num2;
							long num6 = num ^ 1610612566U;
							num = 85632417U % num;
							long num7 = num6;
							num = 1983318941U / num;
							num += 270532593U;
							if (num5 > num7)
							{
								num -= 1023531030U;
								goto IL_F6;
							}
							goto IL_11E;
						}
						IL_58:
						ulong num8 = num2;
						num &= 288363786U;
						if (num8 > (ulong)(num - 270532617U))
						{
							num += 3577711383U;
							if (2267593090U >> (int)num == 0U)
							{
								goto IL_F6;
							}
							int num9 = num4;
							num = 202791081U << (int)num;
							int num10 = num9 | (int)(num ^ 2147483664U);
							num = 2491790115U + num;
							num4 = num10;
							if (num < 226552873U)
							{
								continue;
							}
							num += 4221193445U;
						}
						IL_11E:
						num = (438070149U ^ num);
						if (1839217831U < num)
						{
							break;
						}
						int e99A = (int)num2;
						num = 3363951888U % num;
						11AE0F91.80068AA5 80068AA2 = new 11AE0F91.CB943E91(e99A);
						num = 3845402932U - num;
						D5867785 = 80068AA2;
						num = 4043805469U << (int)num;
						if (3198163986U - num == 0U)
						{
							goto IL_58;
						}
						D5867785.3F831A1B(num4);
						if (num % 137738788U != 0U)
						{
							return D5867785;
						}
						continue;
						IL_F6:
						int num11 = num4;
						num %= 1418081303U;
						int num12 = (int)(num + 3589161036U);
						num = 4281650479U >> (int)num;
						num4 = (num11 | num12);
						num += 2929462U;
						goto IL_11E;
					}
				}
			}
			return D5867785;
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x00063AB0 File Offset: 0x000616B0
		public override object D697DB31()
		{
			return this.3F0C30A3;
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x00063A50 File Offset: 0x00061650
		public 840DFA36(uint 423D881D)
		{
			this.3F0C30A3 = 423D881D;
		}

		// Token: 0x0400021A RID: 538
		private uint 3F0C30A3;
	}

	// Token: 0x0200014A RID: 330
	private sealed class 8A270C3B : 11AE0F91.6012BE05
	{
		// Token: 0x060004F9 RID: 1273 RVA: 0x00065338 File Offset: 0x00062F38
		public override sbyte 482F2014()
		{
			return this.6A341B3D.482F2014();
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x000653C4 File Offset: 0x00062FC4
		public override byte B508A9AB()
		{
			uint num = 2484999464U;
			num /= 3406574610U;
			return this.6A341B3D.B508A9AB();
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x0006544C File Offset: 0x0006304C
		public override float 599106A4()
		{
			return this.6A341B3D.599106A4();
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00065464 File Offset: 0x00063064
		public override double DD227D0D()
		{
			return this.6A341B3D.DD227D0D();
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00065414 File Offset: 0x00063014
		public override uint 98A2A683()
		{
			return this.6A341B3D.98A2A683();
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x000655B8 File Offset: 0x000631B8
		public static 11AE0F91.80068AA5 A50D6222(11AE0F91.80068AA5 D92C293C, 11AE0F91.80068AA5 E1BEE589)
		{
			uint num2;
			for (;;)
			{
				int size = IntPtr.Size;
				int num = 4;
				num2 = 2266607635U;
				if (size != num)
				{
					break;
				}
				if (4145965758U - num2 != 0U)
				{
					goto Block_1;
				}
			}
			num2 = 2352467244U % num2;
			num2 >>= 19;
			num2 = (3584075810U | num2);
			return 11AE0F91.6A9A2996.F6392A0C(D92C293C, E1BEE589);
			Block_1:
			num2 |= 4144559409U;
			num2 *= 746929847U;
			return 11AE0F91.CB943E91.15917E88(D92C293C, E1BEE589);
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00065298 File Offset: 0x00062E98
		public override void 7E869424(object F88D22AF)
		{
			uint num = 3676140323U;
			num &= 321701151U;
			this.CC13ED26 = (IntPtr)F88D22AF;
			num -= 2075460524U;
			if (4188933519U >= num)
			{
				num -= 3543812886U;
				IntPtr cc13ED = this.CC13ED26;
				num = 2835917224U >> (int)num;
				this.6A341B3D = 11AE0F91.8A270C3B.C416A81D(cc13ED);
			}
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00065228 File Offset: 0x00062E28
		public override Type 20129380()
		{
			return typeof(IntPtr);
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00065490 File Offset: 0x00063090
		public override UIntPtr 0E10D236()
		{
			return this.6A341B3D.0E10D236();
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00065674 File Offset: 0x00063274
		public static 11AE0F91.80068AA5 5E02AC2A(11AE0F91.80068AA5 3896021B, 11AE0F91.80068AA5 9B1CB49F)
		{
			uint num = 244825789U;
			if (3869161475U * num != 0U)
			{
				for (;;)
				{
					uint size = (uint)IntPtr.Size;
					num = 3283555135U << (int)num;
					if (size == num + 536870916U)
					{
						break;
					}
					num &= 1015950764U;
					if (974912385U - num != 0U)
					{
						goto IL_45;
					}
				}
				num = (873631745U & num);
				return 11AE0F91.CB943E91.69235B90(3896021B, 9B1CB49F);
			}
			IL_45:
			num = 2570525862U % num;
			num = 2066250285U % num;
			return 11AE0F91.6A9A2996.8C9F8D33(3896021B, 9B1CB49F);
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x000653EC File Offset: 0x00062FEC
		public override ushort CF9960A3()
		{
			uint num = 1881584532U;
			11AE0F91.80068AA5 80068AA = this.6A341B3D;
			num |= 2126438963U;
			return 80068AA.CF9960A3();
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x000653AC File Offset: 0x00062FAC
		public override long D20998B6()
		{
			return this.6A341B3D.D20998B6();
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x00065760 File Offset: 0x00063360
		public static 11AE0F91.80068AA5 6E864C1A(11AE0F91.80068AA5 87B0B200, 11AE0F91.80068AA5 5B364EB9)
		{
			if (IntPtr.Size != 4)
			{
				return 11AE0F91.6A9A2996.8232AF01(87B0B200, 5B364EB9);
			}
			return 11AE0F91.CB943E91.823F3018(87B0B200, 5B364EB9);
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x000654F0 File Offset: 0x000630F0
		public static 11AE0F91.80068AA5 5A235921(11AE0F91.80068AA5 95266A32, 11AE0F91.80068AA5 0812228D)
		{
			uint num = 3770199711U;
			if (1261158528U < num)
			{
				while (IntPtr.Size == (int)(num - 3770199707U))
				{
					num = 563649950U + num;
					if ((num & 2483110459U) != 0U)
					{
						num %= 4254946332U;
						num <<= 6;
						return 11AE0F91.CB943E91.3195F2BC(95266A32, 0812228D);
					}
				}
			}
			return 11AE0F91.6A9A2996.05197C0C(95266A32, 0812228D);
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x000652FC File Offset: 0x00062EFC
		public override bool 2206A10D()
		{
			uint num = 302494104U;
			num -= 1664420891U;
			IntPtr cc13ED = this.CC13ED26;
			num %= 2274564414U;
			IntPtr zero = IntPtr.Zero;
			num = (4105748009U & num);
			return cc13ED != zero;
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x000656F0 File Offset: 0x000632F0
		public static 11AE0F91.80068AA5 DC82EF39(11AE0F91.80068AA5 F93E8616, 11AE0F91.80068AA5 C72C723E)
		{
			uint num = 3330468642U;
			if (414631222U - num == 0U)
			{
				goto IL_46;
			}
			int size = IntPtr.Size;
			num /= 3801626500U;
			uint num2 = num - 4294967292U;
			num <<= 11;
			if (size == num2 || num > 1907701638U)
			{
				goto IL_46;
			}
			IL_3E:
			return 11AE0F91.6A9A2996.D29D5A89(F93E8616, C72C723E);
			IL_46:
			if (num != 3087362330U)
			{
				num = (2326589723U | num);
				return 11AE0F91.CB943E91.83352C2C(F93E8616, C72C723E);
			}
			goto IL_3E;
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x000651C4 File Offset: 0x00062DC4
		private static 11AE0F91.80068AA5 C416A81D(IntPtr 4D21DF13)
		{
			uint num = 4044074654U;
			if (IntPtr.Size != (int)(num ^ 4044074650U))
			{
				goto IL_37;
			}
			num /= 1351415079U;
			if (613261235U == num)
			{
				goto IL_37;
			}
			IL_2A:
			return new 11AE0F91.CB943E91(4D21DF13.ToInt32());
			IL_37:
			if ((num & 3374474169U) != 0U)
			{
				long d1A1852C = 4D21DF13.ToInt64();
				num %= 4030444929U;
				return new 11AE0F91.6A9A2996(d1A1852C);
			}
			goto IL_2A;
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00065248 File Offset: 0x00062E48
		public override 11AE0F91.80068AA5 ECAA59A1()
		{
			return new 11AE0F91.8A270C3B(this.CC13ED26);
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x0006542C File Offset: 0x0006302C
		public override ulong 6D84E72D()
		{
			return this.6A341B3D.6D84E72D();
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x0006547C File Offset: 0x0006307C
		public override IntPtr D20542BB()
		{
			return this.CC13ED26;
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x000654A8 File Offset: 0x000630A8
		public static 11AE0F91.80068AA5 16294C98(11AE0F91.80068AA5 D393F703)
		{
			uint size = (uint)IntPtr.Size;
			uint num = 714948156U;
			if (size == (num ^ 714948152U))
			{
				num >>= 23;
				if (4152884484U + num != 0U)
				{
					return 11AE0F91.CB943E91.3B302122(D393F703);
				}
			}
			return 11AE0F91.6A9A2996.4E8DB1A3(D393F703);
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x0006561C File Offset: 0x0006321C
		public static 11AE0F91.80068AA5 CF1BAB34(11AE0F91.80068AA5 012C8800, 11AE0F91.80068AA5 E4996BBB)
		{
			uint num = 521745555U;
			while (IntPtr.Size != (int)(num ^ 521745559U))
			{
				if (num != 2645780906U)
				{
					num |= 3299265416U;
					return 11AE0F91.6A9A2996.BF22DEA6(012C8800, E4996BBB);
				}
			}
			num = 2442212513U % num;
			num = 3584755500U % num;
			return 11AE0F91.CB943E91.9315E01E(012C8800, E4996BBB);
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00065554 File Offset: 0x00063154
		public static 11AE0F91.80068AA5 3B22901F(11AE0F91.80068AA5 CA29A81C, 11AE0F91.80068AA5 2B3A3819)
		{
			uint num = 1544585742U;
			if (1577334429U != num)
			{
				for (;;)
				{
					uint size = (uint)IntPtr.Size;
					num *= 2040904876U;
					if (size == num + 2489341596U)
					{
						break;
					}
					if (2637162149U > num)
					{
						goto IL_35;
					}
				}
				num *= 403541777U;
				return 11AE0F91.CB943E91.CF0D6F0C(CA29A81C, 2B3A3819);
			}
			IL_35:
			num &= 1308854562U;
			return 11AE0F91.6A9A2996.C1BF27AF(CA29A81C, 2B3A3819);
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x000657F8 File Offset: 0x000633F8
		public static 11AE0F91.80068AA5 6CA30927(11AE0F91.80068AA5 B6237188, 11AE0F91.80068AA5 F68039A8)
		{
			uint num2;
			for (;;)
			{
				int size = IntPtr.Size;
				int num = 4;
				num2 = 3333971603U;
				if (size != num)
				{
					break;
				}
				if (num2 < 3976909203U)
				{
					goto Block_1;
				}
			}
			num2 *= 4238763686U;
			num2 = 3879229591U << (int)num2;
			return 11AE0F91.6A9A2996.1126E12A(B6237188, F68039A8);
			Block_1:
			num2 |= 471679532U;
			return 11AE0F91.CB943E91.1127EB82(B6237188, F68039A8);
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00065790 File Offset: 0x00063390
		public static 11AE0F91.80068AA5 16932F8C(11AE0F91.80068AA5 DD913F9F, 11AE0F91.80068AA5 F530AE2E)
		{
			uint num = 2986972085U;
			if (num - 2166092423U != 0U)
			{
				int size = IntPtr.Size;
				num -= 3745219737U;
				uint num2 = num ^ 3536719640U;
				num = 925467446U % num;
				if (size == num2)
				{
					num ^= 1236644516U;
					return 11AE0F91.CB943E91.041A47B4(DD913F9F, F530AE2E);
				}
				num = 252355106U / num;
			}
			num = (1410686488U & num);
			return 11AE0F91.6A9A2996.1E2BD10B(DD913F9F, F530AE2E);
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00065358 File Offset: 0x00062F58
		public override short C6A6922C()
		{
			return this.6A341B3D.C6A6922C();
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00065378 File Offset: 0x00062F78
		public override int 30B7A98C()
		{
			uint num = 1697368483U;
			num ^= 305502361U;
			11AE0F91.80068AA5 80068AA = this.6A341B3D;
			num = 1493681163U >> (int)num;
			return 80068AA.30B7A98C();
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00065268 File Offset: 0x00062E68
		public override object D697DB31()
		{
			uint num = 2240009985U;
			num ^= 2995342594U;
			IntPtr cc13ED = this.CC13ED26;
			num /= 3173177619U;
			return cc13ED;
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00065170 File Offset: 0x00062D70
		public 8A270C3B(IntPtr B68DCD80)
		{
			uint num = 4113376296U;
			base..ctor();
			do
			{
				num = 2501065353U % num;
				num += 1302648967U;
				this.CC13ED26 = B68DCD80;
				num >>= 14;
				this.6A341B3D = 11AE0F91.8A270C3B.C416A81D(this.CC13ED26);
			}
			while (2869891851U < num);
		}

		// Token: 0x0400021B RID: 539
		private 11AE0F91.80068AA5 6A341B3D;

		// Token: 0x0400021C RID: 540
		private IntPtr CC13ED26;
	}

	// Token: 0x02000189 RID: 393
	private sealed class 5F827F8F
	{
		// Token: 0x06000594 RID: 1428 RVA: 0x00066CCC File Offset: 0x000648CC
		public List<11AE0F91.628F1DA3> 3B1EF53A()
		{
			return this.E1060F3C;
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x00066BB4 File Offset: 0x000647B4
		public int BD34EE0E()
		{
			return this.F6386E07;
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x00066BD0 File Offset: 0x000647D0
		public int 67B53191(11AE0F91.5F827F8F 2B840A94)
		{
			uint num;
			for (;;)
			{
				num = 2526887991U;
				if (2B840A94 == null)
				{
					break;
				}
				num = 799838764U + num;
				num = 3977156004U * num;
				int value = 2B840A94.0110ADB4();
				num = 470516400U * num;
				int num2 = this.1E0C2B1B.CompareTo(value);
				num = 1144225082U >> (int)num;
				int num3 = num2;
				num |= 579864078U;
				if (num3 == 0)
				{
					if (num == 2250729480U)
					{
						continue;
					}
					num ^= 1284880390U;
					int num4 = 2B840A94.BD34EE0E();
					num = 17287486U << (int)num;
					int num5 = num4;
					num3 = num5.CompareTo(this.F6386E07);
					num += 682852158U;
				}
				num = 2411256603U * num;
				if (num <= 2242817703U)
				{
					return num3;
				}
			}
			num /= 2786272897U;
			return (int)(num + 1U);
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x00066C94 File Offset: 0x00064894
		public void 95AC6191(byte EF0E4784, int DD249D02, int F3B79734)
		{
			uint num = 3895135493U;
			List<11AE0F91.628F1DA3> e1060F3C = this.E1060F3C;
			num = 2374748941U % num;
			11AE0F91.628F1DA3 item = new 11AE0F91.628F1DA3(EF0E4784, DD249D02, F3B79734);
			num = 1840479767U / num;
			e1060F3C.Add(item);
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x00066B90 File Offset: 0x00064790
		public int 0110ADB4()
		{
			uint num = 1723472135U;
			num /= 2352753854U;
			return this.1E0C2B1B;
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x00066B2C File Offset: 0x0006472C
		public 5F827F8F(int 71AC5811, int 6F932922)
		{
			uint num;
			do
			{
				base..ctor();
				num = 948008488U;
				this.1E0C2B1B = 71AC5811;
				num = 1696558081U >> (int)num;
				num %= 2518683048U;
				num = 4013718206U + num;
				this.F6386E07 = 6F932922;
			}
			while (-1416314974 << (int)num == 0);
		}

		// Token: 0x0400026A RID: 618
		private List<11AE0F91.628F1DA3> E1060F3C = new List<11AE0F91.628F1DA3>();

		// Token: 0x0400026B RID: 619
		private int F6386E07;

		// Token: 0x0400026C RID: 620
		private int 1E0C2B1B;
	}

	// Token: 0x0200018B RID: 395
	private sealed class 281DB71D : 11AE0F91.80068AA5
	{
		// Token: 0x0600059B RID: 1435 RVA: 0x00063850 File Offset: 0x00061450
		public override void 7E869424(object C020EC03)
		{
			uint num;
			do
			{
				num = 4262694550U;
				this.A11FA611 = Convert.ToSByte(C020EC03);
			}
			while (num == 1244174634U);
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00063810 File Offset: 0x00061410
		public override 11AE0F91.80068AA5 ECAA59A1()
		{
			return new 11AE0F91.281DB71D(this.A11FA611);
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00063920 File Offset: 0x00061520
		public override uint 98A2A683()
		{
			return (uint)this.A11FA611;
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x000637F8 File Offset: 0x000613F8
		public override Type 20129380()
		{
			return typeof(sbyte);
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x000638C0 File Offset: 0x000614C0
		public override byte B508A9AB()
		{
			return (byte)this.A11FA611;
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00063934 File Offset: 0x00061534
		public static 11AE0F91.80068AA5 62820902(11AE0F91.80068AA5 47B6BF88)
		{
			uint num2;
			int num5;
			for (;;)
			{
				IL_00:
				ulong num = 47B6BF88.6D84E72D();
				num2 = 4177676349U;
				ulong num3 = num;
				num2 = 1956638361U % num2;
				if (67385762U < num2)
				{
					for (;;)
					{
						bool flag = (47B6BF88.3BA55C01() & (int)(num2 + 2338328939U)) > (int)(num2 ^ 1956638361U);
						int num4 = (int)(num2 ^ 1956638361U);
						num2 = (881784982U ^ num2);
						num5 = num4;
						if (1554524551U <= num2)
						{
							goto IL_00;
						}
						long num6 = (long)num3;
						num2 ^= 1388015883U;
						if (num6 <= (long)(num2 ^ 313157499U))
						{
							num2 *= 2594115889U;
							if (flag)
							{
								break;
							}
							if (3121076670U == num2)
							{
								goto IL_00;
							}
							sbyte b = (sbyte)num3;
							uint num7 = num2 - 1190198340U;
							num2 += 0U;
							if (b >= num7)
							{
								break;
							}
							num2 ^= 1415224512U;
						}
						if (1975308221U >> (int)num2 != 0U)
						{
							goto Block_5;
						}
					}
					IL_CC:
					if (num2 * 3534464794U == 0U)
					{
						continue;
					}
					int e99A = (int)((sbyte)num3);
					num2 = (1325446954U & num2);
					47B6BF88 = new 11AE0F91.CB943E91(e99A);
					if (num2 != 430578578U)
					{
						break;
					}
					continue;
					Block_5:
					int num8 = num5;
					num2 >>= 18;
					num5 = (num8 | (int)(num2 ^ 1210U));
					num2 ^= 1190199150U;
					goto IL_CC;
				}
			}
			11AE0F91.80068AA5 80068AA = 47B6BF88;
			num2 >>= 10;
			int c7A9131D = num5;
			num2 <<= 2;
			80068AA.3F831A1B(c7A9131D);
			return 47B6BF88;
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00063830 File Offset: 0x00061430
		public override object D697DB31()
		{
			return this.A11FA611;
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x0006390C File Offset: 0x0006150C
		public override int 30B7A98C()
		{
			return (int)this.A11FA611;
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x000638DC File Offset: 0x000614DC
		public override short C6A6922C()
		{
			return (short)this.A11FA611;
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x000638F0 File Offset: 0x000614F0
		public override ushort CF9960A3()
		{
			return (ushort)this.A11FA611;
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x0006387C File Offset: 0x0006147C
		public override 11AE0F91.6012BE05 04A04CBD()
		{
			uint num = 3920591278U;
			int e99A = this.30B7A98C();
			num ^= 2401605508U;
			return new 11AE0F91.CB943E91(e99A);
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x000638A4 File Offset: 0x000614A4
		public override sbyte 482F2014()
		{
			return this.A11FA611;
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x000637A8 File Offset: 0x000613A8
		public 281DB71D(sbyte A7BD3106)
		{
			uint num;
			do
			{
				num = 3306696456U;
				base..ctor();
			}
			while ((1512624550U ^ num) == 0U);
			do
			{
				num = 901615131U << (int)num;
				num >>= 31;
				this.A11FA611 = A7BD3106;
			}
			while (4164441004U == num);
		}

		// Token: 0x0400026D RID: 621
		private sbyte A11FA611;
	}

	// Token: 0x02000192 RID: 402
	private abstract class FCB842B2 : 11AE0F91.6012BE05
	{
		// Token: 0x060005B0 RID: 1456 RVA: 0x000645F4 File Offset: 0x000621F4
		protected FCB842B2()
		{
			uint num;
			do
			{
				num = 1168083263U;
				base..ctor();
			}
			while (2399692186U < num);
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x000645D8 File Offset: 0x000621D8
		public override bool FC990F28()
		{
			uint num = 1496404115U;
			return (num ^ 1496404114U) != 0U;
		}
	}

	// Token: 0x020001A8 RID: 424
	private sealed class 4422B13D : 11AE0F91.80068AA5
	{
		// Token: 0x060005EA RID: 1514 RVA: 0x00063EAC File Offset: 0x00061AAC
		public override int 30B7A98C()
		{
			return (int)this.968B8022;
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x00063E74 File Offset: 0x00061A74
		public override short C6A6922C()
		{
			return (short)this.968B8022;
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00063F18 File Offset: 0x00061B18
		public override ulong 6D84E72D()
		{
			uint num = 4248229816U;
			num = 1359886986U * num;
			return this.968B8022;
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x00063D98 File Offset: 0x00061998
		public override 11AE0F91.80068AA5 ECAA59A1()
		{
			uint num = 1208219298U;
			ulong 9939B02E = this.968B8022;
			num |= 2686471203U;
			return new 11AE0F91.4422B13D(9939B02E);
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x00063E48 File Offset: 0x00061A48
		public override byte B508A9AB()
		{
			uint num = 3768589441U;
			num += 3213870110U;
			byte b = (byte)this.968B8022;
			num /= 2962072453U;
			return b;
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x00063EC8 File Offset: 0x00061AC8
		public override uint 98A2A683()
		{
			uint num = 446906498U;
			num = 2198507667U - num;
			uint num2 = (uint)this.968B8022;
			num = (4089045306U & num);
			return num2;
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x00063E14 File Offset: 0x00061A14
		public override 11AE0F91.6012BE05 04A04CBD()
		{
			return new 11AE0F91.6A9A2996(this.D20998B6());
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x00063DE8 File Offset: 0x000619E8
		public override void 7E869424(object 3C354D34)
		{
			uint num2;
			do
			{
				ulong num = Convert.ToUInt64(3C354D34);
				num2 = 3592443777U;
				this.968B8022 = num;
			}
			while (1453023658U == num2);
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x00063DC0 File Offset: 0x000619C0
		public override object D697DB31()
		{
			uint num = 2537474993U;
			ulong num2 = this.968B8022;
			num = (3332476217U & num);
			return num2;
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x00063E2C File Offset: 0x00061A2C
		public override sbyte 482F2014()
		{
			return (sbyte)this.968B8022;
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00063EF4 File Offset: 0x00061AF4
		public override long D20998B6()
		{
			uint num = 3700600214U;
			num -= 236206257U;
			return (long)this.968B8022;
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00063E90 File Offset: 0x00061A90
		public override ushort CF9960A3()
		{
			return (ushort)this.968B8022;
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x00063D80 File Offset: 0x00061980
		public override Type 20129380()
		{
			return typeof(ulong);
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x00063F3C File Offset: 0x00061B3C
		public static 11AE0F91.80068AA5 E50C09B0(11AE0F91.80068AA5 5891ED90)
		{
			uint num = 1646202155U;
			for (;;)
			{
				11AE0F91.80068AA5 80068AA = 5891ED90;
				num -= 1537607598U;
				ulong num2 = 80068AA.6D84E72D();
				num -= 1538107932U;
				ulong num3 = num2;
				num = 3951910953U - num;
				if (num > 82491U)
				{
					11AE0F91.80068AA5 80068AA2 = 5891ED90;
					num &= 4036857746U;
					uint num4 = 80068AA2.3BA55C01();
					num &= 3389023422U;
					uint num5 = num4 & (num ^ 1073742980U);
					num >>= 2;
					uint num6 = num ^ 268435744U;
					num = (3594262046U ^ num);
					bool flag = num5 > num6;
					num = 555618193U + num;
					int num7 = (int)(num + 413522225U);
					if (!flag)
					{
						num += 496037176U;
						ulong num8 = num3;
						num = (2577196428U & num);
						long maxValue = long.MaxValue;
						num = 1446028438U * num;
						num += 1549089911U;
						if (num8 > maxValue)
						{
							num &= 1896673320U;
							int num9 = num7;
							int num10 = (int)(num ^ 1627922456U);
							num = 2451346945U >> (int)num;
							int num11 = num9 | num10;
							num = (2443347625U & num);
							num7 = num11;
							num += 3872924239U;
						}
					}
					num <<= 8;
					11AE0F91.80068AA5 80068AA3 = new 11AE0F91.6A9A2996((long)num3);
					num = (967788694U ^ num);
					5891ED90 = 80068AA3;
					5891ED90.3F831A1B(num7);
					num *= 679898940U;
					if (num <= 2116925318U)
					{
						break;
					}
				}
			}
			return 5891ED90;
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x00063D58 File Offset: 0x00061958
		public 4422B13D(ulong 9939B02E)
		{
			uint num = 2033906320U;
			num = (1334153917U & num);
			this.968B8022 = 9939B02E;
		}

		// Token: 0x0400028B RID: 651
		private ulong 968B8022;
	}

	// Token: 0x020001B0 RID: 432
	private sealed class 56055C27
	{
		// Token: 0x06000606 RID: 1542 RVA: 0x0005D898 File Offset: 0x0005B498
		public byte 749BD5AB()
		{
			uint num = 210450208U;
			num <<= 19;
			byte[] e005DBAD = this.E005DBAD;
			num ^= 1857058585U;
			num = 4085501584U << (int)num;
			int d73AC = this.D73AC625;
			num = (3239213066U & num);
			int num2 = d73AC;
			int num3 = num2;
			num = 423263500U - num;
			int num4 = (int)(num + 3871703797U);
			num = (564430228U & num);
			this.D73AC625 = num3 + num4;
			int num5 = num2;
			num = (873319688U | num);
			return e005DBAD[num5];
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x0005DC64 File Offset: 0x0005B864
		public Type F6146116(Module B5987F20)
		{
			uint num;
			Type type;
			for (;;)
			{
				IL_00:
				num = 2432767121U;
				bool flag = (num ^ 2432767121U) != 0U;
				for (;;)
				{
					num %= 1444731046U;
					bool flag2 = num - 988036074U != 0U;
					if (num == 2415989267U)
					{
						goto IL_62;
					}
					IL_1A8:
					num ^= 4102273323U;
					if ((num ^ 2016162475U) == 0U)
					{
						continue;
					}
					bool flag3 = flag2;
					num ^= 705880856U;
					11AE0F91.56055C27.5404AE0F 5404AE0F;
					if (!flag3)
					{
						num = 3911370664U % num;
						if (1326186667U == num)
						{
							goto IL_2A;
						}
						5404AE0F = (11AE0F91.56055C27.5404AE0F)this.0428FF10();
						if (4238660260U <= num)
						{
							goto IL_48;
						}
						switch (5404AE0F)
						{
						case 11AE0F91.56055C27.5404AE0F.6988A01B:
							num = (3608650283U & num);
							type = null;
							goto IL_76E;
						case 11AE0F91.56055C27.5404AE0F.97928185:
						{
							num %= 2174148285U;
							RuntimeTypeHandle handle = typeof(void).TypeHandle;
							num = 270423818U >> (int)num;
							type = Type.GetTypeFromHandle(handle);
							if ((93536303U ^ num) != 0U)
							{
								num ^= 67448862U;
								goto IL_76E;
							}
							goto IL_00;
						}
						case 11AE0F91.56055C27.5404AE0F.7F058928:
						{
							RuntimeTypeHandle handle2 = typeof(bool).TypeHandle;
							num = 3132792869U % num;
							type = Type.GetTypeFromHandle(handle2);
							num ^= 5586293U;
							goto IL_76E;
						}
						case 11AE0F91.56055C27.5404AE0F.7017218C:
							if (327441295U > num)
							{
								RuntimeTypeHandle handle3 = typeof(char).TypeHandle;
								num %= 345272106U;
								Type typeFromHandle = Type.GetTypeFromHandle(handle3);
								num <<= 26;
								type = typeFromHandle;
								num ^= 1141186560U;
								goto IL_76E;
							}
							goto IL_00;
						case 11AE0F91.56055C27.5404AE0F.9C37F7AD:
						{
							RuntimeTypeHandle handle4 = typeof(sbyte).TypeHandle;
							num = 805632172U - num;
							Type typeFromHandle2 = Type.GetTypeFromHandle(handle4);
							num = 3510125369U << (int)num;
							type = typeFromHandle2;
							num += 1946492928U;
							goto IL_76E;
						}
						case 11AE0F91.56055C27.5404AE0F.6894B696:
						{
							num = (3484445630U & num);
							RuntimeTypeHandle handle5 = typeof(byte).TypeHandle;
							num = 379888551U >> (int)num;
							Type typeFromHandle3 = Type.GetTypeFromHandle(handle5);
							num = 2914658062U + num;
							type = typeFromHandle3;
							num += 1447748174U;
							goto IL_76E;
						}
						case 11AE0F91.56055C27.5404AE0F.3EB6920D:
						{
							if (1218621740U < num)
							{
								goto IL_00;
							}
							RuntimeTypeHandle handle6 = typeof(short).TypeHandle;
							num = 2416220086U % num;
							type = Type.GetTypeFromHandle(handle6);
							if (num != 4044619817U)
							{
								num += 5404330U;
								goto IL_76E;
							}
							goto IL_00;
						}
						case 11AE0F91.56055C27.5404AE0F.270E7DB0:
						{
							num = 1493415342U << (int)num;
							Type typeFromHandle4 = typeof(ushort);
							num = 1420450571U >> (int)num;
							type = typeFromHandle4;
							num ^= 1353677579U;
							goto IL_76E;
						}
						case 11AE0F91.56055C27.5404AE0F.9C186C3E:
						{
							RuntimeTypeHandle handle7 = typeof(int).TypeHandle;
							num ^= 3316238475U;
							Type typeFromHandle5 = Type.GetTypeFromHandle(handle7);
							num &= 2796558900U;
							type = typeFromHandle5;
							if (3842308751U != num)
							{
								num += 2214926320U;
								goto IL_76E;
							}
							goto IL_00;
						}
						case 11AE0F91.56055C27.5404AE0F.7599E029:
							type = typeof(uint);
							if (num < 1090606106U)
							{
								num ^= 11027920U;
								goto IL_76E;
							}
							continue;
						case 11AE0F91.56055C27.5404AE0F.6D2790A4:
						{
							num ^= 4129944086U;
							RuntimeTypeHandle handle8 = typeof(long).TypeHandle;
							num /= 470780950U;
							Type typeFromHandle6 = Type.GetTypeFromHandle(handle8);
							num = 2779957271U * num;
							type = typeFromHandle6;
							if (num >= 286166547U)
							{
								num ^= 697524408U;
								goto IL_76E;
							}
							goto IL_00;
						}
						case 11AE0F91.56055C27.5404AE0F.B28A8EA4:
						{
							RuntimeTypeHandle handle9 = typeof(ulong).TypeHandle;
							num = (12289316U & num);
							type = Type.GetTypeFromHandle(handle9);
							if ((1158039594U & num) == 0U)
							{
								num += 56367872U;
								goto IL_76E;
							}
							goto IL_00;
						}
						case 11AE0F91.56055C27.5404AE0F.E2052517:
							num <<= 17;
							if (num > 413038643U)
							{
								type = typeof(float);
								num += 946151424U;
								goto IL_76E;
							}
							goto IL_00;
						case 11AE0F91.56055C27.5404AE0F.0F87B716:
							if (num % 3626457642U != 0U)
							{
								type = typeof(double);
								num += 4283939376U;
								goto IL_76E;
							}
							continue;
						case 11AE0F91.56055C27.5404AE0F.A8262E20:
							type = typeof(string);
							num += 4283939376U;
							goto IL_76E;
						case 11AE0F91.56055C27.5404AE0F.6326F60D:
							if (1696283167U / num != 0U)
							{
								num >>= 17;
								Type type2 = this.F6146116(B5987F20);
								num = 873261242U + num;
								Type type3 = type2.MakePointerType();
								num = 3517308204U % num;
								type = type3;
								num ^= 91689196U;
								goto IL_76E;
							}
							goto IL_00;
						case 11AE0F91.56055C27.5404AE0F.DB83F5BF:
						case 11AE0F91.56055C27.5404AE0F.68168B8C:
						case 11AE0F91.56055C27.5404AE0F.7FA6EEA8:
						case 11AE0F91.56055C27.5404AE0F.950A93AE:
						case 11AE0F91.56055C27.5404AE0F.F2351899:
						case 11AE0F91.56055C27.5404AE0F.8288EE3B:
						case 11AE0F91.56055C27.5404AE0F.4693FD05:
						case 11AE0F91.56055C27.5404AE0F.D2285D85:
							goto IL_750;
						case 11AE0F91.56055C27.5404AE0F.DABA961C:
						case 11AE0F91.56055C27.5404AE0F.AA00FD91:
						{
							num = 3911312000U << (int)num;
							num *= 4205694911U;
							uint num2 = this.0428FF10();
							num ^= 3692832152U;
							uint num3 = num2;
							num /= 478486435U;
							if (num >= 3231147957U)
							{
								goto IL_2F;
							}
							uint num4 = num3;
							num <<= 8;
							uint num5 = num4 & num + 4294966019U;
							num = (3071182779U | num);
							uint num6 = num5;
							num = (380693937U ^ num);
							uint num7;
							switch (num6)
							{
							case 0U:
								num7 = (num ^ 2747165194U);
								break;
							case 1U:
							{
								uint num8 = num + 1598133750U;
								num = 2477293992U % num;
								num7 = num8;
								num += 236316770U;
								break;
							}
							case 2U:
							{
								num = 230552879U >> (int)num;
								uint num9 = num ^ 453209981U;
								num = (514285830U & num);
								num7 = num9;
								if (num / 1904819329U != 0U)
								{
									goto IL_2A;
								}
								num += 2713389318U;
								break;
							}
							default:
								if (1544026664U >= num)
								{
									goto IL_00;
								}
								num7 = (num ^ 2713610762U);
								num += 0U;
								break;
							}
							int num10 = (int)num7;
							uint num11 = num3;
							num = 3122771007U >> (int)num;
							int metadataToken = num10 | num11 >> (int)(num + 4291917717U);
							num += 3878508326U;
							type = B5987F20.ResolveType(metadataToken);
							if (num % 2064525972U != 0U)
							{
								num ^= 3814653843U;
								goto IL_76E;
							}
							goto IL_00;
						}
						case 11AE0F91.56055C27.5404AE0F.7B9BF401:
						{
							num |= 4070855969U;
							Type typeFromHandle7 = typeof(IntPtr);
							num |= 4069440683U;
							type = typeFromHandle7;
							num += 223683077U;
							goto IL_76E;
						}
						case 11AE0F91.56055C27.5404AE0F.9AAD33AC:
							type = typeof(UIntPtr);
							if ((235940230U ^ num) != 0U)
							{
								num += 4283939376U;
								goto IL_76E;
							}
							goto IL_7C;
						case 11AE0F91.56055C27.5404AE0F.8780C194:
						{
							num = 227738649U / num;
							Type typeFromHandle8 = typeof(object);
							num -= 932972548U;
							type = typeFromHandle8;
							if (3829164550U % num != 0U)
							{
								num += 1000417282U;
								goto IL_76E;
							}
							goto IL_00;
						}
						case 11AE0F91.56055C27.5404AE0F.73862490:
						{
							num = (1780347028U ^ num);
							if (num % 1377396376U == 0U)
							{
								goto IL_00;
							}
							num *= 2016919231U;
							num += 161180450U;
							Type type4 = this.F6146116(B5987F20);
							num = 2971091126U % num;
							type = type4.MakeArrayType();
							if (num << 22 != 0U)
							{
								num ^= 357752792U;
								goto IL_76E;
							}
							goto IL_00;
						}
						}
						goto Block_13;
						IL_76E:
						if (3296866568U > num)
						{
							break;
						}
						continue;
					}
					IL_2F:
					11AE0F91.56055C27.5404AE0F 5404AE0F2 = (11AE0F91.56055C27.5404AE0F)this.749BD5AB();
					num = 4237184033U;
					5404AE0F = 5404AE0F2;
					if (322552362U >= num)
					{
						continue;
					}
					IL_48:
					if (5404AE0F <= (11AE0F91.56055C27.5404AE0F)(num ^ 4237184001U))
					{
						if (4195214607U + num != 0U)
						{
							goto IL_62;
						}
						goto IL_00;
					}
					else
					{
						11AE0F91.56055C27.5404AE0F 5404AE0F3 = 5404AE0F;
						uint num12 = num + 57783328U;
						num ^= 3328866250U;
						if (5404AE0F3 != num12)
						{
							if (1394478106U != num)
							{
								11AE0F91.56055C27.5404AE0F 5404AE0F4 = 5404AE0F;
								uint num13 = num ^ 988036014U;
								num += 0U;
								if (5404AE0F4 != num13)
								{
									if (4097697419U > num)
									{
										num += 1198764617U;
										goto IL_158;
									}
									goto IL_00;
								}
							}
						}
					}
					IL_2A:
					goto IL_1A8;
					IL_62:
					if (5404AE0F == (11AE0F91.56055C27.5404AE0F)(num - 4237184017U))
					{
						num /= 495609625U;
						flag = (num + 4294967289U != 0U);
						num += 988036067U;
						goto IL_1A8;
					}
					if (num << 29 == 0U)
					{
						goto IL_48;
					}
					IL_7C:
					11AE0F91.56055C27.5404AE0F 5404AE0F5 = 5404AE0F;
					num += 4240051486U;
					uint num14 = num ^ 4182268192U;
					num = 3045679786U * num;
					object obj = 5404AE0F5 - (11AE0F91.56055C27.5404AE0F)num14;
					num = 1831648167U >> (int)num;
					uint num15 = num - 435U;
					num *= 310391713U;
					if (obj <= num15)
					{
						this.0428FF10();
						num = 4239254456U << (int)num;
						num += 4284759019U;
						goto IL_1A8;
					}
					if (num - 1586470964U == 0U)
					{
						goto IL_00;
					}
					IL_158:
					num |= 2537254660U;
					flag2 = (num - 2541743924U != 0U);
					if (330170128U * num != 0U)
					{
						num /= 3322349853U;
						int d73AC = this.D73AC625;
						int num16 = (int)(num - uint.MaxValue);
						num += 128458369U;
						int d73AC2 = d73AC - num16;
						num &= 3769445677U;
						this.D73AC625 = d73AC2;
						num += 977022954U;
						goto IL_1A8;
					}
					goto IL_00;
				}
				bool flag4 = flag;
				num = 1697570722U * num;
				if (!flag4)
				{
					return type;
				}
				num >>= 9;
				if (num != 2947487007U)
				{
					goto Block_36;
				}
			}
			Block_13:
			num += 0U;
			IL_750:
			num = (3904456340U & num);
			string message = null;
			int errorCode = (int)(num - 2157326921U);
			num /= 322089858U;
			throw new COMException(message, errorCode);
			Block_36:
			Type type5 = type;
			num = 1681820573U << (int)num;
			Type type6 = type5.MakeByRefType();
			num /= 1077852844U;
			type = type6;
			num += 3256762367U;
			return type;
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x0005D908 File Offset: 0x0005B508
		public uint 0428FF10()
		{
			uint num = 429000832U;
			uint result;
			do
			{
				IL_06:
				byte[] e005DBAD = this.E005DBAD;
				num = 3087691193U * num;
				byte b = e005DBAD[this.D73AC625];
				num = 2894518273U * num;
				byte b2 = b;
				num = 3600409509U + num;
				bool flag = b2 != 0;
				bool flag2 = num + 1987278939U != 0U;
				num = 4262290305U + num;
				if (!flag || !flag2)
				{
					num = 2879617950U / num;
					if (2551172267U / num == 0U)
					{
						continue;
					}
					do
					{
						num = (277477933U ^ num);
						byte[] e005DBAD2 = this.E005DBAD;
						num += 1044362160U;
						int d73AC = this.D73AC625;
						num <<= 7;
						uint num2 = e005DBAD2[d73AC];
						uint num3 = num + 2603160191U;
						num = (4145383813U & num);
						uint num4 = num2 & num3;
						num = 2769068695U % num;
						result = num4;
						num *= 4197362187U;
						if (num == 3267129641U)
						{
							goto IL_06;
						}
						num -= 859587500U;
						int d73AC2 = this.D73AC625 + (int)(num + 1774770480U);
						num = 1854095772U / num;
						this.D73AC625 = d73AC2;
					}
					while (2662922771U == num);
				}
				else
				{
					bool flag3 = b2 != 0;
					num = (2173189042U | num);
					bool flag4 = ((flag3 ? 1U : 0U) & num - 2275015542U) != 0U;
					num = 1737651516U % num;
					if (!flag4)
					{
						num = 3517339301U / num;
						byte[] e005DBAD3 = this.E005DBAD;
						num &= 663789859U;
						int d73AC3 = this.D73AC625;
						num = 2233807876U % num;
						uint num5 = e005DBAD3[d73AC3];
						num /= 2955658757U;
						uint num6 = num + 63U;
						num ^= 2374181026U;
						uint num7 = num5 & num6;
						num = 1402226080U / num;
						int num8 = (int)(num ^ 8U);
						num = 3407917858U - num;
						uint num9 = num7 << num8;
						num = 2402852745U + num;
						byte[] e005DBAD4 = this.E005DBAD;
						num = (1646257668U & num);
						int d73AC4 = this.D73AC625;
						int num10 = (int)(num ^ 1108951553U);
						num = (1343963394U ^ num);
						result = num9 + e005DBAD4[d73AC4 + num10];
						if (num - 422311430U == 0U)
						{
							continue;
						}
						num = 3156100926U + num;
						num /= 4245153061U;
						int d73AC5 = this.D73AC625;
						num = (1262336659U ^ num);
						int d73AC6 = d73AC5 + (int)(num ^ 1262336657U);
						num = 1670326967U << (int)num;
						this.D73AC625 = d73AC6;
						if (2357862180U >> (int)num == 0U)
						{
							continue;
						}
						num ^= 1438121984U;
					}
					else
					{
						if (num >> 18 == 0U)
						{
							continue;
						}
						num = 3611101956U + num;
						byte[] e005DBAD5 = this.E005DBAD;
						num = 2846777640U - num;
						int d73AC7 = this.D73AC625;
						num >>= 11;
						uint num11 = e005DBAD5[d73AC7];
						num = 3121680950U / num;
						uint num12 = num - 3534U;
						num = 1302985603U >> (int)num;
						uint num13 = num11 & num12;
						num = 479016752U * num;
						int num14 = (int)(num - 1584625592U);
						num %= 1091730455U;
						uint num15 = num13 << num14;
						num %= 1085020810U;
						byte[] e005DBAD6 = this.E005DBAD;
						num >>= 8;
						int d73AC8 = this.D73AC625;
						num = 11320074U >> (int)num;
						int num16 = (int)(num ^ 1U);
						num -= 3490342677U;
						int num17 = d73AC8 + num16;
						num <<= 17;
						uint num18 = e005DBAD6[num17];
						int num19 = (int)(num ^ 836108304U);
						num = 1068433727U / num;
						uint num20 = num18 << num19;
						num |= 1881877767U;
						uint num21 = num15 + num20;
						num = (3557944124U & num);
						num |= 286071182U;
						byte[] e005DBAD7 = this.E005DBAD;
						int d73AC9 = this.D73AC625;
						int num22 = (int)(num + 2935146100U);
						num = 3298732071U >> (int)num;
						uint num23 = e005DBAD7[d73AC9 + num22];
						num = 1094185096U - num;
						uint num24 = num21 + (num23 << (int)(num ^ 1093983750U));
						num &= 2769799828U;
						byte[] e005DBAD8 = this.E005DBAD;
						num = 2259435648U - num;
						result = num24 + e005DBAD8[this.D73AC625 + (int)(num ^ 2241295999U)];
						if (1988987532U % num == 0U)
						{
							continue;
						}
						num = 2996275745U - num;
						this.D73AC625 += (int)(num ^ 754979745U);
						num ^= 754979749U;
					}
				}
			}
			while (270084751U - num == 0U);
			return result;
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x0005D86C File Offset: 0x0005B46C
		public 56055C27(byte[] F73411B5)
		{
			uint num;
			do
			{
				num = 423607359U;
				this.E005DBAD = F73411B5;
			}
			while (1032305326U <= num);
		}

		// Token: 0x0400028C RID: 652
		private int D73AC625;

		// Token: 0x0400028D RID: 653
		private byte[] E005DBAD;

		// Token: 0x020000CC RID: 204
		private enum 5404AE0F
		{
			// Token: 0x0400015E RID: 350
			7599E029 = 9,
			// Token: 0x0400015F RID: 351
			4693FD05 = 26,
			// Token: 0x04000160 RID: 352
			6988A01B = 0,
			// Token: 0x04000161 RID: 353
			E2052517 = 12,
			// Token: 0x04000162 RID: 354
			9AAD33AC = 25,
			// Token: 0x04000163 RID: 355
			9C186C3E = 8,
			// Token: 0x04000164 RID: 356
			9C37F7AD = 4,
			// Token: 0x04000165 RID: 357
			7017218C = 3,
			// Token: 0x04000166 RID: 358
			9B033F35 = 65,
			// Token: 0x04000167 RID: 359
			CA2943A0 = 30,
			// Token: 0x04000168 RID: 360
			B28A8EA4 = 11,
			// Token: 0x04000169 RID: 361
			68168B8C = 19,
			// Token: 0x0400016A RID: 362
			DB83F5BF = 16,
			// Token: 0x0400016B RID: 363
			DABA961C,
			// Token: 0x0400016C RID: 364
			7F058928 = 2,
			// Token: 0x0400016D RID: 365
			A8262E20 = 14,
			// Token: 0x0400016E RID: 366
			AA00FD91 = 18,
			// Token: 0x0400016F RID: 367
			0F87B716 = 13,
			// Token: 0x04000170 RID: 368
			DD3F5F34 = 31,
			// Token: 0x04000171 RID: 369
			6894B696 = 5,
			// Token: 0x04000172 RID: 370
			7FA6EEA8 = 20,
			// Token: 0x04000173 RID: 371
			270E7DB0 = 7,
			// Token: 0x04000174 RID: 372
			F2351899 = 22,
			// Token: 0x04000175 RID: 373
			7B9BF401 = 24,
			// Token: 0x04000176 RID: 374
			3EB6920D = 6,
			// Token: 0x04000177 RID: 375
			97928185 = 1,
			// Token: 0x04000178 RID: 376
			6D2790A4 = 10,
			// Token: 0x04000179 RID: 377
			8D281826 = 32,
			// Token: 0x0400017A RID: 378
			73862490 = 29,
			// Token: 0x0400017B RID: 379
			D2285D85 = 27,
			// Token: 0x0400017C RID: 380
			C880B42D = 69,
			// Token: 0x0400017D RID: 381
			6326F60D = 15,
			// Token: 0x0400017E RID: 382
			950A93AE = 21,
			// Token: 0x0400017F RID: 383
			8288EE3B = 23,
			// Token: 0x04000180 RID: 384
			8780C194 = 28
		}
	}

	// Token: 0x020001B2 RID: 434
	private abstract class 1280CA96
	{
		// Token: 0x0600060C RID: 1548
		public abstract void 37242F0A(int 301C73A4);

		// Token: 0x0600060D RID: 1549
		public abstract int B395DB29();
	}

	// Token: 0x020001B8 RID: 440
	private sealed class 5F355D3D : 11AE0F91.1280CA96
	{
		// Token: 0x06000616 RID: 1558 RVA: 0x00067640 File Offset: 0x00065240
		public 11AE0F91.80068AA5 252E6C8E(int 24058B80)
		{
			uint num = (uint)24058B80;
			uint num2 = 2282206102U;
			if (num >= num2 + 2012761194U)
			{
				goto IL_62;
			}
			num2 = 985261712U + num2;
			IL_1B:
			int num3 = 24058B80;
			num2 = 3943950465U * num2;
			List<11AE0F91.80068AA5> bdb1E = this.BDB1E229;
			num2 = 4204673588U - num2;
			int count = bdb1E.Count;
			num2 *= 3030161194U;
			int num4 = (int)(num2 ^ 1367213645U);
			num2 = 3005493904U % num2;
			int num5 = num3 + (count - num4);
			num2 = 2435171124U - num2;
			24058B80 = num5;
			num2 += 118101594U;
			IL_62:
			if (num2 >= 1787535617U)
			{
				num2 = (3283977241U | num2);
				List<11AE0F91.80068AA5> bdb1E2 = this.BDB1E229;
				num2 = 1302630436U << (int)num2;
				return bdb1E2[24058B80];
			}
			goto IL_1B;
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x000675D8 File Offset: 0x000651D8
		public 11AE0F91.80068AA5 8827D009()
		{
			uint num;
			int num4;
			do
			{
				List<11AE0F91.80068AA5> bdb1E = this.BDB1E229;
				num = 646251533U;
				int count = bdb1E.Count;
				int num2 = (int)(num + 3648715764U);
				num = 2617249840U / num;
				int num3 = count - num2;
				num -= 2243002883U;
				num4 = num3;
			}
			while (num << 27 == 0U);
			num = 1948373149U >> (int)num;
			List<11AE0F91.80068AA5> bdb1E2 = this.BDB1E229;
			int index = num4;
			num = 389663898U + num;
			return bdb1E2[index];
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x00067544 File Offset: 0x00065144
		public 11AE0F91.80068AA5 F3AC8C0D()
		{
			uint num = 2281888385U;
			num = (2424950912U & num);
			int count = this.BDB1E229.Count;
			num |= 1243302577U;
			int num2 = (int)(num ^ 3390823088U);
			num <<= 6;
			int num3 = count - num2;
			num = 1343223972U << (int)num;
			int num4 = num3;
			num = 3241645312U >> (int)num;
			11AE0F91.80068AA5 result = this.BDB1E229[num4];
			num /= 3072451756U;
			num /= 2105968641U;
			List<11AE0F91.80068AA5> bdb1E = this.BDB1E229;
			num += 3296969239U;
			int index = num4;
			num *= 2853455802U;
			bdb1E.RemoveAt(index);
			return result;
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x000676DC File Offset: 0x000652DC
		public 11AE0F91.80068AA5 5C817C1A(int FE154B39, 11AE0F91.80068AA5 B7A6881B)
		{
			int num = FE154B39;
			int num2 = 0;
			uint num3 = 488204458U;
			if (num < num2)
			{
				if (3896098620U == num3)
				{
					return B7A6881B;
				}
				int num4 = FE154B39;
				num3 |= 738776106U;
				int count = this.BDB1E229.Count;
				int num5 = (int)(num3 + 3269854039U);
				num3 = 322933817U - num3;
				FE154B39 = num4 + (count - num5);
				num3 ^= 3409772325U;
			}
			num3 = 806439424U << (int)num3;
			List<11AE0F91.80068AA5> bdb1E = this.BDB1E229;
			int index = FE154B39;
			num3 = (2433579314U ^ num3);
			bdb1E[index] = B7A6881B;
			num3 = 2752655129U % num3;
			return B7A6881B;
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x00067504 File Offset: 0x00065104
		public void 07A52495(11AE0F91.80068AA5 268B972E)
		{
			uint num;
			do
			{
				num = 3859096888U;
				List<11AE0F91.80068AA5> bdb1E = this.BDB1E229;
				num = 478532518U / num;
				num -= 2905493297U;
				bdb1E.Add(268B972E.04A04CBD());
			}
			while (1554945040U / num == 0U);
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x00067408 File Offset: 0x00065008
		public override void 37242F0A(int 81AE8419)
		{
			uint num = 1250166922U;
			if ((1026498111U ^ num) != 0U)
			{
				this.711FD593 = 81AE8419;
			}
			int num2 = (int)(num + 3044800374U);
			if (num != 3299418643U)
			{
				goto IL_6C;
			}
			IL_4A:
			int num3 = num2;
			int num4 = (int)(num ^ 1595524129U);
			num = 322097582U % num;
			int num5 = num3 + num4;
			num = (4086181166U & num);
			num2 = num5;
			num ^= 1501956516U;
			IL_6C:
			int num6 = num2;
			num = (1010023462U ^ num);
			int num7 = this.711FD593;
			num <<= 5;
			if (num6 >= num7)
			{
				return;
			}
			List<11AE0F91.80068AA5> bdb1E = this.BDB1E229;
			num = 1595524128U;
			bdb1E.Insert((int)(num + 2699443168U), null);
			goto IL_4A;
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x000674A0 File Offset: 0x000650A0
		public void 0D034593()
		{
			for (;;)
			{
				uint num = 630921663U;
				List<11AE0F91.80068AA5> bdb1E = this.BDB1E229;
				num = 1160044056U >> (int)num;
				int count = bdb1E.Count;
				int num2 = this.711FD593;
				num = (70186892U ^ num);
				if (count <= num2)
				{
					break;
				}
				List<11AE0F91.80068AA5> bdb1E2 = this.BDB1E229;
				num = 19587335U;
				int index = this.711FD593;
				num = (3792843711U | num);
				bdb1E2.RemoveAt(index);
			}
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x000673D8 File Offset: 0x00064FD8
		public override int B395DB29()
		{
			uint num = 496445484U;
			num = 1603881264U + num;
			List<11AE0F91.80068AA5> bdb1E = this.BDB1E229;
			num <<= 16;
			return bdb1E.Count;
		}

		// Token: 0x0400028F RID: 655
		private int 711FD593;

		// Token: 0x04000290 RID: 656
		private List<11AE0F91.80068AA5> BDB1E229 = new List<11AE0F91.80068AA5>();
	}
}

