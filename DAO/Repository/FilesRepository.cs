using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DTO.Models;
using Tools.Connection;

namespace DAO.Repository
{
    public class FilesRepository : RepositoryBase
    {
        public Files Get(int id)
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
                                                            FileByte = (byte[])reader["FileByte"],
                                                            FileSize = (long)reader["FileSize"],
                                                            FileLinkId = (reader["FileLinkId"] == DBNull.Value) ? null : (string)reader["FileLinkId"],
                                                            Description = (reader["Description"] == DBNull.Value) ? null : (string)reader["Description"],
                                                            CreateDate = (DateTime)reader["CreateDate"],
                                                            CreateBy = (int)reader["CreateBy"]
                                                        }
                                                        ).Single();

            return file;
        }

        public IEnumerable<Files> GetByProductCategory(int productCategoryId)
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
                                                            FileByte = (byte[])reader["FileByte"],
                                                            FileSize = (long)reader["FileSize"],
                                                            FileLinkId = (reader["FileLinkId"] == DBNull.Value) ? null : (string)reader["FileLinkId"],
                                                            Description = (reader["Description"] == DBNull.Value) ? null : (string)reader["Description"],
                                                            CreateDate = (DateTime)reader["CreateDate"],
                                                            CreateBy = (int)reader["CreateBy"]
                                                        }
                                                        );
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
            return (int)(decimal)(conn.ExecuteScalar(cmd));
        }
    }
}
