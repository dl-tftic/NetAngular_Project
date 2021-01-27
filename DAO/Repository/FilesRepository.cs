using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DTO.Models;
using Tools.Connection;
using DAO.Interface;

namespace DAO.Repository
{
    public class FilesRepository : BaseRepository, IRepository<Files>
    {

        public FilesRepository() : base("Files")
        {

        }

        public Files Get(int id)
        {
            try
            {
                Command cmd = new Command("GetFile", true);
                cmd.AddParameter("id", id);
                Connection conn = new Connection(this.connectionString);
                Files file = conn.ExecuteReader<Files>(cmd, (reader) =>
                                                            new Files
                                                            {
                                                                Id = (int)reader["Id"],
                                                                Name = (string)reader["Name"],
                                                                FileName = (string)reader["FileName"],
                                                                FileExension = (string)reader["FileExension"],
                                                                //FileByte = (byte[])reader["FileByte"],
                                                                FileSize = (long)reader["FileSize"],
                                                                FileLinkId = (reader["FileLinkId"] == DBNull.Value) ? null : (string)reader["FileLinkId"],
                                                                Description = (reader["Description"] == DBNull.Value) ? null : (string)reader["Description"],
                                                                CreateDate = (DateTime)reader["CreateDate"],
                                                                CreateBy = (int)reader["CreateBy"]
                                                            }
                                                            ).Single();

                return file;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public IEnumerable<Files> GetByProductCategory(int productCategoryId)
        {
            try
            {
                Command cmd = new Command("GetFilesByProductCategory", true);
                cmd.AddParameter("productCategoryId", productCategoryId);
                Connection conn = new Connection(this.connectionString);
                return conn.ExecuteReader<Files>(cmd, (reader) =>
                                                            new Files
                                                            {
                                                                Id = (int)reader["Id"],
                                                                Name = (string)reader["Name"],
                                                                FileName = (string)reader["FileName"],
                                                                FileExension = (string)reader["FileExension"],
                                                            //FileByte = (byte[])reader["FileByte"],
                                                            FileSize = (long)reader["FileSize"],
                                                                FileLinkId = (reader["FileLinkId"] == DBNull.Value) ? null : (string)reader["FileLinkId"],
                                                                Description = (reader["Description"] == DBNull.Value) ? null : (string)reader["Description"],
                                                                CreateDate = (DateTime)reader["CreateDate"],
                                                                CreateBy = (int)reader["CreateBy"]
                                                            }
                                                            );
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public IEnumerable<Files> GetByProjectCategory(int projectCategoryId)
        {
            try
            {
                Command cmd = new Command("GetFilesByProjectCategory", true);
                cmd.AddParameter("projectCategoryId", projectCategoryId);
                Connection conn = new Connection(this.connectionString);
                return conn.ExecuteReader<Files>(cmd, (reader) =>
                                                            new Files
                                                            {
                                                                Id = (int)reader["Id"],
                                                                Name = (string)reader["Name"],
                                                                FileName = (string)reader["FileName"],
                                                                FileExension = (string)reader["FileExension"],
                                                            //FileByte = (byte[])reader["FileByte"],
                                                            FileSize = (long)reader["FileSize"],
                                                                FileLinkId = (reader["FileLinkId"] == DBNull.Value) ? null : (string)reader["FileLinkId"],
                                                                Description = (reader["Description"] == DBNull.Value) ? null : (string)reader["Description"],
                                                                CreateDate = (DateTime)reader["CreateDate"],
                                                                CreateBy = (int)reader["CreateBy"]
                                                            }
                                                            );
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public byte[] Download(int id)
        {
            try
            {
                Command cmd = new Command("GetFilesDownload", true);
                cmd.AddParameter("id", id);
                Connection conn = new Connection(this.connectionString);
                return conn.ExecuteReader<byte[]>(cmd, (reader) => (byte[])reader["FileByte"]).Single();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Insert(Files file)
        {
            /*
             	@Name				varchar(80),
	            @FileName			varchar(255),
	            @FileExension		varchar(20),
	            @FileByte			varbinary(max),
	            @FileSize			bigint,
	            @FileLinkId			varchar(80) = null,
	            @Description		varchar(255) = null,
	            @CreateBy			int
            */
            try
            {
                Command cmd = new Command("AddFiles", true);
                cmd.AddParameter("Name", file.Name);
                cmd.AddParameter("FileName", file.FileName);
                cmd.AddParameter("FileExension", file.FileExension);
                cmd.AddParameter("FileByte", file.FileByte);
                cmd.AddParameter("FileSize", file.FileSize);
                cmd.AddParameter("FileLinkId", file.FileLinkId);
                cmd.AddParameter("Description", file.Description);
                cmd.AddParameter("CreateBy", file.CreateBy);
                Connection conn = new Connection(this.connectionString);
                return (int)(conn.ExecuteScalar(cmd));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public IEnumerable<Files> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Update(Files obj)
        {
            throw new NotImplementedException();
        }
    }
}
