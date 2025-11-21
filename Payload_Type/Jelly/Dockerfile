FROM mcr.microsoft.com/dotnet/sdk:8.0
RUN apt-get update && apt-get install python3 python3-pip python3.11-venv -y

# Build and store donut at ROOT level (won't be overwritten)
RUN curl -L -o donut_shellcode-2.0.0.tar.gz https://github.com/MEhrn00/donut/releases/download/v2.0.0/donut_shellcode-2.0.0.tar.gz && \
    tar -xf donut_shellcode-2.0.0.tar.gz && \
    cd donut_shellcode-2.0.0 && \
    make && \
    cp donut / && \
    rm -rf donut_shellcode-2.0.0 && \
    rm -rf donut_shellcode-2.0.0.tar.gz

# Create Python venv at ROOT level (won't be overwritten)  
RUN python3 -m venv /venv
RUN /venv/bin/python -m pip install mythic-container==0.6.6 mslex impacket toml
RUN /venv/bin/python -m pip install git+https://github.com/MEhrn00/donut.git@v2.0.0

# Copy COFFLoader.dll to ROOT level (won't be overwritten)
WORKDIR /Mythic/
COPY [".", "."]
RUN cd Jelly/agent_code && dotnet restore
RUN cd Jelly/agent_code && cp COFFLoader.dll /COFFLoader.dll

# At runtime: copy donut from root to the mounted volume, then run
CMD ["bash", "-c", "cp /donut Jelly/agent_code/donut && /venv/bin/python main.py"]