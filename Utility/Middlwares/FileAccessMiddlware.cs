namespace AutomotiveApi.Utility.Middlwares
{
    public class FileAccessMiddlware
    {
        private readonly RequestDelegate _next;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public FileAccessMiddlware(RequestDelegate next, IWebHostEnvironment hostingEnvironment)
        {
            _next = next;
            _hostingEnvironment = hostingEnvironment;
        }

        public async Task Invoke(HttpContext context)
        {
            var path = context.Request.Path.Value;
            if (path.StartsWith("/Permis"))
            {
                Console.WriteLine(path);
                // split path to get folder name
                var folderName = path.Split("/")[2];



                try
                {
                    int folderId = Int32.Parse(folderName);
                    int clientId = int.Parse(context.Request.HttpContext.User.FindFirst("id")?.Value ?? "0");
                    
                    // int idAgence = int.Parse(context.Request.HttpContext.User.FindFirst("idAgence")?.Value ?? "0");


                    // int clientAgene = await _context.Set<Contrat>().Where(c => c.Id == folderId).Include(c => c.Reservation.Vehicule.Agence.Id)
                    //  .Select(c => c.Reservation.Vehicule.Agence.Id).FirstOrDefaultAsync();

                    Console.WriteLine("Comparing " + clientId + " to " + folderId);

                    if (clientId == folderId)
                    {
                        await _next(context);
                        return;
                    }
                    else{
                        context.Response.StatusCode = 404;
                        return;
                    }

                }
                catch (Exception e)
                {
                    context.Response.StatusCode = 404;
                    return;
                }

            }
            else
            {
                await _next(context);
            }
        }
    }
}