<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output method="html" encoding="UTF-8" indent="yes"/>
    
    <xsl:template match="/movimento">
        <html>
            <head>
                <title>Listagem de Voos</title>
                <style>
                    body { font-family: Arial, sans-serif; }
                    table { width: 100%; border-collapse: collapse; margin-top: 20px; }
                    th, td { border: 1px solid #dddddd; text-align: left; padding: 8px; }
                    th { background-color: #f2f2f2; }
                    .operando-sim { color: green; font-weight: bold; }
                    .operando-nao { color: red; font-weight: bold; }
                </style>
            </head>
            <body>
                <h1>Lista de Voos</h1>
                <table>
                    <tr>
                        <th>Código do Voo</th>
                        <th>Origem</th>
                        <th>Destino</th>
                        <th>Horário</th>
                        <th>Companhia</th>
                        <th>Operando</th>
                    </tr>
                    <xsl:apply-templates select="voo">
                        <xsl:sort select="horario" data-type="text" order="ascending"/>
                    </xsl:apply-templates>
                </table>
            </body>
        </html>
    </xsl:template>
    
    <xsl:template match="voo">
        <tr>
            <td><xsl:value-of select="@codigo"/></td>
            <td><xsl:value-of select="origem"/></td>
            <td><xsl:value-of select="destino"/></td>
            <td><xsl:value-of select="horario"/></td>
            <td><xsl:value-of select="compania"/></td>
            <td>
                <xsl:choose>
                    <xsl:when test="operando='T'">
                        <span class="operando-sim">SIM</span>
                    </xsl:when>
                    <xsl:otherwise>
                        <span class="operando-nao">NÃO</span>
                    </xsl:otherwise>
                </xsl:choose>
            </td>
        </tr>
    </xsl:template>
</xsl:stylesheet>

<!-- Pedro H Perpétuo CB3021688 & Igor Benites CB3021734 -->
