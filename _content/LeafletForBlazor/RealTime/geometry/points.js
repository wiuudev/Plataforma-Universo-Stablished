let streamPointCollection = [], _renderType = "circleMarker", _classAppearanceByAttributes = [], _defaultCircleMarker = { radius: 15, color: "#22ffff", weight: 4, fillColor: "#28ffff", opacity: .75 }; export const _initializationOfRendering = t => { _renderType = t }; export const _resetOfRendering = () => { _classAppearanceByAttributes = [] }; export const _settingsOfRendering = t => { let e = t.map(t => t.guid), o = _classAppearanceByAttributes.filter(t => -1 === e.indexOf(t.guid)); _classAppearanceByAttributes = [...o, ...t], streamPointCollection.forEach(t => { let e = _classAppearanceByAttributes.filter(e => e.guid === t.guid), o = streamPointCollection.filter(e => e.guid === t.guid); 0 !== o.length && 0 !== e.length && o[0].marker.setStyle(e[0].symbol) }) }; export const _emptyStreamPointCollection = () => { streamPointCollection = [] }; export const _addPointToCollection = (t, e, o) => { if (!_pointValidateAndMessages(t)) return; let i = new o.marker([t.latitude, t.longitude], { opacity: 1 }), n = { guid: t.guid, marker: i, type: t.type, value: t.value }; streamPointCollection.push(n), i.addTo(e) }; export let _pointsLayersGroup = []; export const _addPointsToCollection = (t, e, o, i) => { if (e && (streamPointCollection = [], _pointsLayersGroup = []), !Array.isArray(t)) throw console.warm("is not Array points"), Error("is not Array points"); if (!_pointsValidateAndMessages(t)) throw console.warm("point(s) in Array is/are not valid"), Error("point(s) in Array is/are not valid"); let n = t.map(t => { let e = {}; if ("circleMarker" === _renderType) { let o = _classAppearanceByAttributes.filter(e => e.guid === t.guid); (e = new i.circleMarker([t.latitude, t.longitude], 0 !== o.length ? o[0].symbol : _defaultCircleMarker)).guid = t.guid } else if ("marker" === _renderType) { e = new i.marker([t.latitude, t.longitude], { opacity: 1 }); let n = L.icon({ iconUrl: `http://localhost:5141/${t.type}.png`, iconAnchor: [16, 16] }); e.setIcon(n) } return { guid: t.guid, marker: e, type: t.type, value: t.value } }); streamPointCollection = [...streamPointCollection, ...n]; let r = i.layerGroup(n.map(t => t.marker)); return r.type = 0 !== n.length ? n[0].type : "not exist", _pointsLayersGroup.push(r), r.addTo(o), streamPointCollection }; export const _addPointsOnType = (t, e, o, i) => { if (e && (streamPointCollection = [], _pointsLayersGroup = []), !Array.isArray(t)) throw console.warm("is not Array points"), Error("is not Array points"); if (!_pointsValidateAndMessages(t)) throw console.warm("point(s) in Array is/are not valid"), Error("point(s) in Array is/are not valid"); streamPointCollection = [...streamPointCollection, ...t.map(t => { let e = new i.marker([t.latitude, t.longitude], { opacity: 1 }); return { guid: t.guid, marker: e, type: t.type, value: t.value } })]; let n = i.layerGroup(streamPointCollection.map(t => t.marker)); _pointsLayersGroup.push(n), n.addTo(o) }; export const _clearAllPointsCollection = t => { for (let e of _pointsLayersGroup) t.removeLayer(e); streamPointCollection = [] }; export const _clearPointsByIdsCollection = (t, e) => { let o = streamPointCollection.filter(e => -1 !== t.indexOf(e.guid)), i = streamPointCollection.filter(e => -1 === t.indexOf(e.guid)); o.forEach(t => { e.removeLayer(t.marker) }), streamPointCollection = i }; export const _removePoints = (t, e) => { }; export const _removeType = (t, e) => { }; export const _movePointFromCollection = (t, e, o) => { if (!_pointValidateAndMessages(t)) return; t.guid; let i = streamPointCollection.filter(e => e.guid === t.guid); if (1 === i.length) { let n = i[0].marker, r = i[0].type, l = i[0].value; (t.type !== r || t.value !== l) && console.warn("You cannot change type and/or value using the moveTo method, sorry!"); var a = o.latLng(t.latitude, t.longitude); n.setLatLng(a) } else if (0 === i.length) throw console.warn("id(s) does not exist in the Geometric.Points collection"), Error("id(s) does not exist in the Geometric.Points collection"); else throw console.warn("Duplicated in the collection of points of Geometric.Points"), Error("Duplicated in the collection of points of Geometric.Points") }; let _pointValidateAndMessages = t => { let e = !0; if (null == t) throw console.warm("Point is not valid"), Error("Point is not valid"); if (void 0 === t.latitude || null === t.latitude) throw console.warm("latiude value is not valid"), Error("latiude value is not valid"); if (void 0 === t.longitude || null === t.longitude) throw console.warm("longitude value is not valid"), Error("longitude value is not valid"); if ("number" != typeof t.latitude || "number" != typeof t.longitude) throw console.warm("longitude and/or latitude value is not a number"), Error("longitude and/or latitude value is not a number"); return e }, _pointsValidateAndMessages = t => { let e = !0; for (let o of t) if (!_pointValidateAndMessages(o)) return !1; return e }; export function _asa_trebuie_facuta_scalarea_layerelor(t, e) { let o = 1e4, i = 0; if ("undefined" != typeof symbology && null !== symbology && void 0 !== symbology.scaling && null !== symbology.scaling) { let n = symbology.scaling; void 0 !== n.start_with && null !== n.start_with && (i = parseInt(n.start_with)), void 0 !== n.stop_with && null !== n.stop_with && (o = parseInt(n.stop_with)) } !1 == (0 === i && 1e4 === o) && e.on("zoomend", function () { parseInt(e.getZoom()) >= i && parseInt(e.getZoom()) <= o ? e.addLayer(layer) : e.removeLayer(layer) }) }