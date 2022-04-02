using projeto_contabil.Domain;
using projeto_contabil.Domain.Interface.Services;
using projeto_contabil.Domain.Interface.UseCases;

namespace projeto_contabil.UseCases
{
    public class ProcessDocumentUsecase : IProcessDocumentUsecase
    {
        private readonly IProcessDocumentService? _serviceProcessDocument;
        private readonly INotasService? _notasService;

        public ProcessDocumentUsecase(IProcessDocumentService serviceProcessDocument, INotasService notasService)
        {
            _serviceProcessDocument = serviceProcessDocument;
            _notasService = notasService;
        }
        public async Task<Nota> Execute(IFormFile file)
        {
            var nfrProc = await _serviceProcessDocument.Execute(file);

            var nota = new Nota();
            nota.Emitente = new Emitente();
            nota.Emitente.Logadouro = nfrProc.NFe.InfNFe.Emit.EnderEmit.XLgr;
            nota.Emitente.Numero = nfrProc.NFe.InfNFe.Emit.EnderEmit.Nro;
            nota.Emitente.Bairro = nfrProc.NFe.InfNFe.Emit.EnderEmit.XBairro;
            nota.Emitente.CodigoMunicipio = nfrProc.NFe.InfNFe.Emit.EnderEmit.CMun;
            nota.Emitente.Municipio = nfrProc.NFe.InfNFe.Emit.EnderEmit.XMun;
            nota.Emitente.UF = nfrProc.NFe.InfNFe.Emit.EnderEmit.UF;
            nota.Destino = new Destino();
            nota.Destino.CNPJ = nfrProc.NFe.InfNFe.Dest.CNPJ;
            nota.Destino.CNPJ = nfrProc.NFe.InfNFe.Dest.XNome;
            nota.Produto = nfrProc.NFe.InfNFe.Det.Select(x => new Produto
            {
                Descricao = x.Prod.XProd,
                NCM = x.Prod.NCM,
                CodigoEstado = x.Prod.CEST,
                CFOP = x.Prod.CFOP,
                UCOM = x.Prod.UCom,
                QCOM = x.Prod.QCom
            });
            nota.Motivo = nfrProc.ProtNFe.InfProt.XMotivo;

            await _notasService.CreateAsync(nota);

            return nota;            
        }
    }
}
