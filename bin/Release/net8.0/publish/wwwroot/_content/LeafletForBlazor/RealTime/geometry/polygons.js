﻿let defaultSymbol = { color: "#22ffff", weight: 1, fillColor: "#28ffff", opacity: .75 }, currentSymbol = null, displayPolygonLayerGroup = null; export const _setCurrentSymbol = o => { currentSymbol = JSON.parse(o) }; export const _addPolygonsArrayToMap = (o, l, r) => { null === currentSymbol && (currentSymbol = defaultSymbol); var y = JSON.parse(o.toString()); null === displayPolygonLayerGroup ? (displayPolygonLayerGroup = r.featureGroup().addTo(l)).addLayer(r.polygon(y, currentSymbol)) : displayPolygonLayerGroup.addLayer(r.polygon(y, currentSymbol)), l.fitBounds(displayPolygonLayerGroup.getBounds()), currentSymbol = null };