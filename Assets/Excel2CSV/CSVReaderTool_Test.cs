
using CSV_SPACE;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
public static  class CSVReaderTool_Test
{

    /// <summary>
    /// ��Ϊͨ�õ����ݶ�ȡ���������ǿ����ò���
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="csvFilePath"></param>
    /// <returns></returns>
    public static Dictionary<string, T> Read<T>(string csvFilePath) where T : CSVBase, new()
    {
        var csvData = File.ReadAllText(csvFilePath);
        var csvRows = csvData.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

        var result = new Dictionary<string, T>();
        var props = typeof(T).GetProperties();
        // �б�ĵ�һ������Ĭ��Ϊ�б���
        for (int i = 1; i < csvRows.Length; i++)
        {
            var row = csvRows[i].Split(',');
            var obj = new T();
            for (int j = 0; j < props.Length; j++)
            {
                props[j].SetValue(obj, Convert.ChangeType(row[j], props[j].PropertyType));
            }
            result.Add(props[0].GetValue(obj).ToString(), obj);
        }
        // ���� Dictionary<string, T>
        return result;
    }


}
