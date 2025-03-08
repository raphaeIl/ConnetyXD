from mitmproxy import ctx
from mitmproxy import http
import json

packets = []
seqCount = 0

def load(loader):
    # ctx.options.web_open_browser = False
    ctx.options.connection_strategy = "lazy"
    ctx.options.upstream_cert = False
    ctx.options.ssl_insecure = True
    ctx.options.allow_hosts = ['hybegames.com', 'hybeim.com']

def response(flow: http.HTTPFlow) -> None:
    # if flow.request.url.startswith('/oz/game'):
    req = json.loads(flow.request.text)
    resp = json.loads(flow.response.text)
    global seqCount
    
    print(f'[REQ] {req}')
    print(f'[RESP] {resp}')

    request_json_data = {
        "payload": req,
        "type": "REQUEST",
        "url": flow.request.url,
        "seq": seqCount
    }

    response_json_data = {
        "payload": resp,
        "type": "RESPONSE",
        "url": flow.request.url,
        "seq": seqCount
    }

    packets.append(request_json_data)
    packets.append(response_json_data)

    with open('./packets.json', 'w') as f:
        json.dump(packets, f, indent=4)

    seqCount += 1