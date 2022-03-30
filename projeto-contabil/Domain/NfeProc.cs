﻿using System.Xml.Serialization;

namespace projeto_contabil.Domain
{
	[XmlRoot(ElementName = "ide", Namespace = "http://www.portalfiscal.inf.br/nfe")]
	public class Ide
	{
		[XmlElement(ElementName = "cUF", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string CUF { get; set; }
		[XmlElement(ElementName = "cNF", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string CNF { get; set; }
		[XmlElement(ElementName = "natOp", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string NatOp { get; set; }
		[XmlElement(ElementName = "mod", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string Mod { get; set; }
		[XmlElement(ElementName = "serie", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string Serie { get; set; }
		[XmlElement(ElementName = "nNF", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string NNF { get; set; }
		[XmlElement(ElementName = "dhEmi", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string DhEmi { get; set; }
		[XmlElement(ElementName = "dhSaiEnt", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string DhSaiEnt { get; set; }
		[XmlElement(ElementName = "tpNF", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string TpNF { get; set; }
		[XmlElement(ElementName = "idDest", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string IdDest { get; set; }
		[XmlElement(ElementName = "cMunFG", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string CMunFG { get; set; }
		[XmlElement(ElementName = "tpImp", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string TpImp { get; set; }
		[XmlElement(ElementName = "tpEmis", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string TpEmis { get; set; }
		[XmlElement(ElementName = "cDV", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string CDV { get; set; }
		[XmlElement(ElementName = "tpAmb", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string TpAmb { get; set; }
		[XmlElement(ElementName = "finNFe", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string FinNFe { get; set; }
		[XmlElement(ElementName = "indFinal", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string IndFinal { get; set; }
		[XmlElement(ElementName = "indPres", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string IndPres { get; set; }
		[XmlElement(ElementName = "procEmi", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string ProcEmi { get; set; }
		[XmlElement(ElementName = "verProc", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string VerProc { get; set; }
	}

	[XmlRoot(ElementName = "enderEmit", Namespace = "http://www.portalfiscal.inf.br/nfe")]
	public class EnderEmit
	{
		[XmlElement(ElementName = "xLgr", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string XLgr { get; set; }
		[XmlElement(ElementName = "nro", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string Nro { get; set; }
		[XmlElement(ElementName = "xBairro", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string XBairro { get; set; }
		[XmlElement(ElementName = "cMun", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string CMun { get; set; }
		[XmlElement(ElementName = "xMun", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string XMun { get; set; }
		[XmlElement(ElementName = "UF", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string UF { get; set; }
		[XmlElement(ElementName = "CEP", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string CEP { get; set; }
		[XmlElement(ElementName = "cPais", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string CPais { get; set; }
		[XmlElement(ElementName = "xPais", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string XPais { get; set; }
		[XmlElement(ElementName = "fone", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string Fone { get; set; }
	}

	[XmlRoot(ElementName = "emit", Namespace = "http://www.portalfiscal.inf.br/nfe")]
	public class Emit
	{
		[XmlElement(ElementName = "CNPJ", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string CNPJ { get; set; }
		[XmlElement(ElementName = "xNome", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string XNome { get; set; }
		[XmlElement(ElementName = "xFant", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string XFant { get; set; }
		[XmlElement(ElementName = "enderEmit", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public EnderEmit EnderEmit { get; set; }
		[XmlElement(ElementName = "IE", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string IE { get; set; }
		[XmlElement(ElementName = "IM", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string IM { get; set; }
		[XmlElement(ElementName = "CRT", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string CRT { get; set; }
	}

	[XmlRoot(ElementName = "enderDest", Namespace = "http://www.portalfiscal.inf.br/nfe")]
	public class EnderDest
	{
		[XmlElement(ElementName = "xLgr", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string XLgr { get; set; }
		[XmlElement(ElementName = "nro", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string Nro { get; set; }
		[XmlElement(ElementName = "xBairro", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string XBairro { get; set; }
		[XmlElement(ElementName = "cMun", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string CMun { get; set; }
		[XmlElement(ElementName = "xMun", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string XMun { get; set; }
		[XmlElement(ElementName = "UF", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string UF { get; set; }
		[XmlElement(ElementName = "CEP", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string CEP { get; set; }
		[XmlElement(ElementName = "cPais", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string CPais { get; set; }
		[XmlElement(ElementName = "xPais", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string XPais { get; set; }
		[XmlElement(ElementName = "fone", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string Fone { get; set; }
	}

	[XmlRoot(ElementName = "dest", Namespace = "http://www.portalfiscal.inf.br/nfe")]
	public class Dest
	{
		[XmlElement(ElementName = "CNPJ", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string CNPJ { get; set; }
		[XmlElement(ElementName = "xNome", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string XNome { get; set; }
		[XmlElement(ElementName = "enderDest", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public EnderDest EnderDest { get; set; }
		[XmlElement(ElementName = "indIEDest", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string IndIEDest { get; set; }
		[XmlElement(ElementName = "IE", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string IE { get; set; }
		[XmlElement(ElementName = "email", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string Email { get; set; }
	}

	[XmlRoot(ElementName = "prod", Namespace = "http://www.portalfiscal.inf.br/nfe")]
	public class Prod
	{
		[XmlElement(ElementName = "cProd", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string CProd { get; set; }
		[XmlElement(ElementName = "cEAN", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string CEAN { get; set; }
		[XmlElement(ElementName = "xProd", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string XProd { get; set; }
		[XmlElement(ElementName = "NCM", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string NCM { get; set; }
		[XmlElement(ElementName = "CEST", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string CEST { get; set; }
		[XmlElement(ElementName = "CFOP", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string CFOP { get; set; }
		[XmlElement(ElementName = "uCom", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string UCom { get; set; }
		[XmlElement(ElementName = "qCom", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string QCom { get; set; }
		[XmlElement(ElementName = "vUnCom", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string VUnCom { get; set; }
		[XmlElement(ElementName = "vProd", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string VProd { get; set; }
		[XmlElement(ElementName = "cEANTrib", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string CEANTrib { get; set; }
		[XmlElement(ElementName = "uTrib", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string UTrib { get; set; }
		[XmlElement(ElementName = "qTrib", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string QTrib { get; set; }
		[XmlElement(ElementName = "vUnTrib", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string VUnTrib { get; set; }
		[XmlElement(ElementName = "indTot", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string IndTot { get; set; }
	}

	[XmlRoot(ElementName = "ICMS00", Namespace = "http://www.portalfiscal.inf.br/nfe")]
	public class ICMS00
	{
		[XmlElement(ElementName = "orig", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string Orig { get; set; }
		[XmlElement(ElementName = "CST", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string CST { get; set; }
		[XmlElement(ElementName = "modBC", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string ModBC { get; set; }
		[XmlElement(ElementName = "vBC", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string VBC { get; set; }
		[XmlElement(ElementName = "pICMS", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string PICMS { get; set; }
		[XmlElement(ElementName = "vICMS", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string VICMS { get; set; }
	}

	[XmlRoot(ElementName = "ICMS", Namespace = "http://www.portalfiscal.inf.br/nfe")]
	public class ICMS
	{
		[XmlElement(ElementName = "ICMS00", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public ICMS00 ICMS00 { get; set; }
	}

	[XmlRoot(ElementName = "IPITrib", Namespace = "http://www.portalfiscal.inf.br/nfe")]
	public class IPITrib
	{
		[XmlElement(ElementName = "CST", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string CST { get; set; }
		[XmlElement(ElementName = "vBC", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string VBC { get; set; }
		[XmlElement(ElementName = "pIPI", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string PIPI { get; set; }
		[XmlElement(ElementName = "vIPI", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string VIPI { get; set; }
	}

	[XmlRoot(ElementName = "IPI", Namespace = "http://www.portalfiscal.inf.br/nfe")]
	public class IPI
	{
		[XmlElement(ElementName = "cEnq", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string CEnq { get; set; }
		[XmlElement(ElementName = "IPITrib", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public IPITrib IPITrib { get; set; }
	}

	[XmlRoot(ElementName = "PISAliq", Namespace = "http://www.portalfiscal.inf.br/nfe")]
	public class PISAliq
	{
		[XmlElement(ElementName = "CST", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string CST { get; set; }
		[XmlElement(ElementName = "vBC", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string VBC { get; set; }
		[XmlElement(ElementName = "pPIS", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string PPIS { get; set; }
		[XmlElement(ElementName = "vPIS", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string VPIS { get; set; }
	}

	[XmlRoot(ElementName = "PIS", Namespace = "http://www.portalfiscal.inf.br/nfe")]
	public class PIS
	{
		[XmlElement(ElementName = "PISAliq", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public PISAliq PISAliq { get; set; }
	}

	[XmlRoot(ElementName = "COFINSAliq", Namespace = "http://www.portalfiscal.inf.br/nfe")]
	public class COFINSAliq
	{
		[XmlElement(ElementName = "CST", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string CST { get; set; }
		[XmlElement(ElementName = "vBC", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string VBC { get; set; }
		[XmlElement(ElementName = "pCOFINS", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string PCOFINS { get; set; }
		[XmlElement(ElementName = "vCOFINS", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string VCOFINS { get; set; }
	}

	[XmlRoot(ElementName = "COFINS", Namespace = "http://www.portalfiscal.inf.br/nfe")]
	public class COFINS
	{
		[XmlElement(ElementName = "COFINSAliq", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public COFINSAliq COFINSAliq { get; set; }
	}

	[XmlRoot(ElementName = "imposto", Namespace = "http://www.portalfiscal.inf.br/nfe")]
	public class Imposto
	{
		[XmlElement(ElementName = "ICMS", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public ICMS ICMS { get; set; }
		[XmlElement(ElementName = "IPI", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public IPI IPI { get; set; }
		[XmlElement(ElementName = "PIS", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public PIS PIS { get; set; }
		[XmlElement(ElementName = "COFINS", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public COFINS COFINS { get; set; }
	}

	[XmlRoot(ElementName = "det", Namespace = "http://www.portalfiscal.inf.br/nfe")]
	public class Det
	{
		[XmlElement(ElementName = "prod", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public Prod Prod { get; set; }
		[XmlElement(ElementName = "imposto", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public Imposto Imposto { get; set; }
		[XmlAttribute(AttributeName = "nItem")]
		public string NItem { get; set; }
	}

	[XmlRoot(ElementName = "ICMSTot", Namespace = "http://www.portalfiscal.inf.br/nfe")]
	public class ICMSTot
	{
		[XmlElement(ElementName = "vBC", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string VBC { get; set; }
		[XmlElement(ElementName = "vICMS", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string VICMS { get; set; }
		[XmlElement(ElementName = "vICMSDeson", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string VICMSDeson { get; set; }
		[XmlElement(ElementName = "vFCPUFDest", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string VFCPUFDest { get; set; }
		[XmlElement(ElementName = "vICMSUFDest", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string VICMSUFDest { get; set; }
		[XmlElement(ElementName = "vICMSUFRemet", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string VICMSUFRemet { get; set; }
		[XmlElement(ElementName = "vFCP", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string VFCP { get; set; }
		[XmlElement(ElementName = "vBCST", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string VBCST { get; set; }
		[XmlElement(ElementName = "vST", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string VST { get; set; }
		[XmlElement(ElementName = "vFCPST", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string VFCPST { get; set; }
		[XmlElement(ElementName = "vFCPSTRet", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string VFCPSTRet { get; set; }
		[XmlElement(ElementName = "vProd", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string VProd { get; set; }
		[XmlElement(ElementName = "vFrete", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string VFrete { get; set; }
		[XmlElement(ElementName = "vSeg", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string VSeg { get; set; }
		[XmlElement(ElementName = "vDesc", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string VDesc { get; set; }
		[XmlElement(ElementName = "vII", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string VII { get; set; }
		[XmlElement(ElementName = "vIPI", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string VIPI { get; set; }
		[XmlElement(ElementName = "vIPIDevol", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string VIPIDevol { get; set; }
		[XmlElement(ElementName = "vPIS", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string VPIS { get; set; }
		[XmlElement(ElementName = "vCOFINS", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string VCOFINS { get; set; }
		[XmlElement(ElementName = "vOutro", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string VOutro { get; set; }
		[XmlElement(ElementName = "vNF", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string VNF { get; set; }
	}

	[XmlRoot(ElementName = "total", Namespace = "http://www.portalfiscal.inf.br/nfe")]
	public class Total
	{
		[XmlElement(ElementName = "ICMSTot", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public ICMSTot ICMSTot { get; set; }
	}

	[XmlRoot(ElementName = "transporta", Namespace = "http://www.portalfiscal.inf.br/nfe")]
	public class Transporta
	{
		[XmlElement(ElementName = "CNPJ", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string CNPJ { get; set; }
		[XmlElement(ElementName = "xNome", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string XNome { get; set; }
		[XmlElement(ElementName = "IE", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string IE { get; set; }
		[XmlElement(ElementName = "xEnder", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string XEnder { get; set; }
		[XmlElement(ElementName = "xMun", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string XMun { get; set; }
		[XmlElement(ElementName = "UF", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string UF { get; set; }
	}

	[XmlRoot(ElementName = "vol", Namespace = "http://www.portalfiscal.inf.br/nfe")]
	public class Vol
	{
		[XmlElement(ElementName = "qVol", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string QVol { get; set; }
		[XmlElement(ElementName = "esp", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string Esp { get; set; }
		[XmlElement(ElementName = "pesoL", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string PesoL { get; set; }
		[XmlElement(ElementName = "pesoB", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string PesoB { get; set; }
	}

	[XmlRoot(ElementName = "transp", Namespace = "http://www.portalfiscal.inf.br/nfe")]
	public class Transp
	{
		[XmlElement(ElementName = "modFrete", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string ModFrete { get; set; }
		[XmlElement(ElementName = "transporta", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public Transporta Transporta { get; set; }
		[XmlElement(ElementName = "vol", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public Vol Vol { get; set; }
	}

	[XmlRoot(ElementName = "fat", Namespace = "http://www.portalfiscal.inf.br/nfe")]
	public class Fat
	{
		[XmlElement(ElementName = "nFat", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string NFat { get; set; }
		[XmlElement(ElementName = "vOrig", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string VOrig { get; set; }
		[XmlElement(ElementName = "vDesc", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string VDesc { get; set; }
		[XmlElement(ElementName = "vLiq", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string VLiq { get; set; }
	}

	[XmlRoot(ElementName = "dup", Namespace = "http://www.portalfiscal.inf.br/nfe")]
	public class Dup
	{
		[XmlElement(ElementName = "nDup", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string NDup { get; set; }
		[XmlElement(ElementName = "dVenc", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string DVenc { get; set; }
		[XmlElement(ElementName = "vDup", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string VDup { get; set; }
	}

	[XmlRoot(ElementName = "cobr", Namespace = "http://www.portalfiscal.inf.br/nfe")]
	public class Cobr
	{
		[XmlElement(ElementName = "fat", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public Fat Fat { get; set; }
		[XmlElement(ElementName = "dup", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public Dup Dup { get; set; }
	}

	[XmlRoot(ElementName = "detPag", Namespace = "http://www.portalfiscal.inf.br/nfe")]
	public class DetPag
	{
		[XmlElement(ElementName = "indPag", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string IndPag { get; set; }
		[XmlElement(ElementName = "tPag", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string TPag { get; set; }
		[XmlElement(ElementName = "vPag", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string VPag { get; set; }
	}

	[XmlRoot(ElementName = "pag", Namespace = "http://www.portalfiscal.inf.br/nfe")]
	public class Pag
	{
		[XmlElement(ElementName = "detPag", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public DetPag DetPag { get; set; }
	}

	[XmlRoot(ElementName = "infRespTec", Namespace = "http://www.portalfiscal.inf.br/nfe")]
	public class InfRespTec
	{
		[XmlElement(ElementName = "CNPJ", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string CNPJ { get; set; }
		[XmlElement(ElementName = "xContato", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string XContato { get; set; }
		[XmlElement(ElementName = "email", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string Email { get; set; }
		[XmlElement(ElementName = "fone", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string Fone { get; set; }
	}

	[XmlRoot(ElementName = "infNFe", Namespace = "http://www.portalfiscal.inf.br/nfe")]
	public class InfNFe
	{
		[XmlElement(ElementName = "ide", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public Ide Ide { get; set; }
		[XmlElement(ElementName = "emit", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public Emit Emit { get; set; }
		[XmlElement(ElementName = "dest", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public Dest Dest { get; set; }
		[XmlElement(ElementName = "det", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public List<Det> Det { get; set; }
		[XmlElement(ElementName = "total", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public Total Total { get; set; }
		[XmlElement(ElementName = "transp", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public Transp Transp { get; set; }
		[XmlElement(ElementName = "cobr", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public Cobr Cobr { get; set; }
		[XmlElement(ElementName = "pag", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public Pag Pag { get; set; }
		[XmlElement(ElementName = "infRespTec", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public InfRespTec InfRespTec { get; set; }
		[XmlAttribute(AttributeName = "Id")]
		public string Id { get; set; }
		[XmlAttribute(AttributeName = "versao")]
		public string Versao { get; set; }
	}

	[XmlRoot(ElementName = "CanonicalizationMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	public class CanonicalizationMethod
	{
		[XmlAttribute(AttributeName = "Algorithm")]
		public string Algorithm { get; set; }
	}

	[XmlRoot(ElementName = "SignatureMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	public class SignatureMethod
	{
		[XmlAttribute(AttributeName = "Algorithm")]
		public string Algorithm { get; set; }
	}

	[XmlRoot(ElementName = "Transform", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	public class Transform
	{
		[XmlAttribute(AttributeName = "Algorithm")]
		public string Algorithm { get; set; }
	}

	[XmlRoot(ElementName = "Transforms", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	public class Transforms
	{
		[XmlElement(ElementName = "Transform", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public List<Transform> Transform { get; set; }
	}

	[XmlRoot(ElementName = "DigestMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	public class DigestMethod
	{
		[XmlAttribute(AttributeName = "Algorithm")]
		public string Algorithm { get; set; }
	}

	[XmlRoot(ElementName = "Reference", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	public class Reference
	{
		[XmlElement(ElementName = "Transforms", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public Transforms Transforms { get; set; }
		[XmlElement(ElementName = "DigestMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public DigestMethod DigestMethod { get; set; }
		[XmlElement(ElementName = "DigestValue", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public string DigestValue { get; set; }
		[XmlAttribute(AttributeName = "URI")]
		public string URI { get; set; }
	}

	[XmlRoot(ElementName = "SignedInfo", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	public class SignedInfo
	{
		[XmlElement(ElementName = "CanonicalizationMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public CanonicalizationMethod CanonicalizationMethod { get; set; }
		[XmlElement(ElementName = "SignatureMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public SignatureMethod SignatureMethod { get; set; }
		[XmlElement(ElementName = "Reference", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public Reference Reference { get; set; }
	}

	[XmlRoot(ElementName = "X509Data", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	public class X509Data
	{
		[XmlElement(ElementName = "X509Certificate", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public string X509Certificate { get; set; }
	}

	[XmlRoot(ElementName = "KeyInfo", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	public class KeyInfo
	{
		[XmlElement(ElementName = "X509Data", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public X509Data X509Data { get; set; }
	}

	[XmlRoot(ElementName = "Signature", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
	public class Signature
	{
		[XmlElement(ElementName = "SignedInfo", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public SignedInfo SignedInfo { get; set; }
		[XmlElement(ElementName = "SignatureValue", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public string SignatureValue { get; set; }
		[XmlElement(ElementName = "KeyInfo", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public KeyInfo KeyInfo { get; set; }
		[XmlAttribute(AttributeName = "xmlns")]
		public string Xmlns { get; set; }
	}

	[XmlRoot(ElementName = "NFe", Namespace = "http://www.portalfiscal.inf.br/nfe")]
	public class NFe
	{
		[XmlElement(ElementName = "infNFe", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public InfNFe InfNFe { get; set; }
		[XmlElement(ElementName = "Signature", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
		public Signature Signature { get; set; }
		[XmlAttribute(AttributeName = "xmlns")]
		public string Xmlns { get; set; }
	}

	[XmlRoot(ElementName = "infProt", Namespace = "http://www.portalfiscal.inf.br/nfe")]
	public class InfProt
	{
		[XmlElement(ElementName = "tpAmb", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string TpAmb { get; set; }
		[XmlElement(ElementName = "verAplic", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string VerAplic { get; set; }
		[XmlElement(ElementName = "chNFe", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string ChNFe { get; set; }
		[XmlElement(ElementName = "dhRecbto", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string DhRecbto { get; set; }
		[XmlElement(ElementName = "nProt", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string NProt { get; set; }
		[XmlElement(ElementName = "digVal", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string DigVal { get; set; }
		[XmlElement(ElementName = "cStat", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string CStat { get; set; }
		[XmlElement(ElementName = "xMotivo", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public string XMotivo { get; set; }
		[XmlAttribute(AttributeName = "Id")]
		public string Id { get; set; }
	}

	[XmlRoot(ElementName = "protNFe", Namespace = "http://www.portalfiscal.inf.br/nfe")]
	public class ProtNFe
	{
		[XmlElement(ElementName = "infProt", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public InfProt InfProt { get; set; }
		[XmlAttribute(AttributeName = "versao")]
		public string Versao { get; set; }
	}

	[XmlRoot(ElementName = "nfeProc", Namespace = "http://www.portalfiscal.inf.br/nfe")]
	public class NfeProc
	{
		[XmlElement(ElementName = "NFe", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public NFe NFe { get; set; }
		[XmlElement(ElementName = "protNFe", Namespace = "http://www.portalfiscal.inf.br/nfe")]
		public ProtNFe ProtNFe { get; set; }
		[XmlAttribute(AttributeName = "versao")]
		public string Versao { get; set; }
		[XmlAttribute(AttributeName = "xmlns")]
		public string Xmlns { get; set; }
	}
}
