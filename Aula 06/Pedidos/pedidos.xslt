<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output method="html" encoding="UTF-8" indent="yes"/>
    
    <xsl:template match="/pedidos">
        <html>
            <head>
                <title>Lista de Pedidos</title>
                <style>
                    body { font-family: Arial, sans-serif; }
                    table { width: 100%; border-collapse: collapse; margin-top: 20px; }
                    th, td { border: 1px solid #dddddd; text-align: left; padding: 8px; }
                    th { background-color: #f2f2f2; }
                    .quantidade-alta { color: green; font-weight: bold; }
                    .quantidade-media { color: blue; font-weight: bold; }
                    .quantidade-baixa { color: red; font-weight: bold; }
                </style>
            </head>
            <body>
                <h1>Lista de Pedidos</h1>
                <table>
                    <tr>
                        <th>Código do Produto</th>
                        <th>Nome</th>
                        <th>Quantidade</th>
                        <th>Preço</th>
                        <th>Nível de Estoque</th>
                    </tr>
                    <xsl:for-each select="pedido">
                        <tr>
                            <td><xsl:value-of select="codigo"/></td>
                            <td><xsl:value-of select="nome"/></td>
                            <td><xsl:value-of select="quantidade"/></td>
                            <td><xsl:value-of select="preco"/></td>
                            <td>
                                <xsl:choose>
                                    <xsl:when test="quantidade &gt; 20">
                                        <span class="quantidade-alta">ALTO</span>
                                    </xsl:when>
                                    <xsl:when test="quantidade &gt; 10">
                                        <span class="quantidade-media">MÉDIO</span>
                                    </xsl:when>
                                    <xsl:otherwise>
                                        <span class="quantidade-baixa">BAIXO</span>
                                    </xsl:otherwise>
                                </xsl:choose>
                            </td>
                        </tr>
                    </xsl:for-each>
                </table>
            </body>
        </html>
    </xsl:template>
</xsl:stylesheet>

<!-- Pedro H Perpétuo CB3021688 & Igor Benites CB3021734 -->
