using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Renci.SshNet;

namespace FS.Framework
{
    /// <summary>  
    /// SFTP操作类  
    /// </summary>  
    public class SFTPHelper : IDisposable
    {
        #region - 字段或属性 -  
        private SftpClient sftp;

        /// <summary>  
        /// SFTP连接状态  
        /// </summary>  
        public bool Connected { get { return sftp.IsConnected; } }
        #endregion

        #region - 构造 -  
        /// <summary>  
        /// 构造  
        /// </summary>  
        /// <param name="ip">IP</param>  
        /// <param name="port">端口</param>  
        /// <param name="user">用户名</param>  
        /// <param name="pwd">密码</param>  
        public SFTPHelper(string ip, string user, string pwd, int port, string hmacAlgorithms = "")
        {
            ConnectionInfo connectionInfo = new ConnectionInfo(ip, port, user, new PasswordAuthenticationMethod(user, pwd));
            if (!string.IsNullOrWhiteSpace(hmacAlgorithms))
            {
                connectionInfo.HmacAlgorithms.Clear();
                connectionInfo.HmacAlgorithms.Add(hmacAlgorithms, new HashInfo(32 * 8, (key) => new System.Security.Cryptography.HMACSHA256(key)));
            }

            sftp = new SftpClient(connectionInfo);
        }
        #endregion

        #region - 连接SFTP -  
        /// <summary>  
        /// 连接SFTP  
        /// </summary>  
        /// <returns>true成功</returns>  
        public bool Connect()
        {
            try
            {
                if (!Connected)
                {
                    sftp.Connect();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("连接SFTP失败，原因：{0}", ex.Message));
            }
        }
        #endregion

        #region - 断开SFTP -  
        /// <summary>  
        /// 断开SFTP  
        /// </summary>   
        public void Disconnect()
        {
            try
            {
                if (sftp != null && Connected)
                {
                    sftp.Disconnect();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("断开SFTP失败，原因：{0}", ex.Message));
            }
        }
        #endregion

        #region - SFTP上传文件 -   
        /// <summary>  
        /// SFTP上传文件  
        /// </summary>  
        /// <param name="localPath">本地路径</param>  
        /// <param name="remotePath">远程路径</param>  
        public void Put(string localPath, string remotePath)
        {
            try
            {
                using (var file = File.OpenRead(localPath))
                {
                    Connect();
                    sftp.UploadFile(file, remotePath);
                    Disconnect();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("SFTP文件上传失败，原因：{0}", ex.Message));
            }
        }
        #endregion

        #region - SFTP获取文件 -  

        /// <summary>  
        /// SFTP获取文件  
        /// </summary>  
        /// <param name="remotePath">远程路径</param>  
        /// <param name="localPath">本地路径</param>  
        public void Get(string remotePath, string localPath)
        {
            try
            {
                Connect();
                var byt = sftp.ReadAllBytes(remotePath);
             //   IOHelper.WriteBuffToFile(byt, localPath);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("SFTP文件获取失败，原因：{0}", ex.Message));
            }

        }

        /// <summary>
        /// 获取文件
        /// </summary>
        /// <param name="remotePath"></param>
        /// <returns></returns>
        public StreamReader Get(string localPath)
        {
            try
            {
                Connect();
                StreamReader reader = sftp.OpenText(localPath);
                return reader;
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("SFTP文件获取失败，原因：{0}", ex.Message));
            }
        }

        public MemoryStream GetMemoryStream(string localPath)
        {
            try
            {
                Connect();
                byte[] bytes = sftp.ReadAllBytes(localPath);
                return new MemoryStream(bytes);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("SFTP文件获取失败，原因：{0}", ex.Message));
            }
        }

        public byte[] GetBytes(string localPath)
        {
            try
            {
                Connect();
                return sftp.ReadAllBytes(localPath);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("SFTP文件获取失败，原因：{0}", ex.Message));
            }
        }

        #endregion

        #region - 删除SFTP文件 -  
        /// <summary>  
        /// 删除SFTP文件   
        /// </summary>  
        /// <param name="remoteFile">远程路径</param>  
        public void Delete(string remoteFile)
        {
            try
            {
                Connect();
                sftp.Delete(remoteFile);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("SFTP文件删除失败，原因：{0}", ex.Message));
            }
        }
        #endregion

        #region - 移动SFTP文件 -  
        /// <summary>  
        /// 移动SFTP文件  
        /// </summary>  
        /// <param name="oldRemotePath">旧远程路径</param>  
        /// <param name="newRemotePath">新远程路径</param>  
        public void Move(string oldRemotePath, string newRemotePath)
        {
            try
            {
                Connect();
                sftp.RenameFile(oldRemotePath, newRemotePath);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("SFTP文件移动失败，原因：{0}", ex.Message));
            }
        }
        #endregion

        #region - 获取SFTP文件列表 -

        //获取SFTP文件列表  返回  List<string>
        public List<string> GetFileNameList(string remotePath, string searchPattern = "*.*")
        {
            try
            {
                Connect();
                //List<string> list = searchPattern.SplitToList<string>('*');
                List<string> list = new List<string>();
                List<string> files = sftp.ListDirectory(remotePath).ToList().Select(x => x.Name).ToList();
                list.ForEach((x) =>
                {
                    files = files.FindAll(z => z.Contains(x));
                });
                return files;
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("SFTP文件列表获取失败，原因：{0}", ex.Message));
            }
        }
        #endregion

        #region - 下载文件到指定目录 -
        /// <summary>
        /// 下载文件到指定目录
        /// </summary>
        /// <param name="remotePath">服务器目录</param>
        /// <param name="fileType">文件的类型</param>
        /// <param name="localPath">下载目录</param>
        /// <param name="contains">下载文件包含名称</param>
        /// <returns></returns>
        public void DownloadFile(string remotePath, string localPath, List<string> filelist)
        {
            try
            {
                foreach (string fileName in filelist)
                {
                    Get(remotePath + "/" + fileName, localPath + "\\" + fileName);
                }
            }
            catch { }
        }


        #endregion

        public void Dispose()
        {
            this.Disconnect();
        }
    }
}
